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
            MaterialSkin.Controls.MaterialLabel lblColorBlue;
            MaterialSkin.Controls.MaterialLabel lblColorGreen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabManageLights = new System.Windows.Forms.TabPage();
            this.switchKeyboardLight = new MaterialSkin.Controls.MaterialSwitch();
            this.checkRunStartup = new MaterialSkin.Controls.MaterialCheckbox();
            this.checkRunBackground = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tabStaticMode = new System.Windows.Forms.TabPage();
            this.sliderBrightness = new MaterialSkin.Controls.MaterialSlider();
            this.lblColorHex = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrent = new MaterialSkin.Controls.MaterialLabel();
            this.txtHexColor = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider = new MaterialSkin.Controls.MaterialDivider();
            this.lblCurrentColor = new System.Windows.Forms.Label();
            this.colorPickerMode = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHexagon = new System.Windows.Forms.TabPage();
            this.colorHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.tabWheel = new System.Windows.Forms.TabPage();
            this.colorWheel = new MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel();
            this.tabColorCode = new System.Windows.Forms.TabPage();
            this.txtColorGreenCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtColorBlueCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblColorRed = new MaterialSkin.Controls.MaterialLabel();
            this.txtColorRedCode = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabAnimationMode = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.trackAnimationSpeed = new System.Windows.Forms.TrackBar();
            this.colorCustomHexagon = new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon();
            this.txtAnimationSelector = new MaterialSkin.Controls.MaterialComboBox();
            this.txtModeSelector = new MaterialSkin.Controls.MaterialComboBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.panelAbout = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblAbout = new MaterialSkin.Controls.MaterialLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDefaultSettings = new MaterialSkin.Controls.MaterialCheckbox();
            lblColorBlue = new MaterialSkin.Controls.MaterialLabel();
            lblColorGreen = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl.SuspendLayout();
            this.tabManageLights.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tabStaticMode.SuspendLayout();
            this.colorPickerMode.SuspendLayout();
            this.tabHexagon.SuspendLayout();
            this.tabWheel.SuspendLayout();
            this.tabColorCode.SuspendLayout();
            this.tabAnimationMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackAnimationSpeed)).BeginInit();
            this.tabAbout.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColorBlue
            // 
            lblColorBlue.AutoSize = true;
            lblColorBlue.Depth = 0;
            lblColorBlue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblColorBlue.Location = new System.Drawing.Point(20, 185);
            lblColorBlue.MouseState = MaterialSkin.MouseState.HOVER;
            lblColorBlue.Name = "lblColorBlue";
            lblColorBlue.Size = new System.Drawing.Size(36, 19);
            lblColorBlue.TabIndex = 75;
            lblColorBlue.Text = "Blue:";
            // 
            // lblColorGreen
            // 
            lblColorGreen.AutoSize = true;
            lblColorGreen.Depth = 0;
            lblColorGreen.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblColorGreen.Location = new System.Drawing.Point(20, 102);
            lblColorGreen.MouseState = MaterialSkin.MouseState.HOVER;
            lblColorGreen.Name = "lblColorGreen";
            lblColorGreen.Size = new System.Drawing.Size(46, 19);
            lblColorGreen.TabIndex = 77;
            lblColorGreen.Text = "Green:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabManageLights);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(-5, 72);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1019, 706);
            this.tabControl.TabIndex = 0;
            // 
            // tabManageLights
            // 
            this.tabManageLights.BackColor = System.Drawing.Color.White;
            this.tabManageLights.Controls.Add(this.checkDefaultSettings);
            this.tabManageLights.Controls.Add(this.switchKeyboardLight);
            this.tabManageLights.Controls.Add(this.checkRunStartup);
            this.tabManageLights.Controls.Add(this.checkRunBackground);
            this.tabManageLights.Controls.Add(this.tabMode);
            this.tabManageLights.Controls.Add(this.txtModeSelector);
            this.tabManageLights.Location = new System.Drawing.Point(4, 22);
            this.tabManageLights.Name = "tabManageLights";
            this.tabManageLights.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageLights.Size = new System.Drawing.Size(1011, 680);
            this.tabManageLights.TabIndex = 0;
            this.tabManageLights.Text = "Manage Lights";
            // 
            // switchKeyboardLight
            // 
            this.switchKeyboardLight.AutoSize = true;
            this.switchKeyboardLight.Depth = 0;
            this.switchKeyboardLight.Location = new System.Drawing.Point(32, 70);
            this.switchKeyboardLight.Margin = new System.Windows.Forms.Padding(0);
            this.switchKeyboardLight.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchKeyboardLight.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchKeyboardLight.Name = "switchKeyboardLight";
            this.switchKeyboardLight.Ripple = true;
            this.switchKeyboardLight.Size = new System.Drawing.Size(165, 37);
            this.switchKeyboardLight.TabIndex = 86;
            this.switchKeyboardLight.Text = "Keyboard Light";
            this.switchKeyboardLight.UseVisualStyleBackColor = true;
            this.switchKeyboardLight.CheckedChanged += new System.EventHandler(this.switchKeyboardLight_CheckedChanged);
            // 
            // checkRunStartup
            // 
            this.checkRunStartup.AutoSize = true;
            this.checkRunStartup.Depth = 0;
            this.checkRunStartup.Location = new System.Drawing.Point(660, 70);
            this.checkRunStartup.Margin = new System.Windows.Forms.Padding(0);
            this.checkRunStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRunStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRunStartup.Name = "checkRunStartup";
            this.checkRunStartup.ReadOnly = false;
            this.checkRunStartup.Ripple = true;
            this.checkRunStartup.Size = new System.Drawing.Size(137, 37);
            this.checkRunStartup.TabIndex = 85;
            this.checkRunStartup.Text = "Run at Startup";
            this.checkRunStartup.UseVisualStyleBackColor = true;
            this.checkRunStartup.CheckedChanged += new System.EventHandler(this.checkRunStartup_CheckedChanged);
            // 
            // checkRunBackground
            // 
            this.checkRunBackground.AutoSize = true;
            this.checkRunBackground.Depth = 0;
            this.checkRunBackground.Location = new System.Drawing.Point(809, 70);
            this.checkRunBackground.Margin = new System.Windows.Forms.Padding(0);
            this.checkRunBackground.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkRunBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkRunBackground.Name = "checkRunBackground";
            this.checkRunBackground.ReadOnly = false;
            this.checkRunBackground.Ripple = true;
            this.checkRunBackground.Size = new System.Drawing.Size(169, 37);
            this.checkRunBackground.TabIndex = 84;
            this.checkRunBackground.Text = "Run in Background";
            this.checkRunBackground.UseVisualStyleBackColor = true;
            this.checkRunBackground.CheckedChanged += new System.EventHandler(this.checkRunBackground_CheckedChanged);
            // 
            // tabMode
            // 
            this.tabMode.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabMode.Controls.Add(this.tabStaticMode);
            this.tabMode.Controls.Add(this.tabAnimationMode);
            this.tabMode.Location = new System.Drawing.Point(-143, 110);
            this.tabMode.Multiline = true;
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(1234, 615);
            this.tabMode.TabIndex = 1;
            // 
            // tabStaticMode
            // 
            this.tabStaticMode.BackColor = System.Drawing.Color.White;
            this.tabStaticMode.Controls.Add(this.sliderBrightness);
            this.tabStaticMode.Controls.Add(this.lblColorHex);
            this.tabStaticMode.Controls.Add(this.lblCurrent);
            this.tabStaticMode.Controls.Add(this.txtHexColor);
            this.tabStaticMode.Controls.Add(this.materialDivider);
            this.tabStaticMode.Controls.Add(this.lblCurrentColor);
            this.tabStaticMode.Controls.Add(this.colorPickerMode);
            this.tabStaticMode.Controls.Add(this.tabSelector);
            this.tabStaticMode.Location = new System.Drawing.Point(4, 4);
            this.tabStaticMode.Name = "tabStaticMode";
            this.tabStaticMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaticMode.Size = new System.Drawing.Size(1226, 589);
            this.tabStaticMode.TabIndex = 0;
            this.tabStaticMode.Text = "tabPage1";
            // 
            // sliderBrightness
            // 
            this.sliderBrightness.Depth = 0;
            this.sliderBrightness.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.sliderBrightness.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.sliderBrightness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderBrightness.Location = new System.Drawing.Point(719, 222);
            this.sliderBrightness.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderBrightness.Name = "sliderBrightness";
            this.sliderBrightness.RangeMax = 255;
            this.sliderBrightness.ShowValue = false;
            this.sliderBrightness.Size = new System.Drawing.Size(363, 40);
            this.sliderBrightness.TabIndex = 82;
            this.sliderBrightness.Text = "Brightness";
            this.sliderBrightness.Value = 255;
            this.sliderBrightness.ValueMax = 255;
            this.sliderBrightness.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.sliderBrightness_onValueChanged);
            // 
            // lblColorHex
            // 
            this.lblColorHex.AutoSize = true;
            this.lblColorHex.Depth = 0;
            this.lblColorHex.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblColorHex.Location = new System.Drawing.Point(719, 136);
            this.lblColorHex.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblColorHex.Name = "lblColorHex";
            this.lblColorHex.Size = new System.Drawing.Size(73, 19);
            this.lblColorHex.TabIndex = 79;
            this.lblColorHex.Text = "Color Hex:";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Depth = 0;
            this.lblCurrent.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrent.Location = new System.Drawing.Point(719, 73);
            this.lblCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(97, 19);
            this.lblCurrent.TabIndex = 78;
            this.lblCurrent.Text = "Current Color:";
            // 
            // txtHexColor
            // 
            this.txtHexColor.AnimateReadOnly = true;
            this.txtHexColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtHexColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtHexColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHexColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHexColor.Depth = 0;
            this.txtHexColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHexColor.HideSelection = true;
            this.txtHexColor.LeadingIcon = null;
            this.txtHexColor.Location = new System.Drawing.Point(719, 158);
            this.txtHexColor.MaxLength = 32767;
            this.txtHexColor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHexColor.Name = "txtHexColor";
            this.txtHexColor.PasswordChar = '\0';
            this.txtHexColor.PrefixSuffixText = "$";
            this.txtHexColor.ReadOnly = true;
            this.txtHexColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHexColor.SelectedText = "";
            this.txtHexColor.SelectionLength = 0;
            this.txtHexColor.SelectionStart = 0;
            this.txtHexColor.ShortcutsEnabled = true;
            this.txtHexColor.ShowAssistiveText = true;
            this.txtHexColor.Size = new System.Drawing.Size(363, 64);
            this.txtHexColor.TabIndex = 77;
            this.txtHexColor.TabStop = false;
            this.txtHexColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHexColor.TrailingIcon = null;
            this.txtHexColor.UseSystemPasswordChar = false;
            // 
            // materialDivider
            // 
            this.materialDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider.Depth = 0;
            this.materialDivider.Location = new System.Drawing.Point(709, 72);
            this.materialDivider.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider.Name = "materialDivider";
            this.materialDivider.Size = new System.Drawing.Size(1, 400);
            this.materialDivider.TabIndex = 24;
            this.materialDivider.Text = "materialDivider1";
            // 
            // lblCurrentColor
            // 
            this.lblCurrentColor.BackColor = System.Drawing.Color.White;
            this.lblCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentColor.Location = new System.Drawing.Point(719, 94);
            this.lblCurrentColor.Name = "lblCurrentColor";
            this.lblCurrentColor.Size = new System.Drawing.Size(363, 32);
            this.lblCurrentColor.TabIndex = 20;
            // 
            // colorPickerMode
            // 
            this.colorPickerMode.Controls.Add(this.tabHexagon);
            this.colorPickerMode.Controls.Add(this.tabWheel);
            this.colorPickerMode.Controls.Add(this.tabColorCode);
            this.colorPickerMode.Depth = 0;
            this.colorPickerMode.Location = new System.Drawing.Point(204, 56);
            this.colorPickerMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.colorPickerMode.Multiline = true;
            this.colorPickerMode.Name = "colorPickerMode";
            this.colorPickerMode.SelectedIndex = 0;
            this.colorPickerMode.Size = new System.Drawing.Size(496, 428);
            this.colorPickerMode.TabIndex = 19;
            // 
            // tabHexagon
            // 
            this.tabHexagon.BackColor = System.Drawing.Color.White;
            this.tabHexagon.Controls.Add(this.colorHexagon);
            this.tabHexagon.Location = new System.Drawing.Point(4, 22);
            this.tabHexagon.Name = "tabHexagon";
            this.tabHexagon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHexagon.Size = new System.Drawing.Size(488, 402);
            this.tabHexagon.TabIndex = 0;
            this.tabHexagon.Text = "Color Hexagon";
            // 
            // colorHexagon
            // 
            this.colorHexagon.Location = new System.Drawing.Point(53, 8);
            this.colorHexagon.Name = "colorHexagon";
            this.colorHexagon.Size = new System.Drawing.Size(388, 388);
            this.colorHexagon.TabIndex = 0;
            this.colorHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.colorHexagon_ColorChanged);
            // 
            // tabWheel
            // 
            this.tabWheel.BackColor = System.Drawing.Color.White;
            this.tabWheel.Controls.Add(this.colorWheel);
            this.tabWheel.Location = new System.Drawing.Point(4, 22);
            this.tabWheel.Name = "tabWheel";
            this.tabWheel.Padding = new System.Windows.Forms.Padding(3);
            this.tabWheel.Size = new System.Drawing.Size(488, 402);
            this.tabWheel.TabIndex = 1;
            this.tabWheel.Text = "Color Wheel";
            // 
            // colorWheel
            // 
            this.colorWheel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel.Location = new System.Drawing.Point(7, 4);
            this.colorWheel.Name = "colorWheel";
            this.colorWheel.Size = new System.Drawing.Size(475, 395);
            this.colorWheel.TabIndex = 0;
            this.colorWheel.Text = "colorWheel1";
            this.colorWheel.ColorChanged += new System.EventHandler(this.colorWheel_ColorChanged);
            // 
            // tabColorCode
            // 
            this.tabColorCode.BackColor = System.Drawing.Color.White;
            this.tabColorCode.Controls.Add(lblColorGreen);
            this.tabColorCode.Controls.Add(this.txtColorGreenCode);
            this.tabColorCode.Controls.Add(lblColorBlue);
            this.tabColorCode.Controls.Add(this.txtColorBlueCode);
            this.tabColorCode.Controls.Add(this.lblColorRed);
            this.tabColorCode.Controls.Add(this.txtColorRedCode);
            this.tabColorCode.Location = new System.Drawing.Point(4, 22);
            this.tabColorCode.Name = "tabColorCode";
            this.tabColorCode.Size = new System.Drawing.Size(488, 402);
            this.tabColorCode.TabIndex = 2;
            this.tabColorCode.Text = "Color Code";
            // 
            // txtColorGreenCode
            // 
            this.txtColorGreenCode.AnimateReadOnly = false;
            this.txtColorGreenCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtColorGreenCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtColorGreenCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtColorGreenCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtColorGreenCode.Depth = 0;
            this.txtColorGreenCode.ErrorMessage = "Invalid entry";
            this.txtColorGreenCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColorGreenCode.HelperText = "Range: 0-255";
            this.txtColorGreenCode.HideSelection = true;
            this.txtColorGreenCode.LeadingIcon = null;
            this.txtColorGreenCode.Location = new System.Drawing.Point(17, 124);
            this.txtColorGreenCode.MaxLength = 32767;
            this.txtColorGreenCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColorGreenCode.Name = "txtColorGreenCode";
            this.txtColorGreenCode.PasswordChar = '\0';
            this.txtColorGreenCode.PrefixSuffixText = "$";
            this.txtColorGreenCode.ReadOnly = false;
            this.txtColorGreenCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColorGreenCode.SelectedText = "";
            this.txtColorGreenCode.SelectionLength = 0;
            this.txtColorGreenCode.SelectionStart = 0;
            this.txtColorGreenCode.ShortcutsEnabled = true;
            this.txtColorGreenCode.ShowAssistiveText = true;
            this.txtColorGreenCode.Size = new System.Drawing.Size(452, 64);
            this.txtColorGreenCode.TabIndex = 73;
            this.txtColorGreenCode.TabStop = false;
            this.txtColorGreenCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColorGreenCode.TrailingIcon = null;
            this.txtColorGreenCode.UseSystemPasswordChar = false;
            this.txtColorGreenCode.TextChanged += new System.EventHandler(this.colorRedCode_TextChanged);
            // 
            // txtColorBlueCode
            // 
            this.txtColorBlueCode.AnimateReadOnly = false;
            this.txtColorBlueCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtColorBlueCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtColorBlueCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtColorBlueCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtColorBlueCode.Depth = 0;
            this.txtColorBlueCode.ErrorMessage = "Invalid entry";
            this.txtColorBlueCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColorBlueCode.HelperText = "Range: 0-255";
            this.txtColorBlueCode.HideSelection = true;
            this.txtColorBlueCode.LeadingIcon = null;
            this.txtColorBlueCode.Location = new System.Drawing.Point(17, 207);
            this.txtColorBlueCode.MaxLength = 32767;
            this.txtColorBlueCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColorBlueCode.Name = "txtColorBlueCode";
            this.txtColorBlueCode.PasswordChar = '\0';
            this.txtColorBlueCode.PrefixSuffixText = "$";
            this.txtColorBlueCode.ReadOnly = false;
            this.txtColorBlueCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColorBlueCode.SelectedText = "";
            this.txtColorBlueCode.SelectionLength = 0;
            this.txtColorBlueCode.SelectionStart = 0;
            this.txtColorBlueCode.ShortcutsEnabled = true;
            this.txtColorBlueCode.ShowAssistiveText = true;
            this.txtColorBlueCode.Size = new System.Drawing.Size(452, 64);
            this.txtColorBlueCode.TabIndex = 74;
            this.txtColorBlueCode.TabStop = false;
            this.txtColorBlueCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColorBlueCode.TrailingIcon = null;
            this.txtColorBlueCode.UseSystemPasswordChar = false;
            this.txtColorBlueCode.TextChanged += new System.EventHandler(this.colorRedCode_TextChanged);
            // 
            // lblColorRed
            // 
            this.lblColorRed.AutoSize = true;
            this.lblColorRed.Depth = 0;
            this.lblColorRed.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblColorRed.Location = new System.Drawing.Point(20, 18);
            this.lblColorRed.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblColorRed.Name = "lblColorRed";
            this.lblColorRed.Size = new System.Drawing.Size(32, 19);
            this.lblColorRed.TabIndex = 73;
            this.lblColorRed.Text = "Red:";
            // 
            // txtColorRedCode
            // 
            this.txtColorRedCode.AnimateReadOnly = false;
            this.txtColorRedCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtColorRedCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtColorRedCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtColorRedCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtColorRedCode.Depth = 0;
            this.txtColorRedCode.ErrorMessage = "Invalid entry";
            this.txtColorRedCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtColorRedCode.HelperText = "Range: 0-255";
            this.txtColorRedCode.HideSelection = true;
            this.txtColorRedCode.LeadingIcon = null;
            this.txtColorRedCode.Location = new System.Drawing.Point(17, 40);
            this.txtColorRedCode.MaxLength = 3;
            this.txtColorRedCode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtColorRedCode.Name = "txtColorRedCode";
            this.txtColorRedCode.PasswordChar = '\0';
            this.txtColorRedCode.PrefixSuffixText = "$";
            this.txtColorRedCode.ReadOnly = false;
            this.txtColorRedCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColorRedCode.SelectedText = "";
            this.txtColorRedCode.SelectionLength = 0;
            this.txtColorRedCode.SelectionStart = 0;
            this.txtColorRedCode.ShortcutsEnabled = true;
            this.txtColorRedCode.ShowAssistiveText = true;
            this.txtColorRedCode.Size = new System.Drawing.Size(452, 64);
            this.txtColorRedCode.TabIndex = 72;
            this.txtColorRedCode.TabStop = false;
            this.txtColorRedCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtColorRedCode.TrailingIcon = null;
            this.txtColorRedCode.UseSystemPasswordChar = false;
            this.txtColorRedCode.TextChanged += new System.EventHandler(this.colorRedCode_TextChanged);
            // 
            // tabSelector
            // 
            this.tabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelector.BaseTabControl = this.colorPickerMode;
            this.tabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelector.Depth = 0;
            this.tabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelector.Location = new System.Drawing.Point(204, 2);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(881, 48);
            this.tabSelector.TabIndex = 18;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // tabAnimationMode
            // 
            this.tabAnimationMode.BackColor = System.Drawing.Color.White;
            this.tabAnimationMode.Controls.Add(this.materialLabel1);
            this.tabAnimationMode.Controls.Add(this.trackAnimationSpeed);
            this.tabAnimationMode.Controls.Add(this.colorCustomHexagon);
            this.tabAnimationMode.Controls.Add(this.txtAnimationSelector);
            this.tabAnimationMode.Location = new System.Drawing.Point(4, 4);
            this.tabAnimationMode.Name = "tabAnimationMode";
            this.tabAnimationMode.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimationMode.Size = new System.Drawing.Size(1226, 589);
            this.tabAnimationMode.TabIndex = 1;
            this.tabAnimationMode.Text = "tabPage2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(911, 61);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 71;
            this.materialLabel1.Text = "Speed:";
            // 
            // trackAnimationSpeed
            // 
            this.trackAnimationSpeed.Location = new System.Drawing.Point(965, 61);
            this.trackAnimationSpeed.Maximum = 3;
            this.trackAnimationSpeed.Minimum = 1;
            this.trackAnimationSpeed.Name = "trackAnimationSpeed";
            this.trackAnimationSpeed.Size = new System.Drawing.Size(152, 45);
            this.trackAnimationSpeed.TabIndex = 70;
            this.trackAnimationSpeed.Value = 2;
            this.trackAnimationSpeed.Scroll += new System.EventHandler(this.trackAnimationSpeed_Scroll);
            // 
            // colorCustomHexagon
            // 
            this.colorCustomHexagon.Location = new System.Drawing.Point(171, 61);
            this.colorCustomHexagon.Name = "colorCustomHexagon";
            this.colorCustomHexagon.Size = new System.Drawing.Size(946, 362);
            this.colorCustomHexagon.TabIndex = 68;
            this.colorCustomHexagon.ColorChanged += new MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon.ColorChangedEventHandler(this.colorCustomHexagon_ColorChanged);
            // 
            // txtAnimationSelector
            // 
            this.txtAnimationSelector.AutoResize = false;
            this.txtAnimationSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAnimationSelector.Depth = 0;
            this.txtAnimationSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtAnimationSelector.DropDownHeight = 174;
            this.txtAnimationSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAnimationSelector.DropDownWidth = 191;
            this.txtAnimationSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnimationSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAnimationSelector.FormattingEnabled = true;
            this.txtAnimationSelector.Hint = "Animation";
            this.txtAnimationSelector.IntegralHeight = false;
            this.txtAnimationSelector.ItemHeight = 43;
            this.txtAnimationSelector.Items.AddRange(new object[] {
            "",
            "Rainbow",
            "Random Color",
            "Random Flash",
            "Color Flash",
            "Random Breathing",
            "Color Breathing"});
            this.txtAnimationSelector.Location = new System.Drawing.Point(171, 6);
            this.txtAnimationSelector.MaxDropDownItems = 4;
            this.txtAnimationSelector.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAnimationSelector.Name = "txtAnimationSelector";
            this.txtAnimationSelector.Size = new System.Drawing.Size(946, 49);
            this.txtAnimationSelector.StartIndex = 0;
            this.txtAnimationSelector.TabIndex = 1;
            this.txtAnimationSelector.SelectedIndexChanged += new System.EventHandler(this.txtAnimationSelector_SelectedIndexChanged);
            // 
            // txtModeSelector
            // 
            this.txtModeSelector.AutoResize = false;
            this.txtModeSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtModeSelector.Depth = 0;
            this.txtModeSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtModeSelector.DropDownHeight = 174;
            this.txtModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtModeSelector.DropDownWidth = 121;
            this.txtModeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtModeSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtModeSelector.FormattingEnabled = true;
            this.txtModeSelector.Hint = "Light Mode";
            this.txtModeSelector.IntegralHeight = false;
            this.txtModeSelector.ItemHeight = 43;
            this.txtModeSelector.Items.AddRange(new object[] {
            "Static",
            "Animation"});
            this.txtModeSelector.Location = new System.Drawing.Point(32, 18);
            this.txtModeSelector.MaxDropDownItems = 4;
            this.txtModeSelector.MouseState = MaterialSkin.MouseState.OUT;
            this.txtModeSelector.Name = "txtModeSelector";
            this.txtModeSelector.Size = new System.Drawing.Size(946, 49);
            this.txtModeSelector.StartIndex = 0;
            this.txtModeSelector.TabIndex = 0;
            this.txtModeSelector.SelectedIndexChanged += new System.EventHandler(this.txtModeSelector_SelectedIndexChanged);
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.White;
            this.tabAbout.Controls.Add(this.panelAbout);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(1011, 680);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelAbout.Controls.Add(this.lblDeveloper);
            this.panelAbout.Controls.Add(this.imgLogo);
            this.panelAbout.Controls.Add(this.lblAbout);
            this.panelAbout.Depth = 0;
            this.panelAbout.ExpandHeight = 461;
            this.panelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panelAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelAbout.Location = new System.Drawing.Point(152, 42);
            this.panelAbout.Margin = new System.Windows.Forms.Padding(16);
            this.panelAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.panelAbout.ShowValidationButtons = false;
            this.panelAbout.Size = new System.Drawing.Size(689, 461);
            this.panelAbout.TabIndex = 1;
            this.panelAbout.Title = "Custom Light";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeveloper.Location = new System.Drawing.Point(175, 312);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(106, 18);
            this.lblDeveloper.TabIndex = 3;
            this.lblDeveloper.Text = "Developed by";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::CustomLight.Properties.Resources.Logo;
            this.imgLogo.Location = new System.Drawing.Point(178, 333);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(348, 109);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.Depth = 0;
            this.lblAbout.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAbout.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblAbout.Location = new System.Drawing.Point(12, 64);
            this.lblAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(667, 230);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "Forget the old-fashioned software the manufacturer gave you to manage the lights " +
    "and discover the magic of lights with us!";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Custom Light";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(94, 26);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(93, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // checkDefaultSettings
            // 
            this.checkDefaultSettings.AutoSize = true;
            this.checkDefaultSettings.Depth = 0;
            this.checkDefaultSettings.Location = new System.Drawing.Point(504, 70);
            this.checkDefaultSettings.Margin = new System.Windows.Forms.Padding(0);
            this.checkDefaultSettings.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkDefaultSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkDefaultSettings.Name = "checkDefaultSettings";
            this.checkDefaultSettings.ReadOnly = false;
            this.checkDefaultSettings.Ripple = true;
            this.checkDefaultSettings.Size = new System.Drawing.Size(149, 37);
            this.checkDefaultSettings.TabIndex = 87;
            this.checkDefaultSettings.Text = "Default Settings";
            this.checkDefaultSettings.UseVisualStyleBackColor = true;
            this.checkDefaultSettings.CheckedChanged += new System.EventHandler(this.checkDefaultSettings_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabControl);
            this.DrawerTabControl = this.tabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Light (v1.1)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabManageLights.ResumeLayout(false);
            this.tabManageLights.PerformLayout();
            this.tabMode.ResumeLayout(false);
            this.tabStaticMode.ResumeLayout(false);
            this.tabStaticMode.PerformLayout();
            this.colorPickerMode.ResumeLayout(false);
            this.tabHexagon.ResumeLayout(false);
            this.tabWheel.ResumeLayout(false);
            this.tabColorCode.ResumeLayout(false);
            this.tabColorCode.PerformLayout();
            this.tabAnimationMode.ResumeLayout(false);
            this.tabAnimationMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackAnimationSpeed)).EndInit();
            this.tabAbout.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabManageLights;
        private System.Windows.Forms.TabPage tabAbout;
        private MaterialSkin.Controls.MaterialComboBox txtModeSelector;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tabStaticMode;
        private MaterialSkin.Controls.MaterialTabControl colorPickerMode;
        private System.Windows.Forms.TabPage tabHexagon;
        private System.Windows.Forms.TabPage tabWheel;
        private System.Windows.Forms.TabPage tabColorCode;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.Label lblCurrentColor;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon colorHexagon;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel colorWheel;
        private MaterialSkin.Controls.MaterialTextBox2 txtColorRedCode;
        private MaterialSkin.Controls.MaterialLabel lblColorRed;
        private MaterialSkin.Controls.MaterialTextBox2 txtColorGreenCode;
        private MaterialSkin.Controls.MaterialTextBox2 txtColorBlueCode;
        private MaterialSkin.Controls.MaterialDivider materialDivider;
        private MaterialSkin.Controls.MaterialTextBox2 txtHexColor;
        private MaterialSkin.Controls.MaterialLabel lblColorHex;
        private MaterialSkin.Controls.MaterialLabel lblCurrent;
        private MaterialSkin.Controls.MaterialSlider sliderBrightness;
        private MaterialSkin.Controls.MaterialComboBox txtAnimationSelector;
        private MaterialSkin.Controls.MaterialExpansionPanel panelAbout;
        private System.Windows.Forms.PictureBox imgLogo;
        private MaterialSkin.Controls.MaterialLabel lblAbout;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private MaterialSkin.Controls.MaterialCheckbox checkRunStartup;
        private MaterialSkin.Controls.MaterialCheckbox checkRunBackground;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private MaterialSkin.Controls.MaterialSwitch switchKeyboardLight;
        private System.Windows.Forms.TabPage tabAnimationMode;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TrackBar trackAnimationSpeed;
        private MechanikaDesign.WinForms.UI.ColorPicker.ColorHexagon colorCustomHexagon;
        private MaterialSkin.Controls.MaterialCheckbox checkDefaultSettings;
    }
}