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

namespace glebi_tool_2te_design_test.InfoCards
{
    public partial class FormForest : Form
    {
        WebClient wc = new WebClient();

        public FormForest()
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
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete10);
            Uri torrenturl = new Uri("https://download1527.mediafire.com/wrraftx97flg/xa9ghz0onk2fvg0/The.Forest.Build.4175072-OFME.torrent");
            wc.DownloadFileAsync(torrenturl, "The.Forest.Build.4175072-OFME.torrent");
        }

        private void FileDownloadComplete10(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete10);
        }
    }
}
