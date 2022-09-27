namespace CustomLight
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            MaterialSkin.Controls.MaterialLabel ColorBlueLabel;
            MaterialSkin.Controls.MaterialLabel ColorGreenLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabManageLights = new System.Windows.Forms.TabPage();
            this.BrightnessBreathing = new MaterialSkin.Controls.MaterialSlider();
            this.RunAtStartup = new MaterialSkin.Controls.MaterialCheckbox();
            this.ModeTabControl = new System.Windows.Forms.TabControl();
            this.TabStaticMode = new System.Windows.Forms.TabPage();
            this.Brightness = new MaterialSkin.Controls.MaterialSlider();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.AutoSaveSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.ColorHexLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CurrentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HexColorTextbox = new MaterialSkin.Controls.MaterialTextBox2();
            this.MaterialDivider = new MaterialSkin.Controls.MaterialDivider();
            this.CurrentColor = new System.Windows.Forms.Label();
            this.ColorPickerMode = new MaterialSkin.Controls.MaterialTabControl();
            this.TabHexagon = new System.Windows.Forms.TabPage();
            this.ColorHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.TabWheel = new System.Windows.Forms.TabPage();
            this.ColorWheel = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.TabColorCode = new System.Windows.Forms.TabPage();
            this.ColorGreenCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.ColorBlueCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.ColorRedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ColorRedCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabAnimationMode = new System.Windows.Forms.TabPage();
            this.ColorFlashHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.AnimationSpeed = new MaterialSkin.Controls.MaterialSlider();
            this.AnimationSelector = new MaterialSkin.Controls.MaterialComboBox();
            this.ModeSelector = new MaterialSkin.Controls.MaterialComboBox();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.ProtectionLoop = new System.Windows.Forms.Timer(this.components);
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.WorkBackground = new System.Windows.Forms.Timer(this.components);
            this.CheckAnimation = new System.ComponentModel.BackgroundWorker();
            this.Breathing = new System.Windows.Forms.Timer(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ExpansionAbout4Panel = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.AboutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            ColorBlueLabel = new MaterialSkin.Controls.MaterialLabel();
            ColorGreenLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TabControl.SuspendLayout();
            this.TabManageLights.SuspendLayout();
            this.ModeTabControl.SuspendLayout();
            this.TabStaticMode.SuspendLayout();
            this.ColorPickerMode.SuspendLayout();
            this.TabHexagon.SuspendLayout();
            this.TabWheel.SuspendLayout();
            this.TabColorCode.SuspendLayout();
            this.TabAnimationMode.SuspendLayout();
            this.TabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ExpansionAbout4Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorBlueLabel
            // 
            ColorBlueLabel.AutoSize = true;
            ColorBlueLabel.Depth = 0;
            ColorBlueLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            ColorBlueLabel.Location = new System.Drawing.Point(20, 185);
            ColorBlueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            ColorBlueLabel.Name = "ColorBlueLabel";
            ColorBlueLabel.Size = new System.Drawing.Size(36, 19);
            ColorBlueLabel.TabIndex = 75;
            ColorBlueLabel.Text = "Blue:";
            // 
            // ColorGreenLabel
            // 
            ColorGreenLabel.AutoSize = true;
            ColorGreenLabel.Depth = 0;
            ColorGreenLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            ColorGreenLabel.Location = new System.Drawing.Point(20, 102);
            ColorGreenLabel.MouseState = MaterialSkin.MouseState.HOVER;
            ColorGreenLabel.Name = "ColorGreenLabel";
            ColorGreenLabel.Size = new System.Drawing.Size(46, 19);
            ColorGreenLabel.TabIndex = 77;
            ColorGreenLabel.Text = "Green:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabManageLights);
            this.TabControl.Controls.Add(this.TabAbout);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(-5, 72);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1019, 706);
            this.TabControl.TabIndex = 0;
            // 
            // TabManageLights
            // 
            this.TabManageLights.BackColor = System.Drawing.Color.White;
            this.TabManageLights.Controls.Add(this.BrightnessBreathing);
            this.TabManageLights.Controls.Add(this.RunAtStartup);
            this.TabManageLights.Controls.Add(this.ModeTabControl);
            this.TabManageLights.Controls.Add(this.ModeSelector);
            this.TabManageLights.Location = new System.Drawing.Point(4, 22);
            this.TabManageLights.Name = "TabManageLights";
            this.TabManageLights.Padding = new System.Windows.Forms.Padding(3);
            this.TabManageLights.Size = new System.Drawing.Size(1011, 680);
            this.TabManageLights.TabIndex = 0;
            this.TabManageLights.Text = "Manage Lights";
            // 
            // BrightnessBreathing
            // 
            this.BrightnessBreathing.Depth = 0;
            this.BrightnessBreathing.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BrightnessBreathing.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.BrightnessBreathing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BrightnessBreathing.Location = new System.Drawing.Point(32767, 32767);
            this.BrightnessBreathing.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrightnessBreathing.Name = "BrightnessBreathing";
            this.BrightnessBreathing.RangeMax = 255;
            this.BrightnessBreathing.ShowValue = false;
            this.BrightnessBreathing.Size = new System.Drawing.Size(363, 40);
            this.BrightnessBreathing.TabIndex = 83;
            this.BrightnessBreathing.Text = "";
            this.BrightnessBreathing.Value = 255;
            this.BrightnessBreathing.ValueMax = 255;
            this.BrightnessBreathing.Visible = false;
            // 
            // RunAtStartup
            // 
            this.RunAtStartup.AutoSize = true;
            this.RunAtStartup.Checked = true;
            this.RunAtStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunAtStartup.Depth = 0;
            this.RunAtStartup.Location = new System.Drawing.Point(841, 70);
            this.RunAtStartup.Margin = new System.Windows.Forms.Padding(0);
            this.RunAtStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RunAtStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.RunAtStartup.Name = "RunAtStartup";
            this.RunAtStartup.ReadOnly = false;
            this.RunAtStartup.Ripple = true;
            this.RunAtStartup.Size = new System.Drawing.Size(137, 37);
            this.RunAtStartup.TabIndex = 2;
            this.RunAtStartup.Text = "Run at Startup";
            this.RunAtStartup.UseVisualStyleBackColor = true;
            this.RunAtStartup.CheckedChanged += new System.EventHandler(this.RunAtStartup_CheckedChanged);
            // 
            // ModeTabControl
            // 
            this.ModeTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ModeTabControl.Controls.Add(this.TabStaticMode);
            this.ModeTabControl.Controls.Add(this.TabAnimationMode);
            this.ModeTabControl.Location = new System.Drawing.Point(-143, 110);
            this.ModeTabControl.Multiline = true;
            this.ModeTabControl.Name = "ModeTabControl";
            this.ModeTabControl.SelectedIndex = 0;
            this.ModeTabControl.Size = new System.Drawing.Size(1234, 615);
            this.ModeTabControl.TabIndex = 1;
            // 
            // TabStaticMode
            // 
            this.TabStaticMode.BackColor = System.Drawing.Color.White;
            this.TabStaticMode.Controls.Add(this.Brightness);
            this.TabStaticMode.Controls.Add(this.SaveButton);
            this.TabStaticMode.Controls.Add(this.AutoSaveSwitch);
            this.TabStaticMode.Controls.Add(this.ColorHexLabel);
            this.TabStaticMode.Controls.Add(this.CurrentLabel);
            this.TabStaticMode.Controls.Add(this.HexColorTextbox);
            this.TabStaticMode.Controls.Add(this.MaterialDivider);
            this.TabStaticMode.Controls.Add(this.CurrentColor);
            this.TabStaticMode.Controls.Add(this.ColorPickerMode);
            this.TabStaticMode.Controls.Add(this.TabSelector);
            this.TabStaticMode.Location = new System.Drawing.Point(4, 4);
            this.TabStaticMode.Name = "TabStaticMode";
            this.TabStaticMode.Padding = new System.Windows.Forms.Padding(3);
            this.TabStaticMode.Size = new System.Drawing.Size(1226, 589);
            this.TabStaticMode.TabIndex = 0;
            this.TabStaticMode.Text = "tabPage1";
            // 
            // Brightness
            // 
            this.Brightness.Depth = 0;
            this.Brightness.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Brightness.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.Brightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Brightness.Location = new System.Drawing.Point(719, 222);
            this.Brightness.MouseState = MaterialSkin.MouseState.HOVER;
            this.Brightness.Name = "Brightness";
            this.Brightness.RangeMax = 255;
            this.Brightness.ShowValue = false;
            this.Brightness.Size = new System.Drawing.Size(363, 40);
            this.Brightness.TabIndex = 82;
            this.Brightness.Text = "Brightness";
            this.Brightness.Value = 255;
            this.Brightness.ValueMax = 255;
            this.Brightness.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.Brightness_onValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = false;
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(722, 322);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveButton.Size = new System.Drawing.Size(360, 36);
            this.SaveButton.TabIndex = 81;
            this.SaveButton.Text = "Save";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = true;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AutoSaveSwitch
            // 
            this.AutoSaveSwitch.AutoSize = true;
            this.AutoSaveSwitch.Checked = true;
            this.AutoSaveSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSaveSwitch.Depth = 0;
            this.AutoSaveSwitch.Location = new System.Drawing.Point(719, 279);
            this.AutoSaveSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.AutoSaveSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutoSaveSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoSaveSwitch.Name = "AutoSaveSwitch";
            this.AutoSaveSwitch.Ripple = true;
            this.AutoSaveSwitch.Size = new System.Drawing.Size(130, 37);
            this.AutoSaveSwitch.TabIndex = 80;
            this.AutoSaveSwitch.Text = "Auto Save";
            this.AutoSaveSwitch.UseVisualStyleBackColor = true;
            this.AutoSaveSwitch.CheckedChanged += new System.EventHandler(this.AutoSaveSwitch_CheckedChanged);
            // 
            // ColorHexLabel
            // 
            this.ColorHexLabel.AutoSize = true;
            this.ColorHexLabel.Depth = 0;
            this.ColorHexLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorHexLabel.Location = new System.Drawing.Point(719, 136);
            this.ColorHexLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorHexLabel.Name = "ColorHexLabel";
            this.ColorHexLabel.Size = new System.Drawing.Size(73, 19);
            this.ColorHexLabel.TabIndex = 79;
            this.ColorHexLabel.Text = "Color Hex:";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.AutoSize = true;
            this.CurrentLabel.Depth = 0;
            this.CurrentLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CurrentLabel.Location = new System.Drawing.Point(719, 73);
            this.CurrentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(97, 19);
            this.CurrentLabel.TabIndex = 78;
            this.CurrentLabel.Text = "Current Color:";
            // 
            // HexColorTextbox
            // 
            this.HexColorTextbox.AnimateReadOnly = true;
            this.HexColorTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.HexColorTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.HexColorTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HexColorTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.HexColorTextbox.Depth = 0;
            this.HexColorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.HexColorTextbox.HideSelection = true;
            this.HexColorTextbox.LeadingIcon = null;
            this.HexColorTextbox.Location = new System.Drawing.Point(719, 158);
            this.HexColorTextbox.MaxLength = 32767;
            this.HexColorTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.HexColorTextbox.Name = "HexColorTextbox";
            this.HexColorTextbox.PasswordChar = '\0';
            this.HexColorTextbox.PrefixSuffixText = "$";
            this.HexColorTextbox.ReadOnly = true;
            this.HexColorTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HexColorTextbox.SelectedText = "";
            this.HexColorTextbox.SelectionLength = 0;
            this.HexColorTextbox.SelectionStart = 0;
            this.HexColorTextbox.ShortcutsEnabled = true;
            this.HexColorTextbox.ShowAssistiveText = true;
            this.HexColorTextbox.Size = new System.Drawing.Size(363, 64);
            this.HexColorTextbox.TabIndex = 77;
            this.HexColorTextbox.TabStop = false;
            this.HexColorTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HexColorTextbox.TrailingIcon = null;
            this.HexColorTextbox.UseSystemPasswordChar = false;
            // 
            // MaterialDivider
            // 
            this.MaterialDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaterialDivider.Depth = 0;
            this.MaterialDivider.Location = new System.Drawing.Point(709, 72);
            this.MaterialDivider.Margin = new System.Windows.Forms.Padding(0);
            this.MaterialDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialDivider.Name = "MaterialDivider";
            this.MaterialDivider.Size = new System.Drawing.Size(1, 400);
            this.MaterialDivider.TabIndex = 24;
            this.MaterialDivider.Text = "materialDivider1";
            // 
            // CurrentColor
            // 
            this.CurrentColor.BackColor = System.Drawing.Color.White;
            this.CurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentColor.Location = new System.Drawing.Point(719, 94);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(363, 32);
            this.CurrentColor.TabIndex = 20;
            this.CurrentColor.BackColorChanged += new System.EventHandler(this.CurrentColor_BackColorChanged);
            // 
            // ColorPickerMode
            // 
            this.ColorPickerMode.Controls.Add(this.TabHexagon);
            this.ColorPickerMode.Controls.Add(this.TabWheel);
            this.ColorPickerMode.Controls.Add(this.TabColorCode);
            this.ColorPickerMode.Depth = 0;
            this.ColorPickerMode.Location = new System.Drawing.Point(204, 56);
            this.ColorPickerMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorPickerMode.Multiline = true;
            this.ColorPickerMode.Name = "ColorPickerMode";
            this.ColorPickerMode.SelectedIndex = 0;
            this.ColorPickerMode.Size = new System.Drawing.Size(496, 428);
            this.ColorPickerMode.TabIndex = 19;
            // 
            // TabHexagon
            // 
            this.TabHexagon.BackColor = System.Drawing.Color.White;
            this.TabHexagon.Controls.Add(this.ColorHexagon);
            this.TabHexagon.Location = new System.Drawing.Point(4, 22);
            this.TabHexagon.Name = "TabHexagon";
            this.TabHexagon.Padding = new System.Windows.Forms.Padding(3);
            this.TabHexagon.Size = new System.Drawing.Size(488, 402);
            this.TabHexagon.TabIndex = 0;
            this.TabHexagon.Text = "Color Hexagon";
            // 
            // ColorHexagon
            // 
            this.ColorHexagon.Location = new System.Drawing.Point(53, 8);
            this.ColorHexagon.Name = "ColorHexagon";
            this.ColorHexagon.Size = new System.Drawing.Size(388, 388);
            this.ColorHexagon.TabIndex = 0;
            this.ColorHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.ColorHexagon_ColorChanged);
            // 
            // TabWheel
            // 
            this.TabWheel.BackColor = System.Drawing.Color.White;
            this.TabWheel.Controls.Add(this.ColorWheel);
            this.TabWheel.Location = new System.Drawing.Point(4, 22);
            this.TabWheel.Name = "TabWheel";
            this.TabWheel.Padding = new System.Windows.Forms.Padding(3);
            this.TabWheel.Size = new System.Drawing.Size(488, 402);
            this.TabWheel.TabIndex = 1;
            this.TabWheel.Text = "Color Wheel";
            // 
            // ColorWheel
            // 
            this.ColorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorWheel.Location = new System.Drawing.Point(7, 4);
            this.ColorWheel.Name = "ColorWheel";
            this.ColorWheel.Size = new System.Drawing.Size(475, 395);
            this.ColorWheel.TabIndex = 0;
            this.ColorWheel.Text = "colorWheel1";
            this.ColorWheel.ColorChanged += new System.EventHandler(this.ColorWheel_ColorChanged);
            // 
            // TabColorCode
            // 
            this.TabColorCode.BackColor = System.Drawing.Color.White;
            this.TabColorCode.Controls.Add(ColorGreenLabel);
            this.TabColorCode.Controls.Add(this.ColorGreenCode);
            this.TabColorCode.Controls.Add(ColorBlueLabel);
            this.TabColorCode.Controls.Add(this.ColorBlueCode);
            this.TabColorCode.Controls.Add(this.ColorRedLabel);
            this.TabColorCode.Controls.Add(this.ColorRedCode);
            this.TabColorCode.Location = new System.Drawing.Point(4, 22);
            this.TabColorCode.Name = "TabColorCode";
            this.TabColorCode.Size = new System.Drawing.Size(488, 402);
            this.TabColorCode.TabIndex = 2;
            this.TabColorCode.Text = "Color Code";
            // 
            // ColorGreenCode
            // 
            this.ColorGreenCode.AnimateReadOnly = false;
            this.ColorGreenCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ColorGreenCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ColorGreenCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorGreenCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ColorGreenCode.Depth = 0;
            this.ColorGreenCode.ErrorMessage = "Invalid entry";
            this.ColorGreenCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorGreenCode.HelperText = "Range: 0-255";
            this.ColorGreenCode.HideSelection = true;
            this.ColorGreenCode.LeadingIcon = null;
            this.ColorGreenCode.Location = new System.Drawing.Point(17, 124);
            this.ColorGreenCode.MaxLength = 32767;
            this.ColorGreenCode.MouseState = MaterialSkin.MouseState.OUT;
            this.ColorGreenCode.Name = "ColorGreenCode";
            this.ColorGreenCode.PasswordChar = '\0';
            this.ColorGreenCode.PrefixSuffixText = "$";
            this.ColorGreenCode.ReadOnly = false;
            this.ColorGreenCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorGreenCode.SelectedText = "";
            this.ColorGreenCode.SelectionLength = 0;
            this.ColorGreenCode.SelectionStart = 0;
            this.ColorGreenCode.ShortcutsEnabled = true;
            this.ColorGreenCode.ShowAssistiveText = true;
            this.ColorGreenCode.Size = new System.Drawing.Size(452, 64);
            this.ColorGreenCode.TabIndex = 76;
            this.ColorGreenCode.TabStop = false;
            this.ColorGreenCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ColorGreenCode.TrailingIcon = null;
            this.ColorGreenCode.UseSystemPasswordChar = false;
            this.ColorGreenCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorCode_KeyPress);
            this.ColorGreenCode.TextChanged += new System.EventHandler(this.ColorCode_TextChanged);
            // 
            // ColorBlueCode
            // 
            this.ColorBlueCode.AnimateReadOnly = false;
            this.ColorBlueCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ColorBlueCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ColorBlueCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorBlueCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ColorBlueCode.Depth = 0;
            this.ColorBlueCode.ErrorMessage = "Invalid entry";
            this.ColorBlueCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorBlueCode.HelperText = "Range: 0-255";
            this.ColorBlueCode.HideSelection = true;
            this.ColorBlueCode.LeadingIcon = null;
            this.ColorBlueCode.Location = new System.Drawing.Point(17, 207);
            this.ColorBlueCode.MaxLength = 32767;
            this.ColorBlueCode.MouseState = MaterialSkin.MouseState.OUT;
            this.ColorBlueCode.Name = "ColorBlueCode";
            this.ColorBlueCode.PasswordChar = '\0';
            this.ColorBlueCode.PrefixSuffixText = "$";
            this.ColorBlueCode.ReadOnly = false;
            this.ColorBlueCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorBlueCode.SelectedText = "";
            this.ColorBlueCode.SelectionLength = 0;
            this.ColorBlueCode.SelectionStart = 0;
            this.ColorBlueCode.ShortcutsEnabled = true;
            this.ColorBlueCode.ShowAssistiveText = true;
            this.ColorBlueCode.Size = new System.Drawing.Size(452, 64);
            this.ColorBlueCode.TabIndex = 74;
            this.ColorBlueCode.TabStop = false;
            this.ColorBlueCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ColorBlueCode.TrailingIcon = null;
            this.ColorBlueCode.UseSystemPasswordChar = false;
            this.ColorBlueCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorCode_KeyPress);
            this.ColorBlueCode.TextChanged += new System.EventHandler(this.ColorCode_TextChanged);
            // 
            // ColorRedLabel
            // 
            this.ColorRedLabel.AutoSize = true;
            this.ColorRedLabel.Depth = 0;
            this.ColorRedLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorRedLabel.Location = new System.Drawing.Point(20, 18);
            this.ColorRedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColorRedLabel.Name = "ColorRedLabel";
            this.ColorRedLabel.Size = new System.Drawing.Size(32, 19);
            this.ColorRedLabel.TabIndex = 73;
            this.ColorRedLabel.Text = "Red:";
            // 
            // ColorRedCode
            // 
            this.ColorRedCode.AnimateReadOnly = false;
            this.ColorRedCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ColorRedCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ColorRedCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ColorRedCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ColorRedCode.Depth = 0;
            this.ColorRedCode.ErrorMessage = "Invalid entry";
            this.ColorRedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColorRedCode.HelperText = "Range: 0-255";
            this.ColorRedCode.HideSelection = true;
            this.ColorRedCode.LeadingIcon = null;
            this.ColorRedCode.Location = new System.Drawing.Point(17, 40);
            this.ColorRedCode.MaxLength = 3;
            this.ColorRedCode.MouseState = MaterialSkin.MouseState.OUT;
            this.ColorRedCode.Name = "ColorRedCode";
            this.ColorRedCode.PasswordChar = '\0';
            this.ColorRedCode.PrefixSuffixText = "$";
            this.ColorRedCode.ReadOnly = false;
            this.ColorRedCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorRedCode.SelectedText = "";
            this.ColorRedCode.SelectionLength = 0;
            this.ColorRedCode.SelectionStart = 0;
            this.ColorRedCode.ShortcutsEnabled = true;
            this.ColorRedCode.ShowAssistiveText = true;
            this.ColorRedCode.Size = new System.Drawing.Size(452, 64);
            this.ColorRedCode.TabIndex = 72;
            this.ColorRedCode.TabStop = false;
            this.ColorRedCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ColorRedCode.TrailingIcon = null;
            this.ColorRedCode.UseSystemPasswordChar = false;
            this.ColorRedCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorCode_KeyPress);
            this.ColorRedCode.TextChanged += new System.EventHandler(this.ColorCode_TextChanged);
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BaseTabControl = this.ColorPickerMode;
            this.TabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelector.Depth = 0;
            this.TabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelector.Location = new System.Drawing.Point(204, 2);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(881, 48);
            this.TabSelector.TabIndex = 18;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // TabAnimationMode
            // 
            this.TabAnimationMode.BackColor = System.Drawing.Color.White;
            this.TabAnimationMode.Controls.Add(this.ColorFlashHexagon);
            this.TabAnimationMode.Controls.Add(this.AnimationSpeed);
            this.TabAnimationMode.Controls.Add(this.AnimationSelector);
            this.TabAnimationMode.Location = new System.Drawing.Point(4, 4);
            this.TabAnimationMode.Name = "TabAnimationMode";
            this.TabAnimationMode.Padding = new System.Windows.Forms.Padding(3);
            this.TabAnimationMode.Size = new System.Drawing.Size(1226, 589);
            this.TabAnimationMode.TabIndex = 1;
            this.TabAnimationMode.Text = "tabPage2";
            // 
            // ColorFlashHexagon
            // 
            this.ColorFlashHexagon.Location = new System.Drawing.Point(171, 61);
            this.ColorFlashHexagon.Name = "ColorFlashHexagon";
            this.ColorFlashHexagon.Size = new System.Drawing.Size(946, 362);
            this.ColorFlashHexagon.TabIndex = 68;
            this.ColorFlashHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.ColorFlashHexagon_ColorChanged);
            // 
            // AnimationSpeed
            // 
            this.AnimationSpeed.Depth = 0;
            this.AnimationSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AnimationSpeed.Location = new System.Drawing.Point(171, 441);
            this.AnimationSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.AnimationSpeed.Name = "AnimationSpeed";
            this.AnimationSpeed.RangeMax = 20;
            this.AnimationSpeed.RangeMin = 1;
            this.AnimationSpeed.ShowValue = false;
            this.AnimationSpeed.Size = new System.Drawing.Size(946, 40);
            this.AnimationSpeed.TabIndex = 67;
            this.AnimationSpeed.Text = "Speed";
            this.AnimationSpeed.Value = 5;
            this.AnimationSpeed.ValueMax = 20;
            this.AnimationSpeed.ValueSuffix = "1";
            this.AnimationSpeed.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.AnimationSpeed_onValueChanged);
            // 
            // AnimationSelector
            // 
            this.AnimationSelector.AutoResize = false;
            this.AnimationSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnimationSelector.Depth = 0;
            this.AnimationSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AnimationSelector.DropDownHeight = 174;
            this.AnimationSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnimationSelector.DropDownWidth = 121;
            this.AnimationSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AnimationSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AnimationSelector.FormattingEnabled = true;
            this.AnimationSelector.Hint = "Animation";
            this.AnimationSelector.IntegralHeight = false;
            this.AnimationSelector.ItemHeight = 43;
            this.AnimationSelector.Items.AddRange(new object[] {
            "Rainbow",
            "Random Color",
            "Random Flash",
            "Color Flash",
            "Random Breathing",
            "Color Breathing"});
            this.AnimationSelector.Location = new System.Drawing.Point(171, 6);
            this.AnimationSelector.MaxDropDownItems = 4;
            this.AnimationSelector.MouseState = MaterialSkin.MouseState.OUT;
            this.AnimationSelector.Name = "AnimationSelector";
            this.AnimationSelector.Size = new System.Drawing.Size(946, 49);
            this.AnimationSelector.StartIndex = 0;
            this.AnimationSelector.TabIndex = 1;
            this.AnimationSelector.SelectedIndexChanged += new System.EventHandler(this.AnimationSelector_SelectedIndexChanged);
            // 
            // ModeSelector
            // 
            this.ModeSelector.AutoResize = false;
            this.ModeSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ModeSelector.Depth = 0;
            this.ModeSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ModeSelector.DropDownHeight = 174;
            this.ModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelector.DropDownWidth = 121;
            this.ModeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ModeSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ModeSelector.FormattingEnabled = true;
            this.ModeSelector.Hint = "Light Mode";
            this.ModeSelector.IntegralHeight = false;
            this.ModeSelector.ItemHeight = 43;
            this.ModeSelector.Items.AddRange(new object[] {
            "Static",
            "Animation",
            "Disabled"});
            this.ModeSelector.Location = new System.Drawing.Point(32, 18);
            this.ModeSelector.MaxDropDownItems = 4;
            this.ModeSelector.MouseState = MaterialSkin.MouseState.OUT;
            this.ModeSelector.Name = "ModeSelector";
            this.ModeSelector.Size = new System.Drawing.Size(946, 49);
            this.ModeSelector.StartIndex = 0;
            this.ModeSelector.TabIndex = 0;
            this.ModeSelector.SelectedIndexChanged += new System.EventHandler(this.ModeSelector_SelectedIndexChanged);
            // 
            // TabAbout
            // 
            this.TabAbout.BackColor = System.Drawing.Color.White;
            this.TabAbout.Controls.Add(this.ExpansionAbout4Panel);
            this.TabAbout.Location = new System.Drawing.Point(4, 22);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(1011, 680);
            this.TabAbout.TabIndex = 1;
            this.TabAbout.Text = "About";
            // 
            // ProtectionLoop
            // 
            this.ProtectionLoop.Enabled = true;
            this.ProtectionLoop.Tick += new System.EventHandler(this.ProtectionLoop_Tick);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Custom Light";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_Click);
            // 
            // WorkBackground
            // 
            this.WorkBackground.Tick += new System.EventHandler(this.WorkBackground_Tick);
            // 
            // CheckAnimation
            // 
            this.CheckAnimation.WorkerReportsProgress = true;
            this.CheckAnimation.WorkerSupportsCancellation = true;
            this.CheckAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckAnimation_DoWork);
            // 
            // Breathing
            // 
            this.Breathing.Interval = 10;
            this.Breathing.Tick += new System.EventHandler(this.Breathing_Tick);
            // 
            // Logo
            // 
            this.Logo.Image = global::CustomLight.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(178, 333);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(348, 109);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // ExpansionAbout4Panel
            // 
            this.ExpansionAbout4Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExpansionAbout4Panel.Controls.Add(this.DeveloperLabel);
            this.ExpansionAbout4Panel.Controls.Add(this.Logo);
            this.ExpansionAbout4Panel.Controls.Add(this.AboutLabel);
            this.ExpansionAbout4Panel.Depth = 0;
            this.ExpansionAbout4Panel.ExpandHeight = 461;
            this.ExpansionAbout4Panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ExpansionAbout4Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExpansionAbout4Panel.Location = new System.Drawing.Point(152, 42);
            this.ExpansionAbout4Panel.Margin = new System.Windows.Forms.Padding(16);
            this.ExpansionAbout4Panel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExpansionAbout4Panel.Name = "ExpansionAbout4Panel";
            this.ExpansionAbout4Panel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.ExpansionAbout4Panel.ShowValidationButtons = false;
            this.ExpansionAbout4Panel.Size = new System.Drawing.Size(689, 461);
            this.ExpansionAbout4Panel.TabIndex = 1;
            this.ExpansionAbout4Panel.Title = "Custom Light";
            // 
            // AboutLabel
            // 
            this.AboutLabel.Depth = 0;
            this.AboutLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AboutLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.AboutLabel.Location = new System.Drawing.Point(12, 64);
            this.AboutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(667, 230);
            this.AboutLabel.TabIndex = 2;
            this.AboutLabel.Text = "Forget the old-fashioned software the manufacturer gave you to manage the lights " +
    "and discover the magic of lights with us!";
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeveloperLabel.Location = new System.Drawing.Point(175, 312);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(106, 18);
            this.DeveloperLabel.TabIndex = 3;
            this.DeveloperLabel.Text = "Developed by";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.TabControl);
            this.DrawerTabControl = this.TabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Light (v1.0)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TabControl.ResumeLayout(false);
            this.TabManageLights.ResumeLayout(false);
            this.TabManageLights.PerformLayout();
            this.ModeTabControl.ResumeLayout(false);
            this.TabStaticMode.ResumeLayout(false);
            this.TabStaticMode.PerformLayout();
            this.ColorPickerMode.ResumeLayout(false);
            this.TabHexagon.ResumeLayout(false);
            this.TabWheel.ResumeLayout(false);
            this.TabColorCode.ResumeLayout(false);
            this.TabColorCode.PerformLayout();
            this.TabAnimationMode.ResumeLayout(false);
            this.TabAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ExpansionAbout4Panel.ResumeLayout(false);
            this.ExpansionAbout4Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage TabManageLights;
        private System.Windows.Forms.TabPage TabAbout;
        private MaterialSkin.Controls.MaterialComboBox ModeSelector;
        private System.Windows.Forms.TabControl ModeTabControl;
        private System.Windows.Forms.TabPage TabStaticMode;
        private System.Windows.Forms.TabPage TabAnimationMode;
        private MaterialSkin.Controls.MaterialTabControl ColorPickerMode;
        private System.Windows.Forms.TabPage TabHexagon;
        private System.Windows.Forms.TabPage TabWheel;
        private System.Windows.Forms.TabPage TabColorCode;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private System.Windows.Forms.Label CurrentColor;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon ColorHexagon;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel ColorWheel;
        private MaterialSkin.Controls.MaterialTextBox2 ColorRedCode;
        private MaterialSkin.Controls.MaterialLabel ColorRedLabel;
        private MaterialSkin.Controls.MaterialTextBox2 ColorGreenCode;
        private MaterialSkin.Controls.MaterialTextBox2 ColorBlueCode;
        private MaterialSkin.Controls.MaterialDivider MaterialDivider;
        private MaterialSkin.Controls.MaterialTextBox2 HexColorTextbox;
        private MaterialSkin.Controls.MaterialLabel ColorHexLabel;
        private MaterialSkin.Controls.MaterialLabel CurrentLabel;
        private MaterialSkin.Controls.MaterialSwitch AutoSaveSwitch;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialSlider Brightness;
        private System.Windows.Forms.Timer ProtectionLoop;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer WorkBackground;
        private MaterialSkin.Controls.MaterialSlider AnimationSpeed;
        private MaterialSkin.Controls.MaterialComboBox AnimationSelector;
        private System.ComponentModel.BackgroundWorker CheckAnimation;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon ColorFlashHexagon;
        private MaterialSkin.Controls.MaterialCheckbox RunAtStartup;
        private System.Windows.Forms.Timer Breathing;
        private MaterialSkin.Controls.MaterialSlider BrightnessBreathing;
        private MaterialSkin.Controls.MaterialExpansionPanel ExpansionAbout4Panel;
        private System.Windows.Forms.PictureBox Logo;
        private MaterialSkin.Controls.MaterialLabel AboutLabel;
        private System.Windows.Forms.Label DeveloperLabel;
    }
}