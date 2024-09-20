using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VB_Net_Daryl.FrontEnd
{
    public partial class TheMindReader : Form
    {
        public TheMindReader()
        {
            InitializeComponent();
            //lblMessage.Text = message; // Label to display message
            //this.Text = title; // Set the title of the custom message box
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you ready for this?", "Hold on!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
