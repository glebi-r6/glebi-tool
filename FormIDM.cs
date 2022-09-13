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
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v5/IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip", "IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }

        }
    }
}
