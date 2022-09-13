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

namespace glebi_tool_2te_design.Forms
{
    public partial class FormCrackedGames : Form
    {
        
        SaveFileDialog sfd = new SaveFileDialog();

        public FormCrackedGames()
        {
            InitializeComponent();
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\The Forest\\The.Forest.Build.4175072-OFME.torrent"))
            {
                iconPictureBox2.Visible = true;
            }
        }

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
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormMinecraft();
            formPopup.Show(this);
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormStickFight();
            formPopup.Show(this);
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormVerdun();
            formPopup.Show(this);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormLGSW();
            formPopup.Show(this);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormForest();
            formPopup.Show(this);
        }

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormVolcan();
            formPopup.Show(this);
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.InfoCards.FormRON();
            formPopup.Show(this);
        }

        private void iconPictureBox8_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2_0.InfoCards.FormTannenBerg();
            formPopup.Show(this);
        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2_0.InfoCards.FormGarrysMod();
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
                MessageBox.Show("This could take a while now");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v1/Geometry.Dash.rar", "Geometry.Dash.rar");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Geometry.Dash.rar");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Geometry.Dash.rar");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
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
            }
        }

        //Hitman 3
        private void btnHitman3_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\HITMAN.3-FULL.UNLOCKED.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
            }
            else
            {
                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://cdn.discordapp.com/attachments/1016411808887746570/1016416201729130597/HITMAN.3-FULL.UNLOCKED.torrent", "HITMAN.3-FULL.UNLOCKED.torrent");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "HITMAN.3-FULL.UNLOCKED.torrent");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "HITMAN.3-FULL.UNLOCKED.torrent");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
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
            }
        }

        //OFME InfoCard
        private void iconPictureBox10_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2_0.InfoCards.FormOFME();
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
                MessageBox.Show("This could take a while now");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v2/60.Seconds.Reatomized.Build.8466895.zip", "60.Seconds.Reatomized.Build.8466895.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "60.Seconds.Reatomized.Build.8466895.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "60.Seconds.Reatomized.Build.8466895.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
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
            }
        }

        //The Forest
        private void iconButton7_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\Users\\" + Environment.UserName.ToString() + "\\Downloads\\Glebi-Tool\\Games\\The Forest");

            if (System.IO.File.Exists(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games\\The Forest\\The.Forest.Build.4175072-OFME.torrent"))
            {
                MessageBox.Show("Already Downlaoded");
                iconPictureBox2.Visible = true;
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

                iconPictureBox2.Visible = true;
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
                MessageBox.Show("This could take a while now");

                {
                    using (var wc = new WebClient())

                        wc.DownloadFile("https://github.com/davld122/Nothing-Special/releases/download/v3/Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip", "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");
                }

                // Get the full path of the download and the destination folder.
                string fromPath = Path.Combine(Application.StartupPath, "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");
                string toPath = Path.Combine(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games", "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");

                // Move the file.
                File.Move(fromPath, toPath);

                MessageBox.Show("Download Completed");
            }
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
            }

        }

        //Download Folder
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\\Users\\" + Environment.UserName + "\\Downloads\\Glebi-Tool\\Games");
        }
    }
}
