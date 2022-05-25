using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace NoRecoil
{

    public partial class gui : Form
    {
        bool appRunning = true;
        bool _ENABLED = false;
        string _configLoc = "C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Roaming\\MagicMouse";

        public gui()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void gui_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread MoveMouseThread = new Thread(_MoveMouse);
            Thread UpdateThread = new Thread(_Update);
            MoveMouseThread.Start();
            UpdateThread.Start();
            refreshCfgs();
            
            if (Directory.Exists(_configLoc)) { }
            else
            {
                Directory.CreateDirectory(_configLoc);
            }
        }

        private void _MoveMouse()
        {
            int i = 0;
            while(appRunning)
            {
                if (MagicMouse.bGetAsyncKeyState(Keys.LButton) && _ENABLED && tbIncrease.Value != 0)
                {
                    MagicMouse.Move(0, tbStep.Value + (tbIncrease.Value * i));
                    Thread.Sleep(tbDelay.Value);
                    if ((tbStep.Value + (tbIncrease.Value * i)) < tbMax.Value)
                        i++;
                }
                else if (MagicMouse.bGetAsyncKeyState(Keys.LButton) && _ENABLED)
                {
                    MagicMouse.Move(0, tbStep.Value);
                    Thread.Sleep(tbDelay.Value);
                }
                else
                {
                    i = 0;
                }
            }
        }

        private void _Update()
        {
            while(appRunning)
            {
                lblStep.Text = "Step[" + tbStep.Value.ToString() + "]:";
                lblDelay.Text = "Delay[" + tbDelay.Value.ToString() + "]:";
                lblIncrease.Text = "Increase[" + tbIncrease.Value.ToString() + "]:";
                lblMax.Text = "Max Inc.[" + tbMax.Value.ToString() + "]:";

                bool buffer = true;

                while (MagicMouse.bGetAsyncKeyState(Keys.F2))
                {
                    if (buffer)
                    {
                        _ENABLED = !_ENABLED;
                        buffer = false;
                    }
                }

                if (_ENABLED)
                {
                    if (MagicMouse._CHROMA_INITIALIZED && cbChroma.Checked)
                    {
                        MagicMouse.StateEnabled();
                    }
                    lblState.Text = "ENABLED [F2]";
                    lblState.ForeColor = Color.Green;
                    tbStep.Enabled = false;
                    tbDelay.Enabled = false;
                    tbIncrease.Enabled = false;
                    tbMax.Enabled = false;
                }
                else
                {
                    if (MagicMouse._CHROMA_INITIALIZED && cbChroma.Checked)
                    {
                        MagicMouse.StateDisabled();
                    }
                    lblState.Text = "DISABLED [F2]";
                    lblState.ForeColor = Color.Red;
                    tbStep.Enabled = true;
                    tbDelay.Enabled = true;
                    tbIncrease.Enabled = true;
                    tbMax.Enabled = true;
                }

                Thread.Sleep(1);
                buffer = true;
            }
        }

        private void gui_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!File.Exists(_configLoc + "\\" + txtCFG.Text))
                File.Create(_configLoc + "\\" + txtCFG.Text);
            refreshCfgs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(_configLoc + "\\" + txtCFG.Text))
                File.Delete(_configLoc + "\\" + txtCFG.Text);
            refreshCfgs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int[] settings =
            {
                tbStep.Value,
                tbDelay.Value,
                tbIncrease.Value,
                tbMax.Value,
            };
            MagicMouse.SaveIntConfig(_configLoc + "\\" + cbConfigs.Text, settings);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int[] settings = MagicMouse.LoadIntConfig(_configLoc + "\\" + cbConfigs.Text);
            tbStep.Value = settings[0];
            tbDelay.Value = settings[1];
            tbIncrease.Value = settings[2];
            tbMax.Value = settings[3];
        }

        private void refreshCfgs()
        {
            DirectoryInfo d = new DirectoryInfo(_configLoc);
            FileInfo[] Files = d.GetFiles();
            cbConfigs.Items.Clear();
            foreach (FileInfo file in Files)
            {
                cbConfigs.Items.Add(file.Name);
            }
            if (cbConfigs.Items.Count > 0)
                cbConfigs.SelectedIndex = 0;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            refreshCfgs();
        }

        private void cbChroma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChroma.Checked)
            {
                MagicMouse.InitializeChroma();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void gui_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCloseBasic_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
