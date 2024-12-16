using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB_Net_Daryl.FrontEnd;

namespace VB_Net_Daryl
{
    public partial class ITask : Form
    {
        private ProgressBar progressBar1;
        public ITask()
        {
            InitializeComponent();

            this.Icon = new Icon("C:\\Users\\sbc11579\\source\\repos\\VB_Net_Daryl\\VB_Net_Daryl\\Images\\task.ico");
        }




        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NewToDo todo = new NewToDo();
            todo.Show();
        }

        private void ITask_Load(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Hello_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TheMindReader newForm = new TheMindReader();
            newForm.Show();
            Hide();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
