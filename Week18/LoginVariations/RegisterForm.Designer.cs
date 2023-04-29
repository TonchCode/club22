namespace LoginVariations
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.register = new System.Windows.Forms.Button();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(94, 137);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(156, 23);
            this.register.TabIndex = 11;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(94, 108);
            this.pass2.Name = "pass2";
            this.pass2.PasswordChar = '*';
            this.pass2.PlaceholderText = "Confirm Password";
            this.pass2.Size = new System.Drawing.Size(157, 23);
            this.pass2.TabIndex = 9;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(94, 79);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.PlaceholderText = "Password";
            this.pass1.Size = new System.Drawing.Size(157, 23);
            this.pass1.TabIndex = 8;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(94, 50);
            this.number.Name = "number";
            this.number.PlaceholderText = "Phone Number";
            this.number.Size = new System.Drawing.Size(157, 23);
            this.number.TabIndex = 7;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(94, 21);
            this.username.Name = "username";
            this.username.PlaceholderText = "Username";
            this.username.Size = new System.Drawing.Size(157, 23);
            this.username.TabIndex = 6;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 178);
            this.Controls.Add(this.register);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.username);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button register;
        private TextBox pass2;
        private TextBox pass1;
        private TextBox number;
        private TextBox username;
    }
}