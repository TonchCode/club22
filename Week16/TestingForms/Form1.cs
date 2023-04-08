using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingForms
{
    public partial class Form1 : Form
    {
        bool firstBox = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (firstBox) 
            {
                
            }
            else
            {

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {//                first                            second
            SumAns.Text = (Convert.ToInt32(Sum1.Text) + Convert.ToInt32(Sum2.Text)).ToString();
        }// + - * / %

        private void textBox2_Click(object sender, EventArgs e)
        {
            firstBox = false;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            firstBox = true;
        }

        private void Sum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
