using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace glebi_tool_2te_design.Forms
{
    public partial class FormCrackedGames : Form
    {
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
    }
}
