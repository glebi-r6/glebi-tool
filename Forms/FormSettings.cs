﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace glebi_tool_2te_design.Forms
{
    public partial class FormSettings : Form
    {

        public FormSettings()
        {
            InitializeComponent();
            string path = Application.StartupPath;
            string filename = Path.GetFileName(Application.ExecutablePath);
            string pid = Process.GetCurrentProcess().Id.ToString();
        }

        private void llblDiscordsupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }

        private void llblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formPopup = new glebi_tool_2te_design_test.Forms.FormGithub();
            formPopup.Show(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/glebi-r6/glebi-tool/tree/main");
        }

        private void llbllicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html");
        }

        private void AutoStart_CheckedChanged(object sender, EventArgs e)
        {
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

               
                if (AutoStart.Checked)
                    rk.SetValue("glebi_tool", Application.ExecutablePath);
                else
                    rk.DeleteValue("glebi_tool", false);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            string filename = Path.GetFileName(Application.ExecutablePath);
            string pid = Process.GetCurrentProcess().Id.ToString();
            Process.Start("Updater.exe", "\"" + path + "\"" + " " + "\"" + filename + "\"" + " " + "\"" + pid + "\"");
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormChanges();
            formPopup.Show(this);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dotnet.microsoft.com/en-us/download/dotnet/3.1");
        }
    }
}
