namespace LoginVariations
{
    partial class ListForm
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
            this.nameNumberList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameNumberList
            // 
            this.nameNumberList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameNumberList.FormattingEnabled = true;
            this.nameNumberList.ItemHeight = 15;
            this.nameNumberList.Location = new System.Drawing.Point(0, 0);
            this.nameNumberList.Name = "nameNumberList";
            this.nameNumberList.Size = new System.Drawing.Size(253, 417);
            this.nameNumberList.TabIndex = 0;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 417);
            this.Controls.Add(this.nameNumberList);
            this.Name = "ListForm";
            this.Text = "List Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox nameNumberList;
    }
}