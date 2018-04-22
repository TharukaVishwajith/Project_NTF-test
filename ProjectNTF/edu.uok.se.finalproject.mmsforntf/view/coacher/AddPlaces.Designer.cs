namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher
{
    partial class AddPlaces
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
            this.startedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.workedPlaceText = new System.Windows.Forms.TextBox();
            this.addPlacesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(332, 24);
            this.IdText.Name = "IdText";
            this.IdText.ReadOnly = true;
            this.IdText.Size = new System.Drawing.Size(146, 20);
            this.IdText.TabIndex = 45;
            // 
            // startedDatePicker
            // 
            this.startedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startedDatePicker.Location = new System.Drawing.Point(237, 142);
            this.startedDatePicker.Name = "startedDatePicker";
            this.startedDatePicker.Size = new System.Drawing.Size(106, 20);
            this.startedDatePicker.TabIndex = 44;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(237, 189);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(106, 20);
            this.endDatePicker.TabIndex = 43;
            // 
            // workedPlaceText
            // 
            this.workedPlaceText.Location = new System.Drawing.Point(237, 93);
            this.workedPlaceText.Name = "workedPlaceText";
            this.workedPlaceText.Size = new System.Drawing.Size(251, 20);
            this.workedPlaceText.TabIndex = 42;
            // 
            // addPlacesBtn
            // 
            this.addPlacesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addPlacesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addPlacesBtn.Location = new System.Drawing.Point(312, 241);
            this.addPlacesBtn.Name = "addPlacesBtn";
            this.addPlacesBtn.Size = new System.Drawing.Size(81, 28);
            this.addPlacesBtn.TabIndex = 41;
            this.addPlacesBtn.Text = "Add";
            this.addPlacesBtn.UseVisualStyleBackColor = false;
            this.addPlacesBtn.Click += new System.EventHandler(this.addPlacesBtn_Click);
            // 
            // AddPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectNTF.Properties.Resources.addPlaces1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(707, 289);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.startedDatePicker);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.workedPlaceText);
            this.Controls.Add(this.addPlacesBtn);
            this.Name = "AddPlaces";
            this.Text = "AddPlaces";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.DateTimePicker startedDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.TextBox workedPlaceText;
        private System.Windows.Forms.Button addPlacesBtn;
    }
}