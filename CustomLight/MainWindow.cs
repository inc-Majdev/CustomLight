using Clevo;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CustomLight
{
    public partial class MainWindow : MaterialForm
    {
        private ColorAnimationGenerator animationGenerator;

        public MainWindow(string[] args)
        {
            InitializeComponent();
            if (args.Length > 0 && args[0] == "autostart")
            {
                this.Visible = false;
                this.Opacity = 0;
                this.ShowInTaskbar = false;
            }
            animationGenerator = new ColorAnimationGenerator();
            animationGenerator.ColorChanged += AnimationGenerator_ColorChanged;
        }

        private void AnimationGenerator_ColorChanged(object sender, ColorChangedEventArgs e)
        {
            if (txtModeSelector.SelectedIndex == 1)
            {
                InsydeDCHU.SetColor(e.NewColor.R, e.NewColor.G, e.NewColor.B, e.NewColor.A);
            }
        }

        private void SetColor(Color color)
        {
            CustomLight.Properties.Settings.Default.CurrentColor = color;
            lblCurrentColor.BackColor = color;
            txtHexColor.Text = ColorTranslator.ToHtml(color);
            txtColorRedCode.Text = color.R.ToString();
            txtColorGreenCode.Text = color.G.ToString();
            txtColorBlueCode.Text = color.B.ToString();
            sliderBrightness.Value = color.A;
            InsydeDCHU.SetColor(color.R, color.G, color.B, color.A);
            Properties.Settings.Default.Save();
            switchKeyboardLight.Checked = true;
        }

        private void SetSpeed(int speed)
        {
            if (speed > 3 || speed < 1)
                return;

            animationGenerator.SetAnimationSpeed(speed);
            CustomLight.Properties.Settings.Default.CurrentSpeed = speed;
            Properties.Settings.Default.Save();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            checkRunStartup.Checked = CustomLight.Properties.Settings.Default.RunStartup;
            checkRunBackground.Checked = CustomLight.Properties.Settings.Default.RunBackground;
            trackAnimationSpeed.Value = CustomLight.Properties.Settings.Default.CurrentSpeed;
            tabControl.SelectedIndex = 0;
            colorPickerMode.SelectedIndex = 0;

            txtModeSelector.SelectedIndex = CustomLight.Properties.Settings.Default.CurrentMode == "Animation" ? 1 : 0;

            switch (CustomLight.Properties.Settings.Default.CurrentAnimationMode)
            {
                case "Rainbow":
                case "":
                    txtAnimationSelector.SelectedIndex = 1;
                    break;
                case "RandomColor":
                    txtAnimationSelector.SelectedIndex = 2;
                    break;
                case "RandomFlash":
                    txtAnimationSelector.SelectedIndex = 3;
                    break;
                case "ColorFlash":
                    txtAnimationSelector.SelectedIndex = 4;
                    break;
                case "RandomBreathing":
                    txtAnimationSelector.SelectedIndex = 5;
                    break;
                case "ColorBreathing":
                    txtAnimationSelector.SelectedIndex = 6;
                    break;
            }

            notifyIcon.Visible = CustomLight.Properties.Settings.Default.RunBackground;
            switchKeyboardLight.Checked = InsydeDCHU.GetPowerState();

            InsydeDCHU.TurnOn();
            SetColor(CustomLight.Properties.Settings.Default.CurrentColor);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CustomLight.Properties.Settings.Default.RunBackground)
            {
                e.Cancel = true;
                this.Hide();
                return;
            }
            InsydeDCHU.TurnOn();
            SetColor(CustomLight.Properties.Settings.Default.CurrentColor);
            Process.GetProcessById(Process.GetCurrentProcess().Id).Kill();
        }

        private void AddProgramToStartup(bool add)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (add)
            {
                registryKey.SetValue("Custom Light", "\"" + Application.ExecutablePath + "\" autostart");
            }
            else
            {
                registryKey.DeleteValue("Custom Light", false);
            }
        }

        private void checkRunStartup_CheckedChanged(object sender, EventArgs e)
        {
            CustomLight.Properties.Settings.Default.RunStartup = checkRunStartup.Checked;
            CustomLight.Properties.Settings.Default.Save();
            AddProgramToStartup(checkRunStartup.Checked);
        }

        private void checkRunBackground_CheckedChanged(object sender, EventArgs e)
        {
            CustomLight.Properties.Settings.Default.RunBackground = checkRunBackground.Checked;
            CustomLight.Properties.Settings.Default.Save();
            notifyIcon.Visible = checkRunBackground.Checked;
        }

        private void colorCustomHexagon_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            CustomLight.Properties.Settings.Default.CurrentAnimationColor = colorCustomHexagon.SelectedColor;
            CustomLight.Properties.Settings.Default.Save();
            animationGenerator.SetCustomColor(colorCustomHexagon.SelectedColor);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Process.GetProcessById(Process.GetCurrentProcess().Id).Kill();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Opacity = 100;
            this.Show();
        }

        private void colorHexagon_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            SetColor(colorHexagon.SelectedColor);
        }

        private void colorWheel_ColorChanged(object sender, EventArgs e)
        {
            SetColor(colorWheel.Color);
        }

        private void colorRedCode_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int number;
                if (!int.TryParse(textBox.Text, out number) || number > 255)
                {
                    textBox.Clear();
                }
            }

            try
            {
                int red = Convert.ToInt32(txtColorRedCode.Text);
                int green = Convert.ToInt32(txtColorGreenCode.Text);
                int blue = Convert.ToInt32(txtColorBlueCode.Text);
                if ((red >= 0 && red <= 255) && (green >= 0 && green <= 255) && (blue >= 0 && blue <= 255))
                {
                    SetColor(Color.FromArgb(red, green, blue));
                }
            }
            catch { }
        }

        private void switchKeyboardLight_CheckedChanged(object sender, EventArgs e)
        {
            if (switchKeyboardLight.Checked)
            {
                InsydeDCHU.TurnOn();
                SetColor(CustomLight.Properties.Settings.Default.CurrentColor);
            }
            else
            {
                InsydeDCHU.TurnOff();
            }
        }

        private void sliderBrightness_onValueChanged(object sender, int newValue)
        {
            InsydeDCHU.SetBrightness(Convert.ToByte(newValue));
        }

        private void txtModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabMode.SelectedIndex = txtModeSelector.SelectedIndex;
            CustomLight.Properties.Settings.Default.CurrentMode = txtModeSelector.SelectedIndex == 1 ? "Animation" : "Static";
            CustomLight.Properties.Settings.Default.Save();
            switchKeyboardLight.Checked = true;
        }

        private void txtAnimationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAnimationSelector.SelectedIndex == 0)
            {
                txtAnimationSelector.SelectedIndex = 1;
                return;
            }

            ColorAnimationMode animationMode;
            bool isVisible = true;

            switch (txtAnimationSelector.SelectedIndex)
            {
                case 1:
                    animationMode = ColorAnimationMode.Rainbow;
                    isVisible = false;
                    break;
                case 2:
                    animationMode = ColorAnimationMode.RandomColor;
                    isVisible = false;
                    break;
                case 3:
                    animationMode = ColorAnimationMode.RandomFlash;
                    isVisible = false;
                    break;
                case 4:
                    animationMode = ColorAnimationMode.ColorFlash;
                    break;
                case 5:
                    animationMode = ColorAnimationMode.RandomBreathing;
                    isVisible = false;
                    break;
                case 6:
                    animationMode = ColorAnimationMode.ColorBreathing;
                    break;
                default:
                    return;
            }

            CustomLight.Properties.Settings.Default.CurrentAnimationMode = txtAnimationSelector.SelectedItem.ToString();
            animationGenerator.StartAnimation(animationMode, CustomLight.Properties.Settings.Default.CurrentAnimationColor, trackAnimationSpeed.Value);
            CustomLight.Properties.Settings.Default.Save();
            colorCustomHexagon.Visible = isVisible;
        }

        private void trackAnimationSpeed_Scroll(object sender, EventArgs e)
        {
            SetSpeed(trackAnimationSpeed.Value);
        }

        private void checkDefaultSettings_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Properties.Settings.Default.Save();
            Process.GetProcessById(Process.GetCurrentProcess().Id).Kill();
        }
    }
}
