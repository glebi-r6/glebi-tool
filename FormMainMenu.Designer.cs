
namespace glebi_tool_2te_design
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTroll = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnWebsite = new FontAwesome.Sharp.IconButton();
            this.btnDiscrod = new FontAwesome.Sharp.IconButton();
            this.btnYouTube = new FontAwesome.Sharp.IconButton();
            this.btnTools = new FontAwesome.Sharp.IconButton();
            this.btnCrackedGames = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnWebsite);
            this.panelMenu.Controls.Add(this.btnDiscrod);
            this.panelMenu.Controls.Add(this.btnYouTube);
            this.panelMenu.Controls.Add(this.btnTools);
            this.panelMenu.Controls.Add(this.btnCrackedGames);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(855, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(48, 22);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(65, 28);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(855, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Controls.Add(this.lblDate);
            this.panelDesktop.Controls.Add(this.btnTroll);
            this.panelDesktop.Controls.Add(this.lblClock);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.linkLabel1);
            this.panelDesktop.Controls.Add(this.lblWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(855, 497);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(23, 265);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(76, 36);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClock.Location = new System.Drawing.Point(22, 214);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(149, 39);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(203, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "to report bugs, write sugessstions and for updates";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Join";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(67, 116);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 22);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Discord server";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(25, 47);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(553, 69);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hey and welcome to my tool\r\nPlease note that this client is in an early stage of " +
    "development\r\nCoding done in Visual Studio using C#";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTroll
            // 
            this.btnTroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroll.FlatAppearance.BorderSize = 0;
            this.btnTroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnTroll.IconChar = FontAwesome.Sharp.IconChar.Blind;
            this.btnTroll.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnTroll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroll.IconSize = 20;
            this.btnTroll.Location = new System.Drawing.Point(793, 463);
            this.btnTroll.Name = "btnTroll";
            this.btnTroll.Size = new System.Drawing.Size(62, 34);
            this.btnTroll.TabIndex = 5;
            this.btnTroll.Text = "Dont Click";
            this.btnTroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTroll.UseVisualStyleBackColor = true;
            this.btnTroll.Click += new System.EventHandler(this.btnTroll_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(801, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 23);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(828, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 33);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 27;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(27, 28);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 440);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnWebsite
            // 
            this.btnWebsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWebsite.FlatAppearance.BorderSize = 0;
            this.btnWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebsite.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWebsite.IconChar = FontAwesome.Sharp.IconChar.Opera;
            this.btnWebsite.IconColor = System.Drawing.Color.Gainsboro;
            this.btnWebsite.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsite.Location = new System.Drawing.Point(0, 380);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnWebsite.Size = new System.Drawing.Size(220, 60);
            this.btnWebsite.TabIndex = 5;
            this.btnWebsite.Text = "Website";
            this.btnWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebsite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // btnDiscrod
            // 
            this.btnDiscrod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscrod.FlatAppearance.BorderSize = 0;
            this.btnDiscrod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscrod.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiscrod.IconChar = FontAwesome.Sharp.IconChar.Crosshairs;
            this.btnDiscrod.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDiscrod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscrod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscrod.Location = new System.Drawing.Point(0, 320);
            this.btnDiscrod.Name = "btnDiscrod";
            this.btnDiscrod.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnDiscrod.Size = new System.Drawing.Size(220, 60);
            this.btnDiscrod.TabIndex = 4;
            this.btnDiscrod.Text = "Pixel Aimbot";
            this.btnDiscrod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscrod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscrod.UseVisualStyleBackColor = true;
            this.btnDiscrod.Click += new System.EventHandler(this.btnDiscrod_Click);
            // 
            // btnYouTube
            // 
            this.btnYouTube.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYouTube.FlatAppearance.BorderSize = 0;
            this.btnYouTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTube.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnYouTube.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.btnYouTube.IconColor = System.Drawing.Color.Gainsboro;
            this.btnYouTube.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYouTube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYouTube.Location = new System.Drawing.Point(0, 260);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnYouTube.Size = new System.Drawing.Size(220, 60);
            this.btnYouTube.TabIndex = 3;
            this.btnYouTube.Text = "YouTube";
            this.btnYouTube.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYouTube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYouTube.UseVisualStyleBackColor = true;
            this.btnYouTube.Click += new System.EventHandler(this.btnYouTube_Click);
            // 
            // btnTools
            // 
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTools.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnTools.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 200);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnTools.Size = new System.Drawing.Size(220, 60);
            this.btnTools.TabIndex = 2;
            this.btnTools.Text = "Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnCrackedGames
            // 
            this.btnCrackedGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrackedGames.FlatAppearance.BorderSize = 0;
            this.btnCrackedGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrackedGames.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrackedGames.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnCrackedGames.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCrackedGames.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrackedGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrackedGames.Location = new System.Drawing.Point(0, 140);
            this.btnCrackedGames.Name = "btnCrackedGames";
            this.btnCrackedGames.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.btnCrackedGames.Size = new System.Drawing.Size(220, 60);
            this.btnCrackedGames.TabIndex = 1;
            this.btnCrackedGames.Text = "Cracked Games";
            this.btnCrackedGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrackedGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrackedGames.UseVisualStyleBackColor = true;
            this.btnCrackedGames.Click += new System.EventHandler(this.btnCrackedGames_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, -9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 149);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 581);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1091, 620);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnWebsite;
        private FontAwesome.Sharp.IconButton btnYouTube;
        private FontAwesome.Sharp.IconButton btnTools;
        private FontAwesome.Sharp.IconButton btnCrackedGames;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnMaximize;
        private FontAwesome.Sharp.IconButton btnDiscrod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnTroll;
        private System.Windows.Forms.Label lblDate;
    }
}