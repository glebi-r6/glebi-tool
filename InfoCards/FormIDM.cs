using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace glebi_tool_2_0.InfoCards
{
    public partial class FormIDM : Form
    {
        WebClient wc = new WebClient();

        public FormIDM()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            Uri txturl = new Uri("https://download1483.mediafire.com/6bnkbyj379gg/mnhsbebixa16g7w/IDM+Crack+6.40+Build+11+Patch+%2B+Serial+Key+%5BLatest%5D.zip");
            wc.DownloadFileAsync(txturl, "IDM Crack 6.40 Build 11 Patch + Serial Key [Latest].rar");
        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete);
        }
    }
}
