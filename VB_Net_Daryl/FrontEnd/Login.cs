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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameInputBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void PasswordInputBox_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn.PerformClick();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameInputBox.Text == "dtejares" || PasswordInputBox.Text == "Elliyah2023")
            {
                iTask newForm = new iTask();
                newForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Wrong", "Please enter correct Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
