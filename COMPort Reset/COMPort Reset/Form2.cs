using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPort_Reset
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnF2Accept.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnF2Accept.Enabled = true;
        }

        private void btnF2Accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnF2Decline_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
