﻿namespace ValorantAimbotUI
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002A9F File Offset: 0x00000C9F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002AC0 File Offset: 0x00000CC0
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AimbotBtt = new System.Windows.Forms.CheckBox();
            this.TriggerbotBtt = new System.Windows.Forms.CheckBox();
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FovXNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FovYNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.PurpleRadio = new System.Windows.Forms.RadioButton();
            this.ChangeMonitorBtt = new System.Windows.Forms.Button();
            this.AimKeyToggle = new System.Windows.Forms.CheckBox();
            this.IsHoldToggle = new System.Windows.Forms.CheckBox();
            this.AimkeyBtt = new System.Windows.Forms.Button();
            this.StartBtt = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.offsetNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FireRateNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Customcolor = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.Redinput = new System.Windows.Forms.NumericUpDown();
            this.Greeninput = new System.Windows.Forms.NumericUpDown();
            this.Blueinput = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PixelX = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PixelY = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.ScreenX2 = new System.Windows.Forms.NumericUpDown();
            this.ScreenY2 = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.ScreenY = new System.Windows.Forms.Label();
            this.CustomScreen = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RecoilBtt = new System.Windows.Forms.CheckBox();
            this.Bhopbox = new System.Windows.Forms.CheckBox();
            this.Bhopinput = new System.Windows.Forms.NumericUpDown();
            this.TriggerKeyBtt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Speed3 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.rcs = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.Delayx = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.SmoothY = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.SmoothX = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovXNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovYNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Redinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeninput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blueinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhopinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delayx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothX)).BeginInit();
            this.SuspendLayout();
            // 
            // AimbotBtt
            // 
            this.AimbotBtt.AutoSize = true;
            this.AimbotBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimbotBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimbotBtt.Location = new System.Drawing.Point(15, 31);
            this.AimbotBtt.Margin = new System.Windows.Forms.Padding(2);
            this.AimbotBtt.Name = "AimbotBtt";
            this.AimbotBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AimbotBtt.Size = new System.Drawing.Size(55, 17);
            this.AimbotBtt.TabIndex = 0;
            this.AimbotBtt.Text = "Aimbot";
            this.toolTip1.SetToolTip(this.AimbotBtt, "Enable or Disable the Aimbot\r\n\r\n- This feature aims automatically at your enemy");
            this.AimbotBtt.UseVisualStyleBackColor = true;
            this.AimbotBtt.CheckedChanged += new System.EventHandler(this.IsAimbot_changed);
            // 
            // TriggerbotBtt
            // 
            this.TriggerbotBtt.AutoSize = true;
            this.TriggerbotBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriggerbotBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TriggerbotBtt.Location = new System.Drawing.Point(15, 52);
            this.TriggerbotBtt.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerbotBtt.Name = "TriggerbotBtt";
            this.TriggerbotBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TriggerbotBtt.Size = new System.Drawing.Size(71, 17);
            this.TriggerbotBtt.TabIndex = 1;
            this.TriggerbotBtt.Text = "Triggerbot";
            this.toolTip1.SetToolTip(this.TriggerbotBtt, "Enable or Disable the Triggerbot\r\n\r\n- This feature will automatically shoot at yo" +
        "ur Enemy as soon as you aim at him.");
            this.TriggerbotBtt.UseVisualStyleBackColor = true;
            this.TriggerbotBtt.CheckedChanged += new System.EventHandler(this.IsTriggerbot_changed);
            // 
            // Speed
            // 
            this.Speed.DecimalPlaces = 2;
            this.Speed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Speed.Location = new System.Drawing.Point(15, 151);
            this.Speed.Margin = new System.Windows.Forms.Padding(2);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(90, 20);
            this.Speed.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Speed, "Change the Speed of your Aimbot.\r\n\r\nLower Values are more legit.");
            this.Speed.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            this.Speed.ValueChanged += new System.EventHandler(this.Speed_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(109, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "On Aim Smoothing";
            this.toolTip1.SetToolTip(this.label1, "Changes the Speed of your Aimbot while searching / aiming for your target.\r\n\r\nLow" +
        "er Values are more legit.");
            // 
            // FovXNum
            // 
            this.FovXNum.Location = new System.Drawing.Point(15, 175);
            this.FovXNum.Margin = new System.Windows.Forms.Padding(2);
            this.FovXNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FovXNum.Name = "FovXNum";
            this.FovXNum.Size = new System.Drawing.Size(90, 20);
            this.FovXNum.TabIndex = 5;
            this.toolTip1.SetToolTip(this.FovXNum, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            this.FovXNum.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.FovXNum.ValueChanged += new System.EventHandler(this.FovX_changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(109, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aimbot Fov left/right";
            this.toolTip1.SetToolTip(this.label2, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            // 
            // FovYNum
            // 
            this.FovYNum.Location = new System.Drawing.Point(15, 199);
            this.FovYNum.Margin = new System.Windows.Forms.Padding(2);
            this.FovYNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FovYNum.Name = "FovYNum";
            this.FovYNum.Size = new System.Drawing.Size(90, 20);
            this.FovYNum.TabIndex = 7;
            this.toolTip1.SetToolTip(this.FovYNum, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov.\r\n");
            this.FovYNum.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.FovYNum.ValueChanged += new System.EventHandler(this.FovY_changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(109, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aimbot Fov up/down";
            this.toolTip1.SetToolTip(this.label3, "Your Y Fov for Up and Down.\r\n\r\nHigher Value will increase the Fov.\r\n");
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RedRadio.Location = new System.Drawing.Point(15, 469);
            this.RedRadio.Margin = new System.Windows.Forms.Padding(0);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(44, 17);
            this.RedRadio.TabIndex = 9;
            this.RedRadio.TabStop = true;
            this.RedRadio.Text = "Red";
            this.toolTip1.SetToolTip(this.RedRadio, "Enemy outline Color. Switch to the Color which your enemy has.");
            this.RedRadio.UseVisualStyleBackColor = true;
            this.RedRadio.CheckedChanged += new System.EventHandler(this.Red_changed);
            // 
            // PurpleRadio
            // 
            this.PurpleRadio.AutoSize = true;
            this.PurpleRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurpleRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PurpleRadio.Location = new System.Drawing.Point(59, 469);
            this.PurpleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.PurpleRadio.Name = "PurpleRadio";
            this.PurpleRadio.Size = new System.Drawing.Size(54, 17);
            this.PurpleRadio.TabIndex = 10;
            this.PurpleRadio.TabStop = true;
            this.PurpleRadio.Text = "Purple";
            this.toolTip1.SetToolTip(this.PurpleRadio, "Enemy outline Color. Switch to the Color which your enemy has.");
            this.PurpleRadio.UseVisualStyleBackColor = true;
            this.PurpleRadio.CheckedChanged += new System.EventHandler(this.Purple_changed);
            // 
            // ChangeMonitorBtt
            // 
            this.ChangeMonitorBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ChangeMonitorBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeMonitorBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChangeMonitorBtt.Location = new System.Drawing.Point(15, 943);
            this.ChangeMonitorBtt.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeMonitorBtt.Name = "ChangeMonitorBtt";
            this.ChangeMonitorBtt.Size = new System.Drawing.Size(148, 25);
            this.ChangeMonitorBtt.TabIndex = 11;
            this.ChangeMonitorBtt.Text = "Change Screen";
            this.toolTip1.SetToolTip(this.ChangeMonitorBtt, "Change your Monitor");
            this.ChangeMonitorBtt.UseVisualStyleBackColor = false;
            this.ChangeMonitorBtt.Click += new System.EventHandler(this.MonitorChanged);
            // 
            // AimKeyToggle
            // 
            this.AimKeyToggle.AutoSize = true;
            this.AimKeyToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimKeyToggle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AimKeyToggle.Location = new System.Drawing.Point(15, 919);
            this.AimKeyToggle.Margin = new System.Windows.Forms.Padding(2);
            this.AimKeyToggle.Name = "AimKeyToggle";
            this.AimKeyToggle.Size = new System.Drawing.Size(58, 17);
            this.AimKeyToggle.TabIndex = 12;
            this.AimKeyToggle.Text = "AimKey";
            this.AimKeyToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.AimKeyToggle, "Enables the Aimkey Keybind");
            this.AimKeyToggle.UseVisualStyleBackColor = true;
            this.AimKeyToggle.CheckedChanged += new System.EventHandler(this.AimKeyToggle_CheckedChanged);
            this.AimKeyToggle.Click += new System.EventHandler(this.IsAimKeyChanged);
            // 
            // IsHoldToggle
            // 
            this.IsHoldToggle.AutoSize = true;
            this.IsHoldToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IsHoldToggle.ForeColor = System.Drawing.Color.Snow;
            this.IsHoldToggle.Location = new System.Drawing.Point(77, 919);
            this.IsHoldToggle.Margin = new System.Windows.Forms.Padding(2);
            this.IsHoldToggle.Name = "IsHoldToggle";
            this.IsHoldToggle.Size = new System.Drawing.Size(45, 17);
            this.IsHoldToggle.TabIndex = 13;
            this.IsHoldToggle.Text = "Hold";
            this.toolTip1.SetToolTip(this.IsHoldToggle, "Press and Hold the Aimkey for Triggerbot and Aimbot");
            this.IsHoldToggle.UseVisualStyleBackColor = true;
            this.IsHoldToggle.CheckedChanged += new System.EventHandler(this.IsHold_changed);
            // 
            // AimkeyBtt
            // 
            this.AimkeyBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AimkeyBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AimkeyBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AimkeyBtt.Location = new System.Drawing.Point(15, 812);
            this.AimkeyBtt.Margin = new System.Windows.Forms.Padding(2);
            this.AimkeyBtt.Name = "AimkeyBtt";
            this.AimkeyBtt.Size = new System.Drawing.Size(82, 25);
            this.AimkeyBtt.TabIndex = 14;
            this.AimkeyBtt.Text = "Keybind";
            this.toolTip1.SetToolTip(this.AimkeyBtt, "Keybinding for Triggerbot and Aimbot");
            this.AimkeyBtt.UseVisualStyleBackColor = false;
            this.AimkeyBtt.Click += new System.EventHandler(this.AimKeyDrop);
            // 
            // StartBtt
            // 
            this.StartBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StartBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartBtt.Location = new System.Drawing.Point(15, 972);
            this.StartBtt.Margin = new System.Windows.Forms.Padding(2);
            this.StartBtt.Name = "StartBtt";
            this.StartBtt.Size = new System.Drawing.Size(148, 25);
            this.StartBtt.TabIndex = 15;
            this.StartBtt.Text = "Start";
            this.StartBtt.UseVisualStyleBackColor = false;
            this.StartBtt.Click += new System.EventHandler(this.Start_click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // offsetNum
            // 
            this.offsetNum.Location = new System.Drawing.Point(15, 223);
            this.offsetNum.Margin = new System.Windows.Forms.Padding(2);
            this.offsetNum.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.offsetNum.Name = "offsetNum";
            this.offsetNum.Size = new System.Drawing.Size(90, 20);
            this.offsetNum.TabIndex = 16;
            this.toolTip1.SetToolTip(this.offsetNum, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value" +
        " (Aims higher at your Head)");
            this.offsetNum.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.offsetNum.ValueChanged += new System.EventHandler(this.OffsetY_changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(109, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Aimoffset";
            this.toolTip1.SetToolTip(this.label4, "Will change the Aimspot.\r\n\r\n- Lower Value (Aims lower at your Body)\r\n- High Value" +
        " (Aims higher at your Head)");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(109, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Firerate";
            this.toolTip1.SetToolTip(this.label5, "Firerate of your Weapon in Triggerbotmode");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FireRateNum
            // 
            this.FireRateNum.Location = new System.Drawing.Point(15, 248);
            this.FireRateNum.Margin = new System.Windows.Forms.Padding(2);
            this.FireRateNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FireRateNum.Name = "FireRateNum";
            this.FireRateNum.Size = new System.Drawing.Size(90, 20);
            this.FireRateNum.TabIndex = 18;
            this.toolTip1.SetToolTip(this.FireRateNum, "Firerate of your Weapon in Triggerbotmode");
            this.FireRateNum.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.FireRateNum.ValueChanged += new System.EventHandler(this.FireRate_changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Features:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Settings:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Outlines:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 792);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Keybinds Aimbot:";
            // 
            // Customcolor
            // 
            this.Customcolor.AutoSize = true;
            this.Customcolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customcolor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customcolor.Location = new System.Drawing.Point(117, 468);
            this.Customcolor.Margin = new System.Windows.Forms.Padding(0);
            this.Customcolor.Name = "Customcolor";
            this.Customcolor.Size = new System.Drawing.Size(60, 18);
            this.Customcolor.TabIndex = 25;
            this.Customcolor.TabStop = true;
            this.Customcolor.Text = "Custom";
            this.toolTip1.SetToolTip(this.Customcolor, "Custom RGB Color if it doesn\'t detect the predefined one.");
            this.Customcolor.UseCompatibleTextRendering = true;
            this.Customcolor.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(109, 496);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Red";
            this.toolTip1.SetToolTip(this.label11, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Redinput
            // 
            this.Redinput.Location = new System.Drawing.Point(15, 494);
            this.Redinput.Margin = new System.Windows.Forms.Padding(2);
            this.Redinput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Redinput.Name = "Redinput";
            this.Redinput.Size = new System.Drawing.Size(90, 20);
            this.Redinput.TabIndex = 28;
            this.toolTip1.SetToolTip(this.Redinput, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Greeninput
            // 
            this.Greeninput.Location = new System.Drawing.Point(15, 516);
            this.Greeninput.Margin = new System.Windows.Forms.Padding(2);
            this.Greeninput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Greeninput.Name = "Greeninput";
            this.Greeninput.Size = new System.Drawing.Size(90, 20);
            this.Greeninput.TabIndex = 29;
            this.toolTip1.SetToolTip(this.Greeninput, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // Blueinput
            // 
            this.Blueinput.Location = new System.Drawing.Point(15, 538);
            this.Blueinput.Margin = new System.Windows.Forms.Padding(2);
            this.Blueinput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blueinput.Name = "Blueinput";
            this.Blueinput.Size = new System.Drawing.Size(90, 20);
            this.Blueinput.TabIndex = 30;
            this.toolTip1.SetToolTip(this.Blueinput, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(109, 518);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Green";
            this.toolTip1.SetToolTip(this.label12, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(109, 540);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Blue";
            this.toolTip1.SetToolTip(this.label13, "Custom RGB Color if it doesn\'t detect the predefined one.");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(12, 579);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Triggerbot Prefire:";
            // 
            // PixelX
            // 
            this.PixelX.Location = new System.Drawing.Point(15, 620);
            this.PixelX.Margin = new System.Windows.Forms.Padding(2);
            this.PixelX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PixelX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelX.Name = "PixelX";
            this.PixelX.Size = new System.Drawing.Size(90, 20);
            this.PixelX.TabIndex = 34;
            this.PixelX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PixelX.ValueChanged += new System.EventHandler(this.PixelX_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(109, 622);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Pixel X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(109, 646);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Pixel Y";
            // 
            // PixelY
            // 
            this.PixelY.Location = new System.Drawing.Point(15, 644);
            this.PixelY.Margin = new System.Windows.Forms.Padding(2);
            this.PixelY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PixelY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelY.Name = "PixelY";
            this.PixelY.Size = new System.Drawing.Size(90, 20);
            this.PixelY.TabIndex = 36;
            this.PixelY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PixelY.ValueChanged += new System.EventHandler(this.PixelY_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(12, 685);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 18);
            this.label17.TabIndex = 38;
            this.label17.Text = "Custom Screenresolution:";
            // 
            // ScreenX2
            // 
            this.ScreenX2.Location = new System.Drawing.Point(15, 726);
            this.ScreenX2.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenX2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScreenX2.Name = "ScreenX2";
            this.ScreenX2.Size = new System.Drawing.Size(90, 20);
            this.ScreenX2.TabIndex = 39;
            this.ScreenX2.Tag = "";
            this.toolTip1.SetToolTip(this.ScreenX2, "Screen Resoltuion X");
            this.ScreenX2.ValueChanged += new System.EventHandler(this.ScreenX2_ValueChanged);
            // 
            // ScreenY2
            // 
            this.ScreenY2.Location = new System.Drawing.Point(15, 750);
            this.ScreenY2.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenY2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ScreenY2.Name = "ScreenY2";
            this.ScreenY2.Size = new System.Drawing.Size(90, 20);
            this.ScreenY2.TabIndex = 40;
            this.toolTip1.SetToolTip(this.ScreenY2, "Screen Resoltuion Y");
            this.ScreenY2.ValueChanged += new System.EventHandler(this.ScreenY2_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(114, 728);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "Pixel X";
            // 
            // ScreenY
            // 
            this.ScreenY.AutoSize = true;
            this.ScreenY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScreenY.Location = new System.Drawing.Point(114, 752);
            this.ScreenY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScreenY.Name = "ScreenY";
            this.ScreenY.Size = new System.Drawing.Size(39, 13);
            this.ScreenY.TabIndex = 42;
            this.ScreenY.Text = "Pixel Y";
            // 
            // CustomScreen
            // 
            this.CustomScreen.AutoSize = true;
            this.CustomScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomScreen.Location = new System.Drawing.Point(15, 705);
            this.CustomScreen.Margin = new System.Windows.Forms.Padding(2);
            this.CustomScreen.Name = "CustomScreen";
            this.CustomScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CustomScreen.Size = new System.Drawing.Size(111, 17);
            this.CustomScreen.TabIndex = 44;
            this.CustomScreen.Text = "Custom Resolution";
            this.toolTip1.SetToolTip(this.CustomScreen, "You don\'t need this. Only if it doesn\'t detect your Screen Resolution.");
            this.CustomScreen.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(15, 599);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Prefire";
            this.toolTip1.SetToolTip(this.checkBox1, "Enable / Disable Prefire.\r\n\r\nWill shoot X Pixels before it reaches the Target.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // RecoilBtt
            // 
            this.RecoilBtt.AutoSize = true;
            this.RecoilBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecoilBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RecoilBtt.Location = new System.Drawing.Point(15, 73);
            this.RecoilBtt.Margin = new System.Windows.Forms.Padding(2);
            this.RecoilBtt.Name = "RecoilBtt";
            this.RecoilBtt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecoilBtt.Size = new System.Drawing.Size(67, 17);
            this.RecoilBtt.TabIndex = 47;
            this.RecoilBtt.Text = "NoRecoil";
            this.toolTip1.SetToolTip(this.RecoilBtt, "Enable or Disable NoRecoil\r\n\r\n- This feature will countermeasures against the rec" +
        "oil");
            this.RecoilBtt.UseVisualStyleBackColor = true;
            this.RecoilBtt.CheckedChanged += new System.EventHandler(this.Recoilcheckbox_CheckedChanged_1);
            // 
            // Bhopbox
            // 
            this.Bhopbox.AllowDrop = true;
            this.Bhopbox.AutoSize = true;
            this.Bhopbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bhopbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bhopbox.Location = new System.Drawing.Point(15, 94);
            this.Bhopbox.Margin = new System.Windows.Forms.Padding(2);
            this.Bhopbox.Name = "Bhopbox";
            this.Bhopbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bhopbox.Size = new System.Drawing.Size(48, 17);
            this.Bhopbox.TabIndex = 48;
            this.Bhopbox.Text = "Bhop";
            this.toolTip1.SetToolTip(this.Bhopbox, "Enable or Disable the Triggerbot\r\n\r\n- This feature will let you jump to infinity");
            this.Bhopbox.UseMnemonic = false;
            this.Bhopbox.UseVisualStyleBackColor = true;
            this.Bhopbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Bhopinput
            // 
            this.Bhopinput.Location = new System.Drawing.Point(98, 94);
            this.Bhopinput.Margin = new System.Windows.Forms.Padding(2);
            this.Bhopinput.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.Bhopinput.Name = "Bhopinput";
            this.Bhopinput.Size = new System.Drawing.Size(53, 20);
            this.Bhopinput.TabIndex = 49;
            this.toolTip1.SetToolTip(this.Bhopinput, "Keybind for Bhop.\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree" +
        ".at/misc/vk.htm");
            this.Bhopinput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Bhopinput.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // TriggerKeyBtt
            // 
            this.TriggerKeyBtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TriggerKeyBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriggerKeyBtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TriggerKeyBtt.Location = new System.Drawing.Point(15, 875);
            this.TriggerKeyBtt.Margin = new System.Windows.Forms.Padding(2);
            this.TriggerKeyBtt.Name = "TriggerKeyBtt";
            this.TriggerKeyBtt.Size = new System.Drawing.Size(82, 25);
            this.TriggerKeyBtt.TabIndex = 52;
            this.TriggerKeyBtt.Text = "Keybind";
            this.toolTip1.SetToolTip(this.TriggerKeyBtt, "Keybinding for Triggerbot and Aimbot");
            this.TriggerKeyBtt.UseVisualStyleBackColor = false;
            this.TriggerKeyBtt.Click += new System.EventHandler(this.TriggerKeyDrop);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(95, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Bhop Keycode:";
            this.toolTip1.SetToolTip(this.label10, "Keybind for Bhop.\r\n\r\n(Spacebar does not work)\r\n\r\nKeybinds here: http://cherrytree" +
        ".at/misc/vk.htm");
            // 
            // Speed3
            // 
            this.Speed3.DecimalPlaces = 2;
            this.Speed3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Speed3.Location = new System.Drawing.Point(15, 332);
            this.Speed3.Margin = new System.Windows.Forms.Padding(2);
            this.Speed3.Name = "Speed3";
            this.Speed3.Size = new System.Drawing.Size(90, 20);
            this.Speed3.TabIndex = 55;
            this.toolTip1.SetToolTip(this.Speed3, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crossha" +
        "ir or the Smooth Aim Pixels.\r\n\r\nLower Values are more legit.\r\n");
            this.Speed3.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Speed3.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(109, 334);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "On Enemy Smoothing";
            this.toolTip1.SetToolTip(this.label20, "Changes the Speed of your Aimbot as soon as you reach your Enemy with the Crossha" +
        "ir or the Smooth Aim Pixels.\r\nThis is like a second Fov on Lockon.\r\n\r\nLower Valu" +
        "es are more legit.");
            // 
            // rcs
            // 
            this.rcs.Location = new System.Drawing.Point(15, 272);
            this.rcs.Margin = new System.Windows.Forms.Padding(2);
            this.rcs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rcs.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.rcs.Name = "rcs";
            this.rcs.Size = new System.Drawing.Size(90, 20);
            this.rcs.TabIndex = 57;
            this.toolTip1.SetToolTip(this.rcs, "change the strength of the norecoil.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(109, 274);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 58;
            this.label21.Text = "RCS Amount";
            this.toolTip1.SetToolTip(this.label21, "Firerate of your Weapon in Triggerbotmode");
            // 
            // Delayx
            // 
            this.Delayx.Location = new System.Drawing.Point(15, 356);
            this.Delayx.Margin = new System.Windows.Forms.Padding(2);
            this.Delayx.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Delayx.Name = "Delayx";
            this.Delayx.Size = new System.Drawing.Size(90, 20);
            this.Delayx.TabIndex = 59;
            this.toolTip1.SetToolTip(this.Delayx, "Your X Fov for Left and Right.\r\n\r\nHigher Value will increase the Fov.");
            this.Delayx.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Delayx.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_2);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(109, 358);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "On Enemy Delay";
            this.toolTip1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(109, 406);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 13);
            this.label24.TabIndex = 65;
            this.label24.Text = "Smooth Aim Pixel Y";
            this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // SmoothY
            // 
            this.SmoothY.Location = new System.Drawing.Point(15, 404);
            this.SmoothY.Margin = new System.Windows.Forms.Padding(2);
            this.SmoothY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SmoothY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SmoothY.Name = "SmoothY";
            this.SmoothY.Size = new System.Drawing.Size(90, 20);
            this.SmoothY.TabIndex = 64;
            this.toolTip1.SetToolTip(this.SmoothY, "Pixels Y around your Enemy");
            this.SmoothY.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(109, 382);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Smooth Aim Pixel X";
            this.toolTip1.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
            // 
            // SmoothX
            // 
            this.SmoothX.Location = new System.Drawing.Point(15, 380);
            this.SmoothX.Margin = new System.Windows.Forms.Padding(2);
            this.SmoothX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.SmoothX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SmoothX.Name = "SmoothX";
            this.SmoothX.Size = new System.Drawing.Size(90, 20);
            this.SmoothX.TabIndex = 62;
            this.toolTip1.SetToolTip(this.SmoothX, "Pixels X around your Enemy");
            this.SmoothX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(12, 855);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(157, 18);
            this.label19.TabIndex = 53;
            this.label19.Text = "Keybinds Triggerbot:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(12, 312);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 18);
            this.label23.TabIndex = 61;
            this.label23.Text = "Smooth Aimbot:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(379, 147);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(272, 115);
            this.lblWelcome.TabIndex = 66;
            this.lblWelcome.Text = "⚫ Cheat is not FINISHED yet!\r\n\r\n⚫ except bugs\r\n\r\n⚫ use it at your OWN RISK\r\n";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(892, 1004);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.SmoothY);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.SmoothX);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Delayx);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.rcs);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Speed3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TriggerKeyBtt);
            this.Controls.Add(this.Bhopinput);
            this.Controls.Add(this.Bhopbox);
            this.Controls.Add(this.RecoilBtt);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CustomScreen);
            this.Controls.Add(this.ScreenY);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ScreenY2);
            this.Controls.Add(this.ScreenX2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PixelY);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PixelX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Blueinput);
            this.Controls.Add(this.Greeninput);
            this.Controls.Add(this.Redinput);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Customcolor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FireRateNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.offsetNum);
            this.Controls.Add(this.StartBtt);
            this.Controls.Add(this.AimkeyBtt);
            this.Controls.Add(this.IsHoldToggle);
            this.Controls.Add(this.AimKeyToggle);
            this.Controls.Add(this.ChangeMonitorBtt);
            this.Controls.Add(this.PurpleRadio);
            this.Controls.Add(this.RedRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FovYNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FovXNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.TriggerbotBtt);
            this.Controls.Add(this.AimbotBtt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pixel Aimbot";
            this.Load += new System.EventHandler(this.Main_load);
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovXNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovYNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Redinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greeninput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blueinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhopinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delayx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.CheckBox AimbotBtt;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.CheckBox TriggerbotBtt;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.NumericUpDown Speed;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.NumericUpDown FovXNum;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.NumericUpDown FovYNum;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.RadioButton RedRadio;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.RadioButton PurpleRadio;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button ChangeMonitorBtt;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.CheckBox AimKeyToggle;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.CheckBox IsHoldToggle;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Button AimkeyBtt;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button StartBtt;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.NumericUpDown offsetNum;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.NumericUpDown FireRateNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton Customcolor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Redinput;
        private System.Windows.Forms.NumericUpDown Greeninput;
        private System.Windows.Forms.NumericUpDown Blueinput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown PixelX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown PixelY;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown ScreenX2;
        private System.Windows.Forms.NumericUpDown ScreenY2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label ScreenY;
        private System.Windows.Forms.CheckBox CustomScreen;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox RecoilBtt;
        private System.Windows.Forms.CheckBox Bhopbox;
        private System.Windows.Forms.NumericUpDown Bhopinput;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button TriggerKeyBtt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Speed3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown rcs;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown Delayx;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown SmoothY;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown SmoothX;
        private System.Windows.Forms.Label lblWelcome;
    }
}
