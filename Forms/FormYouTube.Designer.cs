
namespace glebi_tool.Forms
{
    partial class FormYouTube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYouTube));
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.webVideo = new System.Windows.Forms.WebBrowser();
            this.llblYouTube = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Red;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.Red;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.Location = new System.Drawing.Point(38, 366);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(119, 50);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(38, 2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(265, 20);
            this.txtLink.TabIndex = 1;
            this.txtLink.Text = "https://www.youtube.com/watch?v=aA_vxKHmPWM";
            this.txtLink.Visible = false;
            // 
            // webVideo
            // 
            this.webVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.webVideo.Location = new System.Drawing.Point(38, 28);
            this.webVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVideo.Name = "webVideo";
            this.webVideo.ScrollBarsEnabled = false;
            this.webVideo.Size = new System.Drawing.Size(615, 321);
            this.webVideo.TabIndex = 2;
            this.webVideo.Url = new System.Uri("https://wallpapercave.com/wp/d7W4Xn1.jpg", System.UriKind.Absolute);
            // 
            // llblYouTube
            // 
            this.llblYouTube.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblYouTube.AutoSize = true;
            this.llblYouTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblYouTube.LinkColor = System.Drawing.Color.Crimson;
            this.llblYouTube.Location = new System.Drawing.Point(531, 382);
            this.llblYouTube.Name = "llblYouTube";
            this.llblYouTube.Size = new System.Drawing.Size(90, 22);
            this.llblYouTube.TabIndex = 7;
            this.llblYouTube.TabStop = true;
            this.llblYouTube.Text = "Supscribe";
            this.llblYouTube.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblYouTube_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 382);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormYouTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llblYouTube);
            this.Controls.Add(this.webVideo);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnPlay);
            this.Name = "FormYouTube";
            this.Text = "YouTube";
            this.Load += new System.EventHandler(this.FormYouTube_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.WebBrowser webVideo;
        private System.Windows.Forms.LinkLabel llblYouTube;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}