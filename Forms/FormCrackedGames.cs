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
using AltoHttp;
using System.Threading;
using System.Runtime.InteropServices;

namespace glebi_tool.Forms
{
    public partial class FormCrackedGames : Form
    {
        private HttpDownloader hd = null;

        SaveFileDialog sfd = new SaveFileDialog();

        public FormCrackedGames()
        {
            InitializeComponent();
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\The Forest\\The.Forest.Build.4175072-OFME.torrent"))
            {
                iconPictureBox2.Visible = true;
            }
        }

        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);

        private void llblBittorrent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bittorrent.com/de/products/win/bittorrent-classic-free/");
        }

        private void llblDiscordsupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormMinecraft();
            formPopup.Show(this);
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormStickFight();
            formPopup.Show(this);
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormVerdun();
            formPopup.Show(this);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormLGSW();
            formPopup.Show(this);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormForest();
            formPopup.Show(this);
        }

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormVolcan();
            formPopup.Show(this);
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormRON();
            formPopup.Show(this);
        }

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormTannenBerg();
            formPopup.Show(this);
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormGarrysMod();
            formPopup.Show(this);
        }

        //Minecraft
        private void btnMinecraft_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\MfW10_Fix_Repair_UWP_Generic.rar"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016422145229848686/MfW10_Fix_Repair_UWP_Generic.rar", "MfW10_Fix_Repair_UWP_Generic.rar");
                }

                string fromPath = Path.Combine(Application.StartupPath, "MfW10_Fix_Repair_UWP_Generic.rar");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "MfW10_Fix_Repair_UWP_Generic.rar");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Geometry Dash
        private void btnGDash_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Geometry.Dash.rar"))
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

                Geometry_Dash.RunWorkerAsync();
            }
        }

        //Geometry Dash BackgroundWorker
        private void Geometry_Dash_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://github.com/davld122/Nothing-Special/releases/download/v1/Geometry.Dash.rar";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted1;
            BlockInput(true);
            hd.Start();
        }

        //God of War
        private void btnGoW_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\God_of_War-FLT.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016418577550671962/God_of_War-FLT.torrent", "God_of_War-FLT.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "God_of_War-FLT.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "God_of_War-FLT.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Detroit Become Human
        private void btnDBH_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Detroit.Become.Human-CODEX.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://download1583.mediafire.com/bha2rq962llg/pxtb8iw3pt7lxzh/Detroit.Become.Human-CODEX.torrent", "Detroit.Become.Human-CODEX.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Detroit.Become.Human-CODEX.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Detroit.Become.Human-CODEX.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Hitman 3
        private void btnHitman3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\HITMAN.3.Deluxe.Edition.v3.120.0.0-P2P.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1021180166766080041/HITMAN.3.Deluxe.Edition.v3.120.0.0-P2P.torrent", "HITMAN.3.Deluxe.Edition.v3.120.0.0-P2P.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "HITMAN.3.Deluxe.Edition.v3.120.0.0-P2P.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "HITMAN.3.Deluxe.Edition.v3.120.0.0-P2P.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //LEGO Star Wars The Skywalker Saga
        private void btnLSWTSS_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\LEGO.Star.Wars.The.Skywalker.Saga.v1.0.0.32877-P2P.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016627842114654208/LEGO.Star.Wars.The.Skywalker.Saga.v1.0.0.32877-P2P.torrent", "LEGO.Star.Wars.The.Skywalker.Saga.v1.0.0.32877-P2P.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "LEGO.Star.Wars.The.Skywalker.Saga.v1.0.0.32877-P2P.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "LEGO.Star.Wars.The.Skywalker.Saga.v1.0.0.32877-P2P.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Teardown
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Teardown-DARKSiDERS.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016416035617906729/Teardown-DARKSiDERS.torrent", "Teardown-DARKSiDERS.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Teardown-DARKSiDERS.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Teardown-DARKSiDERS.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //OFME InfoCard
        private void iconPictureBox10_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormOFME();
            formPopup.Show(this);
        }

        //60 Secondes 
        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\60.Seconds.Reatomized.Build.8466895.zip"))
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

                Secondes_60.RunWorkerAsync();
            }
        }

        //60 Secondes BackgroundWorker
        private void Secondes_60_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://github.com/davld122/Nothing-Special/releases/download/v2/60.Seconds.Reatomized.Build.8466895.zip";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted2;
            BlockInput(true);
            hd.Start();
        }

        //Volcanoids
        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Volcanoids.v1.27.271.0-OFME.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
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

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //The Forest
        private void iconButton7_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\Users\\" + Environment.UserName.ToString() + "\\Downloads\\Glebi-Tool\\Games\\The Forest");

            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\The Forest\\The.Forest.Build.4175072-OFME.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016415938473627668/The.Forest.Build.4175072-OFME.torrent", "The.Forest.Build.4175072-OFME.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "The.Forest.Build.4175072-OFME.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\The Forest", "The.Forest.Build.4175072-OFME.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                var formPopup = new glebi_tool.InfoCards.FormForest();
                formPopup.Show(this);
            }
        }

        //Ready or Not
        private void iconButton19_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Ready.or.Not.Build.09082022-OFME.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016417314226307173/Ready.or.Not.Build.09082022-OFME.torrent", "Ready.or.Not.Build.09082022-OFME.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Ready.or.Not.Build.09082022-OFME.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Ready.or.Not.Build.09082022-OFME.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Verdun
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Verdun.v318.32425-OFME.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016415915232993321/Verdun.v318.32425-OFME.torrent", "Verdun.v318.32425-OFME.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Verdun.v318.32425-OFME.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Verdun.v318.32425-OFME.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Stick Fight
        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Stick.Fight.The.Game.Build.12062019-OFME_1.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016418577085124608/Stick.Fight.The.Game.Build.12062019-OFME_1.torrent", "Stick.Fight.The.Game.Build.12062019-OFME_1.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Stick.Fight.The.Game.Build.12062019-OFME_1.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Stick.Fight.The.Game.Build.12062019-OFME_1.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Getting over it
        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip"))
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

                Getting_Over_It.RunWorkerAsync();
            }
        }

        //Getting over it BackgroundWorker
        private void Getting_Over_It_DoWork(object sender, DoWorkEventArgs e)
        {
            string url = "https://github.com/davld122/Nothing-Special/releases/download/v3/Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip";

            BlockInput(true);
            Application.UseWaitCursor = true;

            hd = new HttpDownloader(url, $"{Application.StartupPath}\\{Path.GetFileName(url)}");
            hd.ProgressChanged += HttpDownloader_ProgressChanged;
            hd.DownloadCompleted += HttpDownloader_DownloadCompleted3;
            BlockInput(true);
            hd.Start();
        }

        //Stray
        private void iconButton12_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Stray-P2P.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016633527980261376/Stray-P2P.torrent", "Stray-P2P.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Stray-P2P.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Stray-P2P.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }

        }

        //Download Folder
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
        }

        //Horizon Zero Dawn Complete Edition
        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Horizon.Zero.Dawn.Complete.Edition.v1.0.11.14-GOG.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1021166358349758545/Horizon.Zero.Dawn.Complete.Edition.v1.0.11.14-GOG.torrent", "Horizon.Zero.Dawn.Complete.Edition.v1.0.11.14-GOG.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Horizon.Zero.Dawn.Complete.Edition.v1.0.11.14-GOG.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Horizon.Zero.Dawn.Complete.Edition.v1.0.11.14-GOG.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Marvel Spider Man Remastered
        private void iconButton8_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Marvels.Spider.Man.Remastered.v1.907.0.0-P2P.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1021180133643661432/Marvels.Spider.Man.Remastered.v1.907.0.0-P2P.torrent", "Marvels.Spider.Man.Remastered.v1.907.0.0-P2P.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Marvels.Spider.Man.Remastered.v1.907.0.0-P2P.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Marvels.Spider.Man.Remastered.v1.907.0.0-P2P.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
        }

        //Red Dead Redemption 2
        private void iconButton14_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\Red.Dead.Redemption.2.Build.1436.28-EMPRESSMr_Goldberg.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1021180293249507388/Red.Dead.Redemption.2.Build.1436.28-EMPRESSMr_Goldberg.torrent", "Red.Dead.Redemption.2.Build.1436.28-EMPRESSMr_Goldberg.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Red.Dead.Redemption.2.Build.1436.28-EMPRESSMr_Goldberg.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Red.Dead.Redemption.2.Build.1436.28-EMPRESSMr_Goldberg.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");

                Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
            }
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
                string fromPath = Path.Combine(Application.StartupPath, "Geometry.Dash.rar");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Geometry.Dash.rar");

                // Move the file.
                File.Move(fromPath, toPath);

                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "Geometry.Dash.rar");
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
                MessageBox.Show("Download Completed");
            }
            finally
            {
                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "60.Seconds.Reatomized.Build.8466895.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "60.Seconds.Reatomized.Build.8466895.zip");
                
                // Move the file.
                File.Move(fromPath, toPath);
                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "60.Seconds.Reatomized.Build.8466895.zip");
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
                string fromPath = Path.Combine(Application.StartupPath, "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");

                // Move the file.
                File.Move(fromPath, toPath);
                try
                {
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
                }
                catch
                {
                    Process.Start(Application.StartupPath + "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");
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
    }
}
