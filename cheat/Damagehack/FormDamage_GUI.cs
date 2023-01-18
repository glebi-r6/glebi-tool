using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glebi_tool.cheat.Damagehack
{
    public partial class FormDamage_GUI : Form
    {
        [DllImport("UnmanagedDMG.dll")]
        public static extern void damage(int damage);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

        int nLeftRect, // x-cordinate of upper-left corner
        int nTopRect, // y-cordinate of upper-left corner
        int nRightRect, // x-cordinate of Lower-right corner
        int nBottomRect, // y-cordinate of Lower-right corner
        int nWidthEllipse, // Width of Ellipse
        int nHeightEllipse // Height of Ellipse
        );

        public FormDamage_GUI()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(-1, -1, Width, Height, 30, 30));
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            damage(Convert.ToInt32(numericUpDown1.Value));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormDamage_GUI_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
