using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace glebi_tool.Forms
{
    public partial class FormSettings : Form
    {

        public FormSettings()
        {
            InitializeComponent();
            string path = Application.StartupPath;
            string filename = Path.GetFileName(Application.ExecutablePath);
            string pid = Process.GetCurrentProcess().Id.ToString();

            Smaragd = new Dictionary<ThemeColor, Color>() {
            { ThemeColor.Primary, Color.MediumSeaGreen },
            { ThemeColor.Secondary, Color.MediumSeaGreen },
            { ThemeColor.Text, Color.MediumSeaGreen }
                };
        }

        //Themes

        enum ThemeColor
        {
            Primary,
            Secondary,
            Text
        }

        Dictionary<ThemeColor, Color> Smaragd = new Dictionary<ThemeColor, Color>();

        private void ChangeTheme(Color primaryColor, Color secondaryColor)
        {
            // Change background color of buttons
            foreach (Button btn in Controls.OfType<Button>())

                btn.BackColor = primaryColor;

            foreach (Button btn in Controls.OfType<Button>())

                btn.FlatAppearance.BorderColor = Color.LightSeaGreen;

                btnJade.BackColor = Color.MediumSeaGreen;

                btnRuby.BackColor = Color.Crimson;
                btnRuby.FlatAppearance.BorderColor = Color.Red;

                btnAzurite.BackColor = Color.DodgerBlue;
                btnAzurite.FlatAppearance.BorderColor = Color.RoyalBlue;
        }

        private void ChangeTextColor(Color textColor)
        {
            // Change color of text

            foreach (LinkLabel link in Controls.OfType<LinkLabel>())

                link.LinkColor = Color.LightSeaGreen;

            foreach (Label l in Controls.OfType<Label>())

                l.ForeColor = textColor;
                label4.ForeColor = Color.WhiteSmoke;
                label1.ForeColor = Color.LightSeaGreen;
                label3.ForeColor = Color.LightSeaGreen;
                label6.ForeColor = Color.LightSeaGreen;
        }

        //Discord support
        private void llblDiscordsupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }

        //Github Form
        private void llblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formPopup = new glebi_tool.Forms.FormGithub();
            formPopup.Show(this);
        }

        //Github Link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/glebi-r6/glebi-tool/tree/main");
        }

        //License
        private void llbllicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html");
        }

        //Auto Start
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

        //Update
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

        //Discord
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }

        //Changes
        private void button3_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.InfoCards.FormChanges();
            formPopup.Show(this);
        }

        //.Net 3.1
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dotnet.microsoft.com/en-us/download/dotnet/3.1");
        }

        //Themes Jade
        private void btnjade_Click(object sender, EventArgs e)
        {
            ChangeTheme(Smaragd[ThemeColor.Primary], Smaragd[ThemeColor.Secondary]);
            ChangeTextColor(Smaragd[ThemeColor.Text]);
        }

        
    }
}
