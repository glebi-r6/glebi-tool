using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;

namespace glebi_tool.InfoCards
{
    public partial class FormAssassinsIII : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

        int nLeftRect, // x-cordinate of upper-left corner
        int nTopRect, // y-cordinate of upper-left corner
        int nRightRect, // x-cordinate of Lower-right corner
        int nBottomRect, // y-cordinate of Lower-right corner
        int nWidthEllipse, // Width of Ellipse
        int nHeightEllipse // Height of Ellipse
        );

        WebClient wc = new WebClient();

        public FormAssassinsIII()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(-1, -1, Width, Height, 30, 30));
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
            timer2.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\Users\\" + Environment.UserName.ToString() + "\\Downloads\\Glebi-Tool\\Games\\Assassins Creed III Remastered");

            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Assassins Creed III Remastered\\Assassin039s_Creed_3_-_Remastered_FitGirl_Repack.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1040304839885852805/Assassin039s_Creed_3_-_Remastered_FitGirl_Repack.torrent", "Assassin039s_Creed_3_-_Remastered_FitGirl_Repack.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Assassin039s_Creed_3_-_Remastered_FitGirl_Repack.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Assassins Creed III Remastered", "Assassin039s_Creed_3_-_Remastered_FitGirl_Repack.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Assassins Creed III Remastered");
            }
        }

        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
    }
}
