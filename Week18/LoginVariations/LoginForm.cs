namespace LoginVariations
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private bool CheckForUser()
        {
            if (!File.Exists("database.txt"))
            {
                return false;
            }

            string[] data = File.ReadAllLines("database.txt");
            bool flag = false;

            string cryptedPassword = "";
            for (int h = 0; h < pass1.TextLength; h++)
            {
                cryptedPassword += pass1.Text[h] + 'h';
            }


            for (int i = 0; i < data.Length; i += 3)
            {
                // j = 0 => username
                // j = 1 => password
                // j = 3 => phone
                // i/3+1 => user number

                if (data[i + 0] == username.Text && data[i + 1] == cryptedPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(this);
            rf.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(!CheckForUser())
            {
                MessageBox.Show("Password or Username is incorrect", "Username Password error!", MessageBoxButtons.OK);
                return;
            }
            ListForm lf = new ListForm(this);
            lf.Show();
            this.Hide();
        }
    }
}