namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher
{
    partial class AddInternationalStudent
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
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.beltText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.IdText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addStudentBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addStudentBtn.Location = new System.Drawing.Point(312, 249);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(81, 28);
            this.addStudentBtn.TabIndex = 46;
            this.addStudentBtn.Text = "Add";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // countryCombo
            // 
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(216, 145);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(121, 21);
            this.countryCombo.TabIndex = 45;
            // 
            // beltText
            // 
            this.beltText.Location = new System.Drawing.Point(216, 190);
            this.beltText.Name = "beltText";
            this.beltText.Size = new System.Drawing.Size(106, 20);
            this.beltText.TabIndex = 44;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(216, 95);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(400, 20);
            this.nameText.TabIndex = 43;
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(328, 24);
            this.IdText.Name = "IdText";
            this.IdText.ReadOnly = true;
            this.IdText.Size = new System.Drawing.Size(146, 20);
            this.IdText.TabIndex = 42;
            // 
            // AddInternationalStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectNTF.Properties.Resources.AddInternationalStudent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(718, 290);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.countryCombo);
            this.Controls.Add(this.beltText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.IdText);
            this.Name = "AddInternationalStudent";
            this.Text = "Add International Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.TextBox beltText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox IdText;
    }
}