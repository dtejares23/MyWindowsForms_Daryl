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
    public partial class iTask : Form
    {
        private ProgressBar progressBar1;
        public iTask()
        {
            InitializeComponent();

            this.Icon = new Icon("C:\\Users\\sbc11579\\source\\repos\\VB_Net_Daryl\\VB_Net_Daryl\\Images\\task.ico");
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewToDo todo = new NewToDo();
            todo.Show();
        }

        private void iTask_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Hello_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheMindReader newForm = new TheMindReader();
            newForm.Show();
            Hide();
        }
    }
}
