namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player
{
    partial class ViewCoacherForm
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
            this.athleticIdText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.matchesGridView = new System.Windows.Forms.DataGridView();
            this.internationlCoureseGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationlCoureseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // athleticIdText
            // 
            this.athleticIdText.AutoSize = true;
            this.athleticIdText.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.athleticIdText.Location = new System.Drawing.Point(600, 21);
            this.athleticIdText.Name = "athleticIdText";
            this.athleticIdText.Size = new System.Drawing.Size(14, 19);
            this.athleticIdText.TabIndex = 5;
            this.athleticIdText.Text = "-";
            this.athleticIdText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(506, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Athletic ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchesGridView
            // 
            this.matchesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matchesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesGridView.Location = new System.Drawing.Point(12, 88);
            this.matchesGridView.Name = "matchesGridView";
            this.matchesGridView.Size = new System.Drawing.Size(532, 270);
            this.matchesGridView.TabIndex = 3;
            // 
            // internationlCoureseGridView
            // 
            this.internationlCoureseGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.internationlCoureseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.internationlCoureseGridView.Location = new System.Drawing.Point(565, 88);
            this.internationlCoureseGridView.Name = "internationlCoureseGridView";
            this.internationlCoureseGridView.Size = new System.Drawing.Size(532, 270);
            this.internationlCoureseGridView.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "National Matches";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "International Matches";
            // 
            // ViewCoacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.internationlCoureseGridView);
            this.Controls.Add(this.athleticIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchesGridView);
            this.Name = "ViewCoacherForm";
            this.Text = "Played Matches";
            this.Load += new System.EventHandler(this.ViewCoacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationlCoureseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label athleticIdText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView matchesGridView;
        private System.Windows.Forms.DataGridView internationlCoureseGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}