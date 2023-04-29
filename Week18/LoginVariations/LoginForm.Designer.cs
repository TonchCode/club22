namespace LoginVariations
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(67, 12);
            this.username.Name = "username";
            this.username.PlaceholderText = "Username";
            this.username.Size = new System.Drawing.Size(157, 23);
            this.username.TabIndex = 0;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(67, 41);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.PlaceholderText = "Password";
            this.pass1.Size = new System.Drawing.Size(157, 23);
            this.pass1.TabIndex = 2;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(67, 70);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 4;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(148, 70);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(76, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 113);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.username);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox username;
        private TextBox number;
        private TextBox pass1;
        private Button register;
        private Button login;
    }
}