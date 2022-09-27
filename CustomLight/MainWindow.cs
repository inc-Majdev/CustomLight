using Clevo;
using CustomLight.Animations;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CustomLight
{
    public partial class MainWindow : MaterialForm
    {
        public MainWindow(string[] args)
        {
            InitializeComponent();
            if(args.Count() > 0)
            {
                if(args[0] == "autostart")
                {
                    this.Opacity = 0;
                    this.ShowInTaskbar = false;
                }
            }
        }

        Color Color;
        bool Close = false;

        void AddStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                registryKey.SetValue("CustomLight", "\"" + Application.ExecutablePath + "\" autostart");
            }
            catch {}
            Properties.Settings.Default.RunAtStartup = true;
            Properties.Settings.Default.Save();
        }

        void RemoveStartup()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                registryKey.DeleteValue("CustomLight");
            }
            catch { }
            Properties.Settings.Default.RunAtStartup = false;
            Properties.Settings.Default.Save();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName("CustomLight").Length > 1)
            {
                Close = true;
                Application.Exit();
            }
            TabControl.SelectedIndex = 0;
            ModeSelector.SelectedIndex = 0;
            ColorPickerMode.SelectedIndex = 0;
            SaveButton.Visible = false;
            ColorFlashHexagon.Visible = false;
            AnimationSpeed.Location = new Point(171, 70);
            CheckAnimation.RunWorkerAsync();
            if (Properties.Settings.Default.RunAtStartup == true) {
                AddStartup();
                RunAtStartup.Checked = true;
            }
            else
            {
                RemoveStartup();
                RunAtStartup.Checked = false;
            }
            AnimationSpeed.Value = Properties.Settings.Default.AnimationSpeed;
            try
            {
                if (Properties.Settings.Default.Color == "Rainbow")
                {
                    ModeSelector.SelectedIndex = 1;
                    AnimationSelector.SelectedIndex = 0;
                }
                if (Properties.Settings.Default.Color == "RandomColor")
                {
                    ModeSelector.SelectedIndex = 1;
                    AnimationSelector.SelectedIndex = 1;
                }
                else if (Properties.Settings.Default.Color == "RandomFlash")
                {
                    ModeSelector.SelectedIndex = 1;
                    AnimationSelector.SelectedIndex = 2;
                }
                else if (Properties.Settings.Default.Color == "ColorFlash")
                {
                    ModeSelector.SelectedIndex = 1;
                    AnimationSelector.SelectedIndex = 3;
                }
                else if (Properties.Settings.Default.Color == "RandomBreathing")
                {
                    ModeSelector.SelectedIndex = 1;
                    AnimationSelector.SelectedIndex = 4;
                }
                else if (Properties.Settings.Default.Color == "ColorBreathing")
                {
                    ModeSelector.SelectedIndex = 1;
                    AnimationSelector.SelectedIndex = 5;
                }
                else
                {
                    CurrentColor.BackColor = ColorTranslator.FromHtml(Properties.Settings.Default.Color);
                }
            }
            catch
            {
                CurrentColor.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        void SendColor()
        {
            if (ModeSelector.SelectedIndex == 0)
            {
                if (InsydeDCHU.CheckSupport() == false)
                {
                    MaterialDialog Dialog = new MaterialDialog(this, "Custom Light", "No compatible device found.", false);
                    Dialog.ShowDialog(this);
                    Application.Exit();
                }
                InsydeDCHU.TurnOn();
                InsydeDCHU.OverrideBootEffect(false);
                InsydeDCHU.SetColor(Color.R, Color.G, Color.B);
                InsydeDCHU.SetBrightness(Color.A);
                Properties.Settings.Default.Color = ColorTranslator.ToHtml(Color);
                Properties.Settings.Default.Save();
            }
        }
        private void AutoSaveSwitch_CheckedChanged(object sender, EventArgs e)
        {
            SaveButton.Visible = !AutoSaveSwitch.Checked;
        }

        private void CurrentColor_BackColorChanged(object sender, EventArgs e)
        {
            Color = Color.FromArgb(CurrentColor.BackColor.R, CurrentColor.BackColor.G, CurrentColor.BackColor.B);
            HexColorTextbox.Text = ColorTranslator.ToHtml(Color);
            ColorRedCode.Text = Color.R.ToString();
            ColorGreenCode.Text = Color.G.ToString();
            ColorBlueCode.Text = Color.B.ToString();
            if (AutoSaveSwitch.Checked == true)
            {
                SendColor();
            }
        }

        private void ColorHexagon_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            CurrentColor.BackColor = ColorHexagon.SelectedColor;
        }

        private void ColorWheel_ColorChanged(object sender, EventArgs e)
        {
            CurrentColor.BackColor = ColorWheel.Color;
        }

        private void ColorCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ColorCode_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int Number = Convert.ToInt32(textBox.Text);
                if(Number > 255)
                {
                    textBox.Clear();
                }
            }

            try
            {
                int Red = Convert.ToInt32(ColorRedCode.Text);
                int Green = Convert.ToInt32(ColorGreenCode.Text);
                int Blue = Convert.ToInt32(ColorBlueCode.Text);
                if ((Red >= 0 && Red <= 255) && (Green >= 0 && Green <= 255) && (Blue >= 0 && Blue <= 255))
                {
                    Color Color = Color.FromArgb(Red, Green, Blue);
                    CurrentColor.BackColor = Color;
                }
            }
            catch
            {
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SendColor();
        }

        private void Brightness_onValueChanged(object sender, int newValue)
        {
            InsydeDCHU.SetBrightness(Convert.ToByte(newValue));
        }

        private void ModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModeSelector.SelectedIndex == 2)
            {
                InsydeDCHU.TurnOff();
            }
            else
            {
                SendColor();
                ModeTabControl.SelectedIndex = ModeSelector.SelectedIndex;
            }
        }

        private void ProtectionLoop_Tick(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "LedKeyboardSetting")
                {
                    p.Kill();
                }
            }
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.ShowInTaskbar = true;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Close == false)
            {
                WorkBackground.Start();
                e.Cancel = true;
                return;
            }
        }

        private void WorkBackground_Tick(object sender, EventArgs e)
        {
            WorkBackground.Stop();
            MaterialDialog Dialog = new MaterialDialog(this, "Custom Light", "Keep running in the background?", "OK", true, "CLOSE");
            DialogResult Result = Dialog.ShowDialog(this);
            if(Result.ToString() == "OK")
            {
                Close = false;
                this.Opacity = 0;
                this.ShowInTaskbar = false;
            }
            else
            {
                Close = true;
                Application.Exit();
            }
        }

        int BreathingBrightness = 255;

        private void AnimationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AnimationSelector.SelectedIndex)
            {
                case 0:
                    ColorFlashHexagon.Visible = false;
                    AnimationSpeed.Location = new Point(171, 70);
                    Properties.Settings.Default.Color = "Rainbow";
                    Properties.Settings.Default.Save();
                    BrightnessBreathing.Value = 255;
                    Breathing.Stop();
                    Rainbow.SetSpeed(AnimationSpeed.Value);
                    break;
                case 1:
                    ColorFlashHexagon.Visible = false;
                    AnimationSpeed.Location = new Point(171, 70);
                    Properties.Settings.Default.Color = "RandomColor";
                    Properties.Settings.Default.Save();
                    BrightnessBreathing.Value = 255;
                    Breathing.Stop();
                    RandomColor.SetSpeed(AnimationSpeed.Value);
                    break;
                case 2:
                    ColorFlashHexagon.Visible = false;
                    AnimationSpeed.Location = new Point(171, 70);
                    Properties.Settings.Default.Color = "RandomFlash";
                    Properties.Settings.Default.Save();
                    BrightnessBreathing.Value = 255;
                    Breathing.Stop();
                    RandomFlash.SetSpeed(AnimationSpeed.Value);
                    break;
                case 3:
                    ColorFlashHexagon.Visible = true;
                    ColorFlashHexagon.Location = new Point(171, 61);
                    AnimationSpeed.Location = new Point(171, 441);
                    Properties.Settings.Default.Color = "ColorFlash";
                    Properties.Settings.Default.Save();
                    BrightnessBreathing.Value = 255;
                    Breathing.Stop();
                    ColorFlash.SetSpeed(AnimationSpeed.Value);
                    break;
                case 4:
                    ColorFlashHexagon.Visible = false;
                    AnimationSpeed.Location = new Point(171, 70);
                    Properties.Settings.Default.Color = "RandomBreathing";
                    Properties.Settings.Default.Save();
                    Breathing.Stop();
                    Breathing.Interval = 5 * AnimationSpeed.Value;
                    BrightnessBreathing.Value = 255;
                    Breathing.Start();
                    RandomColor.SetSpeed(AnimationSpeed.Value);
                    break;
                case 5:
                    ColorFlashHexagon.Visible = true;
                    ColorFlashHexagon.Location = new Point(171, 61);
                    AnimationSpeed.Location = new Point(171, 441);
                    Properties.Settings.Default.Color = "ColorBreathing";
                    Properties.Settings.Default.Save();
                    BrightnessBreathing.Value = 255;
                    Breathing.Stop();
                    BrightnessBreathing.Value = 255;
                    Breathing.Start();
                    ColorBreathing.SetSpeed(AnimationSpeed.Value);
                    break;
            }
        }

        private void AnimationSpeed_onValueChanged(object sender, int newValue)
        {
            Properties.Settings.Default.AnimationSpeed = newValue;
            Properties.Settings.Default.Save();
            switch (AnimationSelector.SelectedIndex)
            {
                case 0:
                    Rainbow.SetSpeed(newValue);
                    break;
                case 1:
                    RandomColor.SetSpeed(newValue);
                    break;
                case 2:
                    RandomFlash.SetSpeed(newValue);
                    break;
                case 3:
                    ColorFlash.SetSpeed(newValue);
                    break;
                case 4:
                    RandomColor.SetSpeed(newValue);
                    Breathing.Stop();
                    if (AnimationSpeed.Value <= 0)
                    {
                        AnimationSpeed.Value = 1;
                    }
                    Breathing.Interval = 20 / AnimationSpeed.Value;
                    BrightnessBreathing.Value = 255;
                    Breathing.Start();
                    break;
                case 5:
                    RandomColor.SetSpeed(newValue);
                    Breathing.Stop();
                    if(AnimationSpeed.Value <= 0)
                    {
                        AnimationSpeed.Value = 1;
                    }
                    Breathing.Interval = 20 / AnimationSpeed.Value;
                    BrightnessBreathing.Value = 255;
                    Breathing.Start();
                    break;
            }
        }


        private void CheckAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            Rainbow.Setup();
            RandomFlash.Setup();
            ColorFlash.Setup(ColorTranslator.FromHtml(Properties.Settings.Default.Color2));
            RandomColor.Setup();
            ColorBreathing.Setup(ColorTranslator.FromHtml(Properties.Settings.Default.Color2));
            while (true)
            {
                if (ModeSelector.SelectedIndex == 1)
                {
                    if (InsydeDCHU.CheckSupport() == false)
                    {
                        MaterialDialog Dialog = new MaterialDialog(this, "Custom Light", "No compatible device found.", false);
                        Dialog.ShowDialog(this);
                        Close = true;
                        Application.Exit();
                    }
                    switch (AnimationSelector.SelectedIndex)
                    {
                        case 0:
                            InsydeDCHU.SetColor(Rainbow.CurrentColor.R, Rainbow.CurrentColor.G, Rainbow.CurrentColor.B);
                            InsydeDCHU.SetBrightness(255);
                            break;
                        case 1:
                            InsydeDCHU.SetColor(RandomColor.CurrentColor.R, RandomColor.CurrentColor.G, RandomColor.CurrentColor.B);
                            InsydeDCHU.SetBrightness(255);
                            break;
                        case 2:
                            InsydeDCHU.SetColor(RandomFlash.CurrentColor.R, RandomFlash.CurrentColor.G, RandomFlash.CurrentColor.B);
                            InsydeDCHU.SetBrightness(255);
                            break;
                        case 3:
                            InsydeDCHU.SetColor(ColorFlash.CurrentColor.R, ColorFlash.CurrentColor.G, ColorFlash.CurrentColor.B);
                            InsydeDCHU.SetBrightness(255);
                            break;
                        case 4:
                            InsydeDCHU.SetColor(RandomColor.CurrentColor.R, RandomColor.CurrentColor.G, RandomColor.CurrentColor.B);
                            InsydeDCHU.SetBrightness(Convert.ToByte(BrightnessBreathing.Value));
                            break;
                        case 5:
                            InsydeDCHU.SetColor(ColorBreathing.CurrentColor.R, ColorBreathing.CurrentColor.G, ColorBreathing.CurrentColor.B);
                            InsydeDCHU.SetBrightness(Convert.ToByte(BrightnessBreathing.Value));
                            break;
                    }
                }
            }
        }

        private void ColorFlashHexagon_ColorChanged(object sender, MechanikaDesign.WinForms.UI.ColorPicker.ColorChangedEventArgs args)
        {
            ColorFlash.Setup(ColorFlashHexagon.SelectedColor);
            ColorBreathing.Setup(ColorFlashHexagon.SelectedColor);
            Properties.Settings.Default.Color2 = ColorTranslator.ToHtml(ColorFlashHexagon.SelectedColor);
            Properties.Settings.Default.Save();
        }

        private void RunAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            if(RunAtStartup.Checked == true)
            {
                AddStartup();
            }
            else
            {
                RemoveStartup();
            }
        }

        int Mode = 1;
        private void Breathing_Tick(object sender, EventArgs e)
        {
            if(BrightnessBreathing.Value <= 0)
            {
                Mode = 2;
            }

            if (BrightnessBreathing.Value >= 255)
            {
                Mode = 1;
            }

            if (Mode == 1)
            {
                BrightnessBreathing.Value--;
            }
            else if (Mode == 2)
            {
                BrightnessBreathing.Value++;
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/inc-Majdev");
        }
    }
}
