namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player
{
    partial class AddPlayedMatches
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
            this.IdText = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.medalText = new System.Windows.Forms.TextBox();
            this.venueText = new System.Windows.Forms.TextBox();
            this.matchNameText = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(335, 20);
            this.IdText.Name = "IdText";
            this.IdText.ReadOnly = true;
            this.IdText.Size = new System.Drawing.Size(146, 20);
            this.IdText.TabIndex = 29;
            this.IdText.TextChanged += new System.EventHandler(this.IdText_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(247, 286);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker.TabIndex = 28;
            // 
            // countryCombo
            // 
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(247, 92);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(121, 21);
            this.countryCombo.TabIndex = 27;
            this.countryCombo.SelectedIndexChanged += new System.EventHandler(this.countryCombo_SelectedIndexChanged);
            // 
            // medalText
            // 
            this.medalText.Location = new System.Drawing.Point(247, 234);
            this.medalText.Name = "medalText";
            this.medalText.Size = new System.Drawing.Size(251, 20);
            this.medalText.TabIndex = 26;
            // 
            // venueText
            // 
            this.venueText.Location = new System.Drawing.Point(247, 185);
            this.venueText.Name = "venueText";
            this.venueText.Size = new System.Drawing.Size(251, 20);
            this.venueText.TabIndex = 25;
            // 
            // matchNameText
            // 
            this.matchNameText.Location = new System.Drawing.Point(247, 139);
            this.matchNameText.Name = "matchNameText";
            this.matchNameText.Size = new System.Drawing.Size(251, 20);
            this.matchNameText.TabIndex = 24;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addBtn.Location = new System.Drawing.Point(311, 331);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(81, 28);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddPlayedMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectNTF.Properties.Resources.AddMatchesForm;
            this.ClientSize = new System.Drawing.Size(745, 377);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.countryCombo);
            this.Controls.Add(this.medalText);
            this.Controls.Add(this.venueText);
            this.Controls.Add(this.matchNameText);
            this.Controls.Add(this.addBtn);
            this.Name = "AddPlayedMatches";
            this.Text = "AddPlayedMatches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.TextBox medalText;
        private System.Windows.Forms.TextBox venueText;
        private System.Windows.Forms.TextBox matchNameText;
        private System.Windows.Forms.Button addBtn;
    }
}