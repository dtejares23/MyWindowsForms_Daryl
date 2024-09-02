using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VB_Net_Daryl
{
    public partial class NewToDo : Form
    {
        public NewToDo()
        {
            InitializeComponent();
            this.Icon = new Icon("C:\\Users\\sbc11579\\source\\repos\\VB_Net_Daryl\\VB_Net_Daryl\\Images\\task.ico");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save?", 
                "Save _____ ?",
                MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Information
                );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No) 
            { 
                
            }
            else if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
