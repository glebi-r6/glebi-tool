
namespace Recoil
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.weapon_combo_box = new System.Windows.Forms.ComboBox();
            this.status_box = new System.Windows.Forms.GroupBox();
            this.humanization_checkbox = new System.Windows.Forms.CheckBox();
            this.enabled_checkbox = new System.Windows.Forms.CheckBox();
            this.weapon_box = new System.Windows.Forms.GroupBox();
            this.attachment_box = new System.Windows.Forms.GroupBox();
            this.barrel_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sight_combo_box = new System.Windows.Forms.ComboBox();
            this.barrel_combo_box = new System.Windows.Forms.ComboBox();
            this.humanization_box = new System.Windows.Forms.GroupBox();
            this.fov_numbox = new System.Windows.Forms.NumericUpDown();
            this.sens_numbox = new System.Windows.Forms.NumericUpDown();
            this.sens_label = new System.Windows.Forms.Label();
            this.fov_label = new System.Windows.Forms.Label();
            this.settings_box = new System.Windows.Forms.GroupBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnCloseRust = new System.Windows.Forms.PictureBox();
            this.status_box.SuspendLayout();
            this.weapon_box.SuspendLayout();
            this.attachment_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fov_numbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sens_numbox)).BeginInit();
            this.settings_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseRust)).BeginInit();
            this.SuspendLayout();
            // 
            // weapon_combo_box
            // 
            this.weapon_combo_box.FormattingEnabled = true;
            this.weapon_combo_box.Items.AddRange(new object[] {
            "Assault Rifle",
            "MP5",
            "LR-300"});
            this.weapon_combo_box.Location = new System.Drawing.Point(6, 19);
            this.weapon_combo_box.Name = "weapon_combo_box";
            this.weapon_combo_box.Size = new System.Drawing.Size(145, 21);
            this.weapon_combo_box.TabIndex = 0;
            this.weapon_combo_box.SelectedIndexChanged += new System.EventHandler(this.weapon_combo_box_SelectedIndexChanged);
            // 
            // status_box
            // 
            this.status_box.Controls.Add(this.humanization_checkbox);
            this.status_box.Controls.Add(this.enabled_checkbox);
            this.status_box.ForeColor = System.Drawing.Color.Red;
            this.status_box.Location = new System.Drawing.Point(12, 30);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(101, 66);
            this.status_box.TabIndex = 1;
            this.status_box.TabStop = false;
            this.status_box.Text = "Status";
            // 
            // humanization_checkbox
            // 
            this.humanization_checkbox.AutoSize = true;
            this.humanization_checkbox.Location = new System.Drawing.Point(6, 42);
            this.humanization_checkbox.Name = "humanization_checkbox";
            this.humanization_checkbox.Size = new System.Drawing.Size(90, 17);
            this.humanization_checkbox.TabIndex = 4;
            this.humanization_checkbox.Text = "Humanization";
            this.humanization_checkbox.UseVisualStyleBackColor = true;
            this.humanization_checkbox.CheckedChanged += new System.EventHandler(this.humanization_checkbox_CheckedChanged);
            // 
            // enabled_checkbox
            // 
            this.enabled_checkbox.AutoSize = true;
            this.enabled_checkbox.Location = new System.Drawing.Point(6, 19);
            this.enabled_checkbox.Name = "enabled_checkbox";
            this.enabled_checkbox.Size = new System.Drawing.Size(65, 17);
            this.enabled_checkbox.TabIndex = 3;
            this.enabled_checkbox.Text = "Enabled";
            this.enabled_checkbox.UseVisualStyleBackColor = true;
            this.enabled_checkbox.CheckedChanged += new System.EventHandler(this.enabled_checkbox_CheckedChanged);
            // 
            // weapon_box
            // 
            this.weapon_box.Controls.Add(this.weapon_combo_box);
            this.weapon_box.ForeColor = System.Drawing.Color.Red;
            this.weapon_box.Location = new System.Drawing.Point(119, 30);
            this.weapon_box.Name = "weapon_box";
            this.weapon_box.Size = new System.Drawing.Size(157, 49);
            this.weapon_box.TabIndex = 2;
            this.weapon_box.TabStop = false;
            this.weapon_box.Text = "Weapon";
            // 
            // attachment_box
            // 
            this.attachment_box.Controls.Add(this.barrel_label);
            this.attachment_box.Controls.Add(this.label1);
            this.attachment_box.Controls.Add(this.sight_combo_box);
            this.attachment_box.Controls.Add(this.barrel_combo_box);
            this.attachment_box.ForeColor = System.Drawing.Color.Red;
            this.attachment_box.Location = new System.Drawing.Point(119, 85);
            this.attachment_box.Name = "attachment_box";
            this.attachment_box.Size = new System.Drawing.Size(157, 116);
            this.attachment_box.TabIndex = 3;
            this.attachment_box.TabStop = false;
            this.attachment_box.Text = "Attachments";
            // 
            // barrel_label
            // 
            this.barrel_label.AutoSize = true;
            this.barrel_label.ForeColor = System.Drawing.Color.Red;
            this.barrel_label.Location = new System.Drawing.Point(6, 17);
            this.barrel_label.Name = "barrel_label";
            this.barrel_label.Size = new System.Drawing.Size(34, 13);
            this.barrel_label.TabIndex = 8;
            this.barrel_label.Text = "Barrel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sight";
            // 
            // sight_combo_box
            // 
            this.sight_combo_box.FormattingEnabled = true;
            this.sight_combo_box.Items.AddRange(new object[] {
            "Holograph Sight",
            "Simple Sight",
            "8x Scope",
            "16x Scope",
            "None"});
            this.sight_combo_box.Location = new System.Drawing.Point(6, 78);
            this.sight_combo_box.Name = "sight_combo_box";
            this.sight_combo_box.Size = new System.Drawing.Size(145, 21);
            this.sight_combo_box.TabIndex = 1;
            this.sight_combo_box.SelectedIndexChanged += new System.EventHandler(this.sight_combo_box_SelectedIndexChanged);
            // 
            // barrel_combo_box
            // 
            this.barrel_combo_box.FormattingEnabled = true;
            this.barrel_combo_box.Items.AddRange(new object[] {
            "Silencer",
            "Muzzle Break",
            "Muzzle Boost",
            "None"});
            this.barrel_combo_box.Location = new System.Drawing.Point(6, 33);
            this.barrel_combo_box.Name = "barrel_combo_box";
            this.barrel_combo_box.Size = new System.Drawing.Size(145, 21);
            this.barrel_combo_box.TabIndex = 0;
            this.barrel_combo_box.SelectedIndexChanged += new System.EventHandler(this.barrel_combo_box_SelectedIndexChanged);
            // 
            // humanization_box
            // 
            this.humanization_box.ForeColor = System.Drawing.Color.Red;
            this.humanization_box.Location = new System.Drawing.Point(12, 207);
            this.humanization_box.Name = "humanization_box";
            this.humanization_box.Size = new System.Drawing.Size(264, 125);
            this.humanization_box.TabIndex = 4;
            this.humanization_box.TabStop = false;
            this.humanization_box.Text = "Humanization";
            // 
            // fov_numbox
            // 
            this.fov_numbox.DecimalPlaces = 2;
            this.fov_numbox.Location = new System.Drawing.Point(6, 71);
            this.fov_numbox.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            65536});
            this.fov_numbox.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            65536});
            this.fov_numbox.Name = "fov_numbox";
            this.fov_numbox.Size = new System.Drawing.Size(89, 20);
            this.fov_numbox.TabIndex = 2;
            this.fov_numbox.Value = new decimal(new int[] {
            900,
            0,
            0,
            65536});
            this.fov_numbox.ValueChanged += new System.EventHandler(this.fov_numbox_ValueChanged);
            // 
            // sens_numbox
            // 
            this.sens_numbox.DecimalPlaces = 2;
            this.sens_numbox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.sens_numbox.Location = new System.Drawing.Point(6, 32);
            this.sens_numbox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.sens_numbox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.sens_numbox.Name = "sens_numbox";
            this.sens_numbox.Size = new System.Drawing.Size(89, 20);
            this.sens_numbox.TabIndex = 5;
            this.sens_numbox.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.sens_numbox.ValueChanged += new System.EventHandler(this.sens_numbox_ValueChanged);
            // 
            // sens_label
            // 
            this.sens_label.AutoSize = true;
            this.sens_label.ForeColor = System.Drawing.Color.Red;
            this.sens_label.Location = new System.Drawing.Point(6, 16);
            this.sens_label.Name = "sens_label";
            this.sens_label.Size = new System.Drawing.Size(54, 13);
            this.sens_label.TabIndex = 0;
            this.sens_label.Text = "Sensitivity";
            // 
            // fov_label
            // 
            this.fov_label.AutoSize = true;
            this.fov_label.ForeColor = System.Drawing.Color.Red;
            this.fov_label.Location = new System.Drawing.Point(6, 55);
            this.fov_label.Name = "fov_label";
            this.fov_label.Size = new System.Drawing.Size(67, 13);
            this.fov_label.TabIndex = 6;
            this.fov_label.Text = "Field of View";
            // 
            // settings_box
            // 
            this.settings_box.Controls.Add(this.fov_numbox);
            this.settings_box.Controls.Add(this.fov_label);
            this.settings_box.Controls.Add(this.sens_numbox);
            this.settings_box.Controls.Add(this.sens_label);
            this.settings_box.ForeColor = System.Drawing.Color.Red;
            this.settings_box.Location = new System.Drawing.Point(12, 102);
            this.settings_box.Name = "settings_box";
            this.settings_box.Size = new System.Drawing.Size(101, 99);
            this.settings_box.TabIndex = 7;
            this.settings_box.TabStop = false;
            this.settings_box.Text = "Settings";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(225, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 23);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseRust
            // 
            this.btnCloseRust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseRust.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseRust.Image")));
            this.btnCloseRust.Location = new System.Drawing.Point(252, 6);
            this.btnCloseRust.Name = "btnCloseRust";
            this.btnCloseRust.Size = new System.Drawing.Size(18, 20);
            this.btnCloseRust.TabIndex = 11;
            this.btnCloseRust.TabStop = false;
            this.btnCloseRust.Click += new System.EventHandler(this.btnCloseRust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(288, 341);
            this.Controls.Add(this.btnCloseRust);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.settings_box);
            this.Controls.Add(this.humanization_box);
            this.Controls.Add(this.attachment_box);
            this.Controls.Add(this.weapon_box);
            this.Controls.Add(this.status_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(304, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 380);
            this.Name = "Form1";
            this.Text = "Rust No Recoil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.status_box.ResumeLayout(false);
            this.status_box.PerformLayout();
            this.weapon_box.ResumeLayout(false);
            this.attachment_box.ResumeLayout(false);
            this.attachment_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fov_numbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sens_numbox)).EndInit();
            this.settings_box.ResumeLayout(false);
            this.settings_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseRust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox weapon_combo_box;
        private System.Windows.Forms.GroupBox status_box;
        private System.Windows.Forms.CheckBox enabled_checkbox;
        private System.Windows.Forms.GroupBox weapon_box;
        private System.Windows.Forms.CheckBox humanization_checkbox;
        private System.Windows.Forms.GroupBox attachment_box;
        private System.Windows.Forms.ComboBox sight_combo_box;
        private System.Windows.Forms.ComboBox barrel_combo_box;
        private System.Windows.Forms.GroupBox humanization_box;
        private System.Windows.Forms.Label sens_label;
        private System.Windows.Forms.NumericUpDown sens_numbox;
        private System.Windows.Forms.NumericUpDown fov_numbox;
        private System.Windows.Forms.Label fov_label;
        private System.Windows.Forms.GroupBox settings_box;
        private System.Windows.Forms.Label barrel_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnCloseRust;
    }
}

