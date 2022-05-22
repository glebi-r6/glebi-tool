using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace glebi_tool_2te_design.Forms
{
    public partial class FormCrackedGames : Form
    {
        WebClient wc = new WebClient();
        public FormCrackedGames()
        {
            InitializeComponent();
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
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete1);
            Uri rarurl = new Uri("https://download1084.mediafire.com/mc38xghl8djg/bvoldan99tlg6gf/18.31.rar");
            wc.DownloadFileAsync(rarurl, "18.31.rar");
        }

        private void FileDownloadComplete1(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete1);
        }


        //Geometry Dash
        private void btnGDash_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete2);
            Uri rarurl = new Uri("https://download1324.mediafire.com/9yp72eb3tetg/byew9nd8kvldpok/Geometry+Dash.rar");
        }

        private void FileDownloadComplete2(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete2);
        }


        //God of War
        private void btnGoW_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete3);
            Uri torrenturl = new Uri("https://download943.mediafire.com/mig3id1fzhwg/bvu89mpyapl8lid/God_of_War-FLT.torrent");
            wc.DownloadFileAsync(torrenturl, "God_of_War-FLT.torrent");
        }

        private void FileDownloadComplete3(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete3);
        }


        //Detroit Become Human
        private void btnDBH_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete4);
            Uri torrenturl = new Uri("https://download1583.mediafire.com/bha2rq962llg/pxtb8iw3pt7lxzh/Detroit.Become.Human-CODEX.torrent");
            wc.DownloadFileAsync(torrenturl, "Detroit.Become.Human-CODEX.torrent");  
        }

        private void FileDownloadComplete4(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete4);
        }


        //Hitman 3
        private void btnHitman3_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete5);
            Uri torrenturl = new Uri("https://download1640.mediafire.com/0j0pmu0bvv1g/iw7nkx6lrds9v9y/HITMAN.3-FULL.UNLOCKED.torrent");
            wc.DownloadFileAsync(torrenturl, "HITMAN.3-FULL.UNLOCKED.torrent");
        }

        private void FileDownloadComplete5(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete5);
        }


        //LEGO Star Wars The Skywalker Saga
        private void btnLSWTSS_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete6);
            Uri torrenturl = new Uri("https://download1349.mediafire.com/y4ktqohv2ung/al3az3koik5bujp/LEGO_Star_Wars_The_Skywalker_Saga-FLT.torrent");
            wc.DownloadFileAsync(torrenturl, "LEGO_Star_Wars_The_Skywalker_Saga-FLT.torrent");
        }

        private void FileDownloadComplete6(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete6);
        }


        //Teardown
        private void iconButton4_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete7);
            Uri torrenturl = new Uri("https://download1593.mediafire.com/q4en902mgvcg/tku7uwn09pe4ucl/Teardown-DARKSiDERS.torrent");
            wc.DownloadFileAsync(torrenturl, "Teardown-DARKSiDERS.torrent");
        }

        private void FileDownloadComplete7(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete7);
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
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete8);
            Uri zipurl = new Uri("https://download1335.mediafire.com/emyd3z37ao3g/mrx11ymu0kgcw13/60.Seconds.Reatomized.Build.8466895.zip");
            wc.DownloadFileAsync(zipurl, "60.Seconds.Reatomized.Build.8466895.zip");
        }

        private void FileDownloadComplete8(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete8);
        }


        //Volcanoids
        private void iconButton3_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete9);
            Uri torrenturl = new Uri("https://download1074.mediafire.com/evlr2inneu2g/plx364uy6a34qpb/Volcanoids.v1.27.271.0-OFME.torrent");
            wc.DownloadFileAsync(torrenturl, "Volcanoids.v1.27.271.0-OFME.torrent");
        }

        private void FileDownloadComplete9(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete9);
        }


        //The Forest
        private void iconButton7_Click(object sender, EventArgs e)
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


        //Ready or Not
        private void iconButton19_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete11);
            Uri torrenturl = new Uri("https://download1338.mediafire.com/7670jxokbodg/8m59qsj2dtb89jo/Ready.or.Not.v19020-OFME.torrent");
            wc.DownloadFileAsync(torrenturl, "Ready.or.Not.v19020-OFME.torrent");
        }

        private void FileDownloadComplete11(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete11);
        }


        //Verdun
        private void iconButton2_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete12);
            Uri torrenturl = new Uri("https://download1523.mediafire.com/4vpjj2icblng/399mkl2lg4y4uet/Verdun.v318.32425-OFME.torrent");
            wc.DownloadFileAsync(torrenturl, "Verdun.v318.32425-OFME.torrent");
        }

        private void FileDownloadComplete12(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete12);
        }


        //Stick Fight
        private void iconButton11_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete13);
            Uri torrenturl = new Uri("https://download940.mediafire.com/kdusgwmlxnkg/td41on9osa747os/Stick.Fight.The.Game.Build.12062019-OFME.torrent");
            wc.DownloadFileAsync(torrenturl, "Stick.Fight.The.Game.Build.12062019-OFME.torrent");
        }

        private void FileDownloadComplete13(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete13);
        }


        //Getting over it
        private void iconButton10_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete14);
            Uri zipurl = new Uri("https://download1484.mediafire.com/pde67vsqn6qg/k5o24hkckv98rsr/Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");
            wc.DownloadFileAsync(zipurl, "Getting.Over.It.with.Bennett.Foddy.Build.7976204.zip");
        }

        private void FileDownloadComplete14(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete14);
        }
    }
}
