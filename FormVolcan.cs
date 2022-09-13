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
using System.IO;

namespace glebi_tool_2te_design_test.InfoCards
{
    public partial class FormVolcan : Form
    {
        WebClient wc = new WebClient();

        public FormVolcan()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Volcanoids.v1.27.271.0-OFME.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                using (var wc = new WebClient())
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016415539192680488/Volcanoids.v1.27.271.0-OFME.torrent", "Volcanoids.v1.27.271.0-OFME.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Volcanoids.v1.27.271.0-OFME.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Volcanoids.v1.27.271.0-OFME.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete);
        }
    }
}
