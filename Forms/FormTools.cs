using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using AltoHttp;
using System.Threading;
using System.Runtime.InteropServices;
using Google.Apis.Auth;
using Google.Apis;

namespace glebi_tool.Forms
{
    public partial class FormTools : Form
    {
        private HttpDownloader hd = null;

        WebClient wc = new WebClient();

        public FormTools()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
        }

        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);

        //KMS
        private void btnKms_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\KMSpico.10.2.0.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v6/KMSpico.10.2.0.zip", "KMSpico.10.2.0.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "KMSpico.10.2.0.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "KMSpico.10.2.0.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
            }

        }

        //Office
        private void btnOffice_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\ProPlus2021Retail.img"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                MessageBox.Show("Application might freeze or Crash");

                progressBar1.Visible = true;
                lblPercent.Visible = true;
                lblSize.Visible = true;
                lblSpeed.Visible = true;

                Office.RunWorkerAsync();
            }
        }

        //Office BackgroundWorker
        private void Office_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://officecdn.microsoft.com/db/492350f6-3a01-4f97-b9c0-c7c6ddf67d60/media/en-us/ProPlus2021Retail.img";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted3;
            BlockInput(true);
            hd.Start();
        }

        //Spotify
        private void btnSpotify_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\Spotify_-_ADblocker.bat"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016408369185169488/1016626665025175552/Spotify_-_ADblocker.bat", "Spotify_-_ADblocker.bat");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Spotify_-_ADblocker.bat");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Spotify_-_ADblocker.bat");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
            }

        }

        //Wallpaper Egine
        private void btWallpaper_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\Wallpaper.Engine.v2.1.32.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                MessageBox.Show("Application might freeze or Crash");

                progressBar1.Visible = true;
                lblPercent.Visible = true;
                lblSize.Visible = true;
                lblSpeed.Visible = true;

                Wallpaper_Engine.RunWorkerAsync();
            }
        }

        //Wallpaper Enigne BackgroundWorker
        private void Wallpaper_Engine_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://github.com/davld122/Nothing-Special/releases/download/v4/Wallpaper.Engine.v2.1.32.zip";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted1;
            BlockInput(true);
            hd.Start();
        }

        //Premiere Pro
        private void btnPremiere_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\APPv22.1.2.1.rar"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                MessageBox.Show("Application might freeze or Crash");

                progressBar1.Visible = true;
                lblPercent.Visible = true;
                lblSize.Visible = true;
                lblSpeed.Visible = true;

                Premiere_Pro.RunWorkerAsync();
            }
        }

        //Premiere Pro BackgroundWorker
        private void Premiere_Pro_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://download848.mediafire.com/dnmavclkhcag/vqmi4o0p01adwyo/APPv22.1.2.1.rar";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted4;
            BlockInput(true);
            hd.Start();
        }

        //Photoshop
        private void btnPhotoshop_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\Adobe_Photoshop_2022_23.1.1.202.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                MessageBox.Show("Application might freeze or Crash");

                progressBar1.Visible = true;
                lblPercent.Visible = true;
                lblSize.Visible = true;
                lblSpeed.Visible = true;

                Photoshop.RunWorkerAsync();
            }
        }

        //Photoshop BackgroundWorker
        private void Photoshop_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://download1980.mediafire.com/0919ytbrcmkg/06d15nxafy3vloh/Adobe_Photoshop_2022_23.1.1.202.zip";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted5;
            BlockInput(true);
            hd.Start();
        }

        //Office InfoCard
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FromOffice();
            formPopup.Show(this);
        }

        //Interntet Download Manager 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                progressBar1.Visible = true;
                lblPercent.Visible = true;
                lblSize.Visible = true;
                lblSpeed.Visible = true;

                IDM.RunWorkerAsync();
            }
          
        }

        //Interntet Download Manager BackgroundWorker
        private void IDM_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://github.com/davld122/Nothing-Special/releases/download/v5/IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted2;
            BlockInput(true);
            hd.Start();
        }

        //IDM InfoCard
        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormIDM();
            formPopup.Show(this);
        }

        //KMS InfoCard
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormKMS();
            formPopup.Show(this);
        }

        //Stardock Fences 3
        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\Stardock_Fences_3.0.8.1x64.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v7/Stardock_Fences_3.0.8.1x64.zip", "Stardock_Fences_3.0.8.1x64.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Stardock_Fences_3.0.8.1x64.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Stardock_Fences_3.0.8.1x64.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
            }

        }

        //Fences InfoCard
        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormFences();
            formPopup.Show(this);
        }

        //Download Folder
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
        }

        //Progress Bar
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;

            lblPercent.Text = $"{e.Progress.ToString("0.00")} % ";

            lblSize.Text = string.Format("{0} MB", (hd.TotalBytesReceived / 1024d / 1024d).ToString("0.00"));
        }

        private void HttpDownloader_DownloadCompleted1(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblPercent.Text = "Finished";
                });

                MessageBox.Show("Download Completed");
            }
            finally
            {
                 // Get the full path of the download and the destination folder.
                 string fromPath = Path.Combine(Application.StartupPath, "Wallpaper.Engine.v2.1.32.zip");
                 string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Wallpaper.Engine.v2.1.32.zip");
                 
                 // Move the file.
                 File.Move(fromPath, toPath);
                 
                 try
                 {
                     Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
                 }
                 catch
                 {
                     Process.Start(Application.StartupPath + "Wallpaper.Engine.v2.1.32.zip");
                 }
                 
                 Application.UseWaitCursor = false;
                 BlockInput(false);
                 
                 Thread.Sleep(2500);
                 
                 progressBar1.Visible = false;
                 lblPercent.Visible = false;
                 lblSize.Visible = false;
                 lblSpeed.Visible = false;
            }
        }
        private void HttpDownloader_DownloadCompleted2(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblPercent.Text = "Finished";
                });

                MessageBox.Show("Download Completed");
            }
            finally
            {
                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "IDM.Crack.6.40.Build.11.Patch.+.Serial.Key.zip");
                }

                Application.UseWaitCursor = false;
                BlockInput(false);

                Thread.Sleep(2500);

                progressBar1.Visible = false;
                lblPercent.Visible = false;
                lblSize.Visible = false;
                lblSpeed.Visible = false;
            }
        }
        private void HttpDownloader_DownloadCompleted3(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblPercent.Text = "Finished";
                });

                MessageBox.Show("Download Completed");
            }
            finally
            {
                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "ProPlus2021Retail.img");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "ProPlus2021Retail.img");

                // Move the file.
                File.Move(fromPath, toPath);

                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "ProPlus2021Retail.img");
                }

                Application.UseWaitCursor = false;
                BlockInput(false);

                Thread.Sleep(2500);

                progressBar1.Visible = false;
                lblPercent.Visible = false;
                lblSize.Visible = false;
                lblSpeed.Visible = false;
            }
        }
        private void HttpDownloader_DownloadCompleted4(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblPercent.Text = "Finished";
                });

                MessageBox.Show("Download Completed");
            }
            finally
            {
                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "APPv22.1.2.1.rar");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "APPv22.1.2.1.rar");

                // Move the file.
                File.Move(fromPath, toPath);

                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "APPv22.1.2.1.rar");
                }

                Application.UseWaitCursor = false;
                BlockInput(false);

                Thread.Sleep(2500);

                progressBar1.Visible = false;
                lblPercent.Visible = false;
                lblSize.Visible = false;
                lblSpeed.Visible = false;
            }
        }
        private void HttpDownloader_DownloadCompleted5(object sender, EventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblPercent.Text = "Finished";
                });

                MessageBox.Show("Download Completed");
            }
            finally
            {
                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Adobe_Photoshop_2022_23.1.1.202.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Adobe_Photoshop_2022_23.1.1.202.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "Adobe_Photoshop_2022_23.1.1.202.zip");
                }

                Application.UseWaitCursor = false;
                BlockInput(false);

                Thread.Sleep(2500);

                progressBar1.Visible = false;
                lblPercent.Visible = false;
                lblSize.Visible = false;
                lblSpeed.Visible = false;
            }
        }

        //Download info
        private void iconPictureBox10_Click(object sender, EventArgs e)
        {

        }

        //Adobe Passwords
        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormToolsPw();
            formPopup.Show(this);
        }
        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormToolsPw();
            formPopup.Show(this);
        }
    }
}
