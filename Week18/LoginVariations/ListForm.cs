using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginVariations
{
    public partial class ListForm : Form
    {
        LoginForm lf;
        public ListForm(LoginForm lf)
        {
            InitializeComponent();
            this.lf = lf;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nameNumberList.DataSource = File.ReadAllLines("database.txt");
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Show();
        }
    }
}
