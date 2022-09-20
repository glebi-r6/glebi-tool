using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using glebi_tool.cheat.Recoil;
using System.IO;

namespace glebi_tool.Forms
{
    public partial class FormDiscord : Form
    {
        public FormDiscord()
        {
            InitializeComponent();
        }
        
        private void FormDiscord_Load(object sender, EventArgs e)
        {

        }

        private void btnRust_Click(object sender, EventArgs e)
        {
            var formPopup = new glebi_tool.cheat.Recoil.Form1();
            formPopup.Show(this);
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
           System.IO.Directory.CreateDirectory("C:\\Users\\" + Environment.UserName.ToString() + "\\AppData\\Roaming\\MagicMouse");

            if (sender == btnBasic)
            {
                var formPopup2 = new glebi_tool.cheat.Recoil2.gui();
                formPopup2.Show(this);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }
    }
    
}
