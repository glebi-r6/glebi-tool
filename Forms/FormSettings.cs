using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.ComponentModel;
using System.Net;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Ionic.Zip;

namespace glebi_tool.Forms
{
    enum LauncherStatus
    {
        ready,
        failed,
        downloadingTool,
        downloadingUpdate
    }

    public partial class FormSettings : Form
    {
        private string rootPath;
        private string versionFile;
        private string toolZip;
        private string toolExe;

        private LauncherStatus _status;
        internal LauncherStatus Status
        {
            get => _status;
            set
            {
                _status = value;
                switch (_status)
                {
                    case LauncherStatus.ready:
                        btnUpdate.Text = "Latest Version";
                        break;
                    case LauncherStatus.failed:
                        btnUpdate.Text = "Update Failed - Retry";
                        break;
                    case LauncherStatus.downloadingTool:
                        btnUpdate.Text = "Downloading Tool";
                        break;
                    case LauncherStatus.downloadingUpdate:
                        btnUpdate.Text = "Downloading Update";
                        break;
                    default:
                        break;
                }
            }
        }

        public FormSettings()
        {
            InitializeComponent();

            rootPath = Directory.GetCurrentDirectory();
            versionFile = Path.Combine(rootPath, "Current Verison.txt");
            toolZip = Path.Combine(rootPath, "Glebi-tool.2.1.2.zip");
            toolExe = Path.Combine(rootPath, "Tool", "glebi-tool 2.1.3.exe");

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
            CheckForUpdates();

            //--------------Old Code --------------
            //(Could be much better | write me on Discord for Updater.exe source code | glebi#1773)
            //string path = Application.StartupPath;
            //string filename = Path.GetFileName(Application.ExecutablePath);
            //string pid = Process.GetCurrentProcess().Id.ToString();
            //Process.Start("Updater.exe", "\"" + path + "\"" + " " + "\"" + filename + "\"" + " " + "\"" + pid + "\"");
        }

        //Update (Improved | still kinda buggy)
        private void CheckForUpdates()
        {
            string link = "https://github.com/glebi-r6/glebi-tool/releases/tag/2.1.4";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Method = "HEAD";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    File.Delete("Current Verison.txt");
                    File.Delete("Updater.pdb");
                    File.Delete("glebi-tool 2.1.2.exe.config");
                    File.Delete("glebi-tool 2.1.2.pdb");
                    File.Delete("glebi-tool 2.1.2.exe.manifest");
                    File.Delete("Updater.pdb");
                    Console.WriteLine("File deleted successfully.");
                }
                else
                {
                    Console.WriteLine("An error occurred");
                }
                response.Close();
            }
            catch (WebException ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            if (File.Exists(versionFile))
            {
                Version localVersion = new Version(File.ReadAllText(versionFile));
                label4.Text = localVersion.ToString();

                try
                {
                    WebClient webClient = new WebClient();
                    Version onlineVersion = new Version(webClient.DownloadString("https://drive.google.com/uc?export=download&id=12EFCMpzt7zuaOd_xEC0_iVedxcUN3x1r"));

                    if (onlineVersion.IsDifferentThan(localVersion))
                    {
                        InstallToolFiles(false, onlineVersion);
                    }
                    else
                    {
                        Status = LauncherStatus.ready;
                    }
                }
                catch (Exception ex)
                {
                    Status = LauncherStatus.failed;
                    MessageBox.Show($"Error checking for Tool updates: {ex}");
                }
            }
            else
            {
                InstallToolFiles(false, Version.zero);
            }
        }

        private void InstallToolFiles(bool _isUpdate, Version _onlineVersion)
        {
            try
            {
                WebClient webClient = new WebClient();
                if (_isUpdate)
                {
                    Status = LauncherStatus.downloadingUpdate;
                }
                else
                {
                    Status = LauncherStatus.downloadingTool;
                    _onlineVersion = new Version(webClient.DownloadString("https://drive.google.com/uc?export=download&id=12EFCMpzt7zuaOd_xEC0_iVedxcUN3x1r"));
                }

                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadToolCompletedCallback);
                webClient.DownloadFileAsync(new Uri("https://github.com/glebi-r6/glebi-tool/releases/download/2.1.4/Glebi-tool.2.1.4.zip"), toolZip, _onlineVersion);
            }
            catch (Exception ex)
            {
                Status = LauncherStatus.failed;
                MessageBox.Show($"Error installing Tool files: {ex}");
            }
        }

        private void DownloadToolCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                string onlineVersion = ((Version)e.UserState).ToString();

                Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile();

                zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                zip.ExtractAll(rootPath);

                File.Delete(toolZip);

                File.WriteAllText(versionFile, onlineVersion);
                label4.Text = onlineVersion;
                Status = LauncherStatus.ready;

                MessageBox.Show("Please Restart");

                Process.Start(Application.StartupPath);
                Application.Exit();
            }
            catch (Exception ex)
            {
                Status = LauncherStatus.failed;
                MessageBox.Show($"Error finishing download: {ex}");
            }
        }

        struct Version
        {
            internal static Version zero = new Version(0, 0, 0);

            private short major;
            private short minor;
            private short subMinor;

            internal Version(short _major, short _minor, short _subMinor)
            {
                major = _major;
                minor = _minor;
                subMinor = _subMinor;
            }

            internal Version(string _version)
            {
                string[] _versionStrings = _version.Split('.');
                if (_versionStrings.Length != 3)
                {
                    major = 2;
                    minor = 1;
                    subMinor = 3;
                    return;
                }

                major = short.Parse(_versionStrings[0]);
                minor = short.Parse(_versionStrings[1]);
                subMinor = short.Parse(_versionStrings[2]);
            }

            internal bool IsDifferentThan(Version _otherVersion)
            {
                if (major != _otherVersion.major)
                {
                    return true;
                }
                else
                {
                    if (minor != _otherVersion.minor)
                    {
                        return true;
                    }
                    else
                    {
                        if (subMinor != _otherVersion.subMinor)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            public override string ToString()
            {
                return $"{major}.{minor}.{subMinor}";
            }

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

        //App files
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }
    }
}
