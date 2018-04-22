namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view
{
    partial class AdminManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageForm));
            this.memberBtn = new System.Windows.Forms.Button();
            this.addAdminBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.memberSearchBtn = new System.Windows.Forms.Button();
            this.searchMemberText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberBtn
            // 
            this.memberBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.memberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.memberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.memberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.memberBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.memberBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberBtn.Location = new System.Drawing.Point(25, 234);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(191, 37);
            this.memberBtn.TabIndex = 30;
            this.memberBtn.Text = "Get Administrators List";
            this.memberBtn.UseVisualStyleBackColor = false;
            // 
            // addAdminBtn
            // 
            this.addAdminBtn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.addAdminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addAdminBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.addAdminBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addAdminBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.addAdminBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAdminBtn.Location = new System.Drawing.Point(25, 69);
            this.addAdminBtn.Name = "addAdminBtn";
            this.addAdminBtn.Size = new System.Drawing.Size(191, 37);
            this.addAdminBtn.TabIndex = 31;
            this.addAdminBtn.Text = "Add New Administrator";
            this.addAdminBtn.UseVisualStyleBackColor = false;
            this.addAdminBtn.Click += new System.EventHandler(this.addAdminBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(25, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 34);
            this.button2.TabIndex = 32;
            this.button2.Text = "Remove Administrator";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(25, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 34);
            this.button3.TabIndex = 33;
            this.button3.Text = "Update Administrator";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(495, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 295);
            this.panel1.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 257);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.memberSearchBtn);
            this.searchPanel.Controls.Add(this.searchMemberText);
            this.searchPanel.Location = new System.Drawing.Point(216, 49);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(239, 72);
            this.searchPanel.TabIndex = 44;
            this.searchPanel.Visible = false;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 10);
            this.label6.TabIndex = 45;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-6, -9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 10);
            this.label3.TabIndex = 44;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // memberSearchBtn
            // 
            this.memberSearchBtn.BackColor = System.Drawing.Color.White;
            this.memberSearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memberSearchBtn.BackgroundImage")));
            this.memberSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.memberSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memberSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.memberSearchBtn.Location = new System.Drawing.Point(187, 13);
            this.memberSearchBtn.Name = "memberSearchBtn";
            this.memberSearchBtn.Size = new System.Drawing.Size(36, 41);
            this.memberSearchBtn.TabIndex = 38;
            this.memberSearchBtn.UseVisualStyleBackColor = false;
            this.memberSearchBtn.Click += new System.EventHandler(this.memberSearchBtn_Click);
            // 
            // searchMemberText
            // 
            this.searchMemberText.Location = new System.Drawing.Point(25, 25);
            this.searchMemberText.Name = "searchMemberText";
            this.searchMemberText.Size = new System.Drawing.Size(148, 20);
            this.searchMemberText.TabIndex = 37;
            // 
            // AdminManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 437);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAdminBtn);
            this.Controls.Add(this.memberBtn);
            this.Name = "AdminManageForm";
            this.Text = "AdminManageForm";
            this.Load += new System.EventHandler(this.AdminManageForm_Load);
            this.Click += new System.EventHandler(this.AdminManageForm_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button addAdminBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button memberSearchBtn;
        private System.Windows.Forms.TextBox searchMemberText;
    }
}