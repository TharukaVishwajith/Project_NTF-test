namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player
{
    partial class PlayerManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerManageForm));
            this.searchBtn = new System.Windows.Forms.Button();
            this.addCoursesBtn = new System.Windows.Forms.Button();
            this.addMatchesBtn = new System.Windows.Forms.Button();
            this.courseViewBtn = new System.Windows.Forms.Button();
            this.athleticIdText = new System.Windows.Forms.TextBox();
            this.viewMatchesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchBtn.Location = new System.Drawing.Point(319, 13);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(36, 41);
            this.searchBtn.TabIndex = 26;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addCoursesBtn
            // 
            this.addCoursesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addCoursesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addCoursesBtn.Location = new System.Drawing.Point(495, 217);
            this.addCoursesBtn.Name = "addCoursesBtn";
            this.addCoursesBtn.Size = new System.Drawing.Size(140, 28);
            this.addCoursesBtn.TabIndex = 25;
            this.addCoursesBtn.Text = "Add Courses";
            this.addCoursesBtn.UseVisualStyleBackColor = false;
            this.addCoursesBtn.Click += new System.EventHandler(this.addCoursesBtn_Click);
            // 
            // addMatchesBtn
            // 
            this.addMatchesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addMatchesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addMatchesBtn.Location = new System.Drawing.Point(104, 217);
            this.addMatchesBtn.Name = "addMatchesBtn";
            this.addMatchesBtn.Size = new System.Drawing.Size(140, 28);
            this.addMatchesBtn.TabIndex = 24;
            this.addMatchesBtn.Text = "Add Maches";
            this.addMatchesBtn.UseVisualStyleBackColor = false;
            this.addMatchesBtn.Click += new System.EventHandler(this.addMatchesBtn_Click);
            // 
            // courseViewBtn
            // 
            this.courseViewBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.courseViewBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.courseViewBtn.Location = new System.Drawing.Point(140, 136);
            this.courseViewBtn.Name = "courseViewBtn";
            this.courseViewBtn.Size = new System.Drawing.Size(81, 28);
            this.courseViewBtn.TabIndex = 23;
            this.courseViewBtn.Text = "View";
            this.courseViewBtn.UseVisualStyleBackColor = false;
            this.courseViewBtn.Click += new System.EventHandler(this.courseViewBtn_Click);
            // 
            // athleticIdText
            // 
            this.athleticIdText.Location = new System.Drawing.Point(173, 23);
            this.athleticIdText.Name = "athleticIdText";
            this.athleticIdText.Size = new System.Drawing.Size(100, 20);
            this.athleticIdText.TabIndex = 20;
            this.athleticIdText.TextChanged += new System.EventHandler(this.athleticIdText_TextChanged);
            // 
            // viewMatchesBtn
            // 
            this.viewMatchesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.viewMatchesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewMatchesBtn.Location = new System.Drawing.Point(526, 136);
            this.viewMatchesBtn.Name = "viewMatchesBtn";
            this.viewMatchesBtn.Size = new System.Drawing.Size(81, 28);
            this.viewMatchesBtn.TabIndex = 27;
            this.viewMatchesBtn.Text = "View";
            this.viewMatchesBtn.UseVisualStyleBackColor = false;
            this.viewMatchesBtn.Click += new System.EventHandler(this.viewMatchesBtn_Click);
            // 
            // PlayerManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectNTF.Properties.Resources.PlayerForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(755, 288);
            this.Controls.Add(this.viewMatchesBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addCoursesBtn);
            this.Controls.Add(this.addMatchesBtn);
            this.Controls.Add(this.courseViewBtn);
            this.Controls.Add(this.athleticIdText);
            this.Name = "PlayerManageForm";
            this.Text = "Player Manage Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addCoursesBtn;
        private System.Windows.Forms.Button addMatchesBtn;
        private System.Windows.Forms.Button courseViewBtn;
        private System.Windows.Forms.TextBox athleticIdText;
        private System.Windows.Forms.Button viewMatchesBtn;
    }
}