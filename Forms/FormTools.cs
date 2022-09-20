using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace glebi_tool.Forms
{
    public partial class FormTools : Form
    {
        WebClient wc = new WebClient();
        public FormTools()
        {
            InitializeComponent();
        }

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
                MessageBox.Show("This could take a while now (4 GB)");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://officecdn.microsoft.com/db/492350f6-3a01-4f97-b9c0-c7c6ddf67d60/media/en-us/ProPlus2021Retail.img", "ProPlus2021Retail.img");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "ProPlus2021Retail.img");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "ProPlus2021Retail.img");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
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
                MessageBox.Show("This could take a while now");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v4/Wallpaper.Engine.v2.1.32.zip", "Wallpaper.Engine.v2.1.32.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Wallpaper.Engine.v2.1.32.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Wallpaper.Engine.v2.1.32.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }

        }

        //Premiere Pro
        private void btnPremiere_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools\\Adobe Premiere Pro 2022 Crack v22.1.2.1.zip"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                MessageBox.Show("This could take a while now");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://drive.google.com/u/1/uc?id=1sDuTj6eLTq1hcVBqi7z2e7E3SEB1TQ8H&export=download&confirm=t&uuid=568e1cbe-a49e-4cb5-a23b-bfa63f182327", "Adobe Premiere Pro 2022 Crack v22.1.2.1.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Adobe Premiere Pro 2022 Crack v22.1.2.1.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Adobe Premiere Pro 2022 Crack v22.1.2.1.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
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
                MessageBox.Show("This could take a while now");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://drive.google.com/u/0/uc?id=1PcRKxGY7kCAfugl16FNOc5cvL2TJNIqJ&export=download&confirm=t&uuid=89c0c722-a3ee-4d06-b302-93bf997d087f", "Adobe_Photoshop_2022_23.1.1.202.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Adobe_Photoshop_2022_23.1.1.202.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Tools", "Adobe_Photoshop_2022_23.1.1.202.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
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
    }
}
