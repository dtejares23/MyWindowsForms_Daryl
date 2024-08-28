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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArithmeticBox.TextChanged += ArithmeticBox_TextChanged;
        }

        private void ArithmeticBox_TextChanged(object sender, EventArgs e)
        {
            string allowedChars = "0123456789+-*/.";

            string filteredText = string.Empty;
            foreach (char ch in ArithmeticBox.Text)
            {
                if (allowedChars.Contains(ch))
                {
                    filteredText += ch;
                }
            }

            if (ArithmeticBox.Text != filteredText)
            {
                ArithmeticBox.Text = filteredText;
                ArithmeticBox.SelectionStart = ArithmeticBox.Text.Length;
            }
        }


        public void AritmeticBox(object sender, EventArgs e)
        {
            ArithmeticBox.Enabled = true;
        }

        private void ClearBtnOnClick(object sender, EventArgs e)
        {
            if(ArithmeticBox.Text == String.Empty || ArithmeticBox.Text == "Enter a number here")
            {
                if(ArithmeticBox.Text == "Enter a number here")
                {
                    return;
                } else
                {
                    MessageBox.Show("Input is empty, nothing to clear", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                return;
            }
            else
            {
                ArithmeticBox.Text = String.Empty;
                ArithmeticBox.Enabled = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string imagePath = "/Images/calculator.png";
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void OnClickEqualButton(object sender, EventArgs e)
        {
            
        }
    }
}
