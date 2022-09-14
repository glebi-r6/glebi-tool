using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using glebi_tool;

namespace glebi_tool_2_0.cheat.Recoil2
{
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {        
            glebi_tool.Properties.Settings.Default.Dontshow = this.checkBox1.Checked;
            glebi_tool.Properties.Settings.Default.Save();
            if (!glebi_tool.Properties.Settings.Default.Dontshow)
                new FormMessage().ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
