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
    public partial class RegisterForm : Form
    {
        LoginForm lf;
        public RegisterForm(LoginForm lf)
        {
            InitializeComponent();
            this.lf = lf;
        }

        private bool UsernameExists(string username)
        {
            return File.ReadAllLines("database.txt").Contains(username);
        }

        private void register_Click(object sender, EventArgs e)
        {
            long pNumber;
            if (pass1.Text != pass2.Text)
                MessageBox.Show("Passwords do not match!", "Password error!", MessageBoxButtons.OK);

            else if (!long.TryParse(number.Text, null, out pNumber))
                MessageBox.Show("Phone number is not a number!\nNumber: " + pNumber, "Number error!", MessageBoxButtons.OK);

            else if (UsernameExists(username.Text))
                MessageBox.Show("This username already exists!", "Username error!", MessageBoxButtons.OK);
            else
            {
                FileStream fs = new FileStream("database.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                fs.Position = fs.Length;
                sw.WriteLine(username.Text);

                string cryptedPassword = "";
                for (int i = 0; i < pass1.TextLength; i++)
                {
                    cryptedPassword += pass1.Text[i] + 'h';
                }

                sw.WriteLine(cryptedPassword);
                sw.WriteLine(number.Text);
                sw.Close();
                fs.Close();
                this.Hide();
                lf.Show();
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Show();
        }
    }
}
