namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.loginNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.addInternationalStudentBtn = new System.Windows.Forms.Button();
            this.athleticIdText = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginNameText
            // 
            this.loginNameText.Location = new System.Drawing.Point(283, 94);
            this.loginNameText.Name = "loginNameText";
            this.loginNameText.Size = new System.Drawing.Size(239, 20);
            this.loginNameText.TabIndex = 0;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(283, 152);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.Size = new System.Drawing.Size(239, 20);
            this.passwordText.TabIndex = 1;
            // 
            // addInternationalStudentBtn
            // 
            this.addInternationalStudentBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addInternationalStudentBtn.ForeColor = System.Drawing.Color.Honeydew;
            this.addInternationalStudentBtn.Location = new System.Drawing.Point(245, 224);
            this.addInternationalStudentBtn.Name = "addInternationalStudentBtn";
            this.addInternationalStudentBtn.Size = new System.Drawing.Size(81, 28);
            this.addInternationalStudentBtn.TabIndex = 38;
            this.addInternationalStudentBtn.Text = "Add";
            this.addInternationalStudentBtn.UseVisualStyleBackColor = false;
            this.addInternationalStudentBtn.Click += new System.EventHandler(this.addInternationalStudentBtn_Click);
            // 
            // athleticIdText
            // 
            this.athleticIdText.Enabled = false;
            this.athleticIdText.Location = new System.Drawing.Point(332, 24);
            this.athleticIdText.Name = "athleticIdText";
            this.athleticIdText.Size = new System.Drawing.Size(161, 20);
            this.athleticIdText.TabIndex = 40;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.ForeColor = System.Drawing.Color.Honeydew;
            this.exitBtn.Location = new System.Drawing.Point(379, 224);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(81, 28);
            this.exitBtn.TabIndex = 39;
            this.exitBtn.Text = " Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // AdminLoginForm
            // 
            this.AcceptButton = this.addInternationalStudentBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(729, 288);
            this.Controls.Add(this.athleticIdText);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addInternationalStudentBtn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.loginNameText);
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button addInternationalStudentBtn;
        private System.Windows.Forms.TextBox athleticIdText;
        private System.Windows.Forms.Button exitBtn;
    }
}