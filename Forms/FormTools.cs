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
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete1);
            Uri rarurl = new Uri("https://download1501.mediafire.com/l2j5vxzju1sg/sikqz4dfkdypi11/KMSpico_10.2.0.rar");
            wc.DownloadFileAsync(rarurl, "KMSpico_10.2.0.rar");
        }

        private void FileDownloadComplete1(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete1);
        }


        //Office
        private void btnOffice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This could take a while now");
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete2);
            Uri imgurl = new Uri("https://officecdn.microsoft.com/db/492350f6-3a01-4f97-b9c0-c7c6ddf67d60/media/en-us/ProPlus2021Retail.img");
            wc.DownloadFileAsync(imgurl, "ProPlus2021Retail.img");
        }

        private void FileDownloadComplete2(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete2);
        }


        //Spotify
        private void btnSpotify_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete3);
            Uri baturl = new Uri("https://download1647.mediafire.com/9m8ownngwgag/8qe7tem69mfqkae/BlockTheSpot.bat");
            wc.DownloadFileAsync(baturl, "BlockTheSpot.bat");
        }

        private void FileDownloadComplete3(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete3);
        }


        //Wallpaper Egine
        private void btWallpaper_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete4);
            Uri rarurl = new Uri("https://download1478.mediafire.com/bbwemcienxgg/zfb3b71ahf3ai8b/Wallpaper.Engine.v2.0.98.rar");
            wc.DownloadFileAsync(rarurl, "Wallpaper.Engine.v2.0.98.rar");
        }

        private void FileDownloadComplete4(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete4);
        }


        //Premiere Pro
        private void btnPremiere_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This could take a while now");
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete5);
            Uri rarurl = new Uri("https://download948.mediafire.com/teihzr3i40fg/3dfvzk4jnfh8o3x/Adobe+Premiere+Pro+2022+Crack+v22.1.2.1+%5BLatest%5D.rar");
            wc.DownloadFileAsync(rarurl, "Adobe Premiere Pro 2022 Crack v22.1.2.1 [Latest].rar");
        }

        private void FileDownloadComplete5(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete5);
        }


        //Photoshop
        private void btnPhotoshop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This could take a while now");
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete6);
            Uri rarurl = new Uri("https://download1326.mediafire.com/koetke1cjvkg/4zvlura4zii7yiv/Adobe+Photoshop+2022+Crack+v23.1.1.202.rar");
            wc.DownloadFileAsync(rarurl, "Adobe Photoshop 2022 Crack v23.1.1.202.rar");
        }

        private void FileDownloadComplete6(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete6);
        }

        //Office InfoCard
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2_0.InfoCards.FromOffice();
            formPopup.Show(this);
        }

        //Interntet Download Manager 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete7);
            Uri rarurl = new Uri("https://download1483.mediafire.com/6bnkbyj379gg/mnhsbebixa16g7w/IDM+Crack+6.40+Build+11+Patch+%2B+Serial+Key+%5BLatest%5D.zip");
            wc.DownloadFileAsync(rarurl, "IDM Crack 6.40 Build 11 Patch + Serial Key [Latest].rar");
        }

        private void FileDownloadComplete7(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            wc.DownloadFileCompleted -= new AsyncCompletedEventHandler(FileDownloadComplete7);
        }

        //IDM InfoCard
        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool_2_0.InfoCards.FormIDM();
            formPopup.Show(this);
        }
    }
}
