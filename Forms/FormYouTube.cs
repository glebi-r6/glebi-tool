using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace glebi_tool_2te_design.Forms
{
    public partial class FormYouTube : Form
    {
        public FormYouTube()
        {
            InitializeComponent();
        }


        private void FormYouTube_Load(object sender, EventArgs e)
        {
            this.webVideo.Document.BackColor = Color.Black;
            this.webVideo.Document.ForeColor = Color.Red;
            this.Size = new Size(800, 800);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}'' width='600' height='300' frameborder='0' allowfullscreen></iframe>";
            html += "</head></html>";
            this.webVideo.DocumentText = string.Format(html, txtLink.Text.Split('=')[1]);

        }

        private void llblYouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCGRa1XWKhKhBtxx_64n0Y8A");
        }
    }
}
