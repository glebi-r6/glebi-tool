using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace glebi_tool_2te_design.Forms
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
            var formPopup = new Recoil.Form1();
            formPopup.Show(this);
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            var formPopup = new NoRecoil.gui();
            formPopup.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/xqpRDHtznw");
        }
    }
    
}
