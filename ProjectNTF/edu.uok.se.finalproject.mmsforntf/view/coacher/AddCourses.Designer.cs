namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher
{
    partial class AddCourses
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
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.venueTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.member_athleticIdTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(217, 143);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.courseNameTextBox.TabIndex = 52;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(217, 94);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(200, 21);
            this.countryComboBox.TabIndex = 53;
            // 
            // venueTextBox
            // 
            this.venueTextBox.Location = new System.Drawing.Point(217, 192);
            this.venueTextBox.Name = "venueTextBox";
            this.venueTextBox.Size = new System.Drawing.Size(200, 20);
            this.venueTextBox.TabIndex = 54;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(217, 312);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker.TabIndex = 55;
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.Location = new System.Drawing.Point(217, 237);
            this.discriptionTextBox.Multiline = true;
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(200, 65);
            this.discriptionTextBox.TabIndex = 56;
            // 
            // member_athleticIdTextBox
            // 
            this.member_athleticIdTextBox.Enabled = false;
            this.member_athleticIdTextBox.Location = new System.Drawing.Point(325, 23);
            this.member_athleticIdTextBox.Name = "member_athleticIdTextBox";
            this.member_athleticIdTextBox.Size = new System.Drawing.Size(161, 20);
            this.member_athleticIdTextBox.TabIndex = 57;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addBtn.Location = new System.Drawing.Point(323, 374);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(81, 28);
            this.addBtn.TabIndex = 51;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectNTF.Properties.Resources.AddCoureseForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(720, 415);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.venueTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(this.member_athleticIdTextBox);
            this.Controls.Add(this.addBtn);
            this.Name = "AddCourses";
            this.Text = "AddCourses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.TextBox venueTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.TextBox member_athleticIdTextBox;
        private System.Windows.Forms.Button addBtn;
    }
}