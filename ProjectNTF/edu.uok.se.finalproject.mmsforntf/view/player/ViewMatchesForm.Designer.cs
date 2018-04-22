namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player
{
    partial class ViewMatchesForm
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
            this.components = new System.ComponentModel.Container();
            this.matchesGridView = new System.Windows.Forms.DataGridView();
            this.teakwondo_dbDataSet = new ProjectNTF.teakwondo_dbDataSet();
            this.teakwondodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teakwondodbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.athleticIdText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondo_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondodbDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // matchesGridView
            // 
            this.matchesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.matchesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesGridView.Location = new System.Drawing.Point(8, 84);
            this.matchesGridView.Name = "matchesGridView";
            this.matchesGridView.Size = new System.Drawing.Size(532, 270);
            this.matchesGridView.TabIndex = 0;
            // 
            // teakwondo_dbDataSet
            // 
            this.teakwondo_dbDataSet.DataSetName = "teakwondo_dbDataSet";
            this.teakwondo_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teakwondodbDataSetBindingSource
            // 
            this.teakwondodbDataSetBindingSource.DataSource = this.teakwondo_dbDataSet;
            this.teakwondodbDataSetBindingSource.Position = 0;
            // 
            // teakwondodbDataSetBindingSource1
            // 
            this.teakwondodbDataSetBindingSource1.DataSource = this.teakwondo_dbDataSet;
            this.teakwondodbDataSetBindingSource1.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Athletic ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // athleticIdText
            // 
            this.athleticIdText.AutoSize = true;
            this.athleticIdText.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold);
            this.athleticIdText.Location = new System.Drawing.Point(257, 31);
            this.athleticIdText.Name = "athleticIdText";
            this.athleticIdText.Size = new System.Drawing.Size(14, 19);
            this.athleticIdText.TabIndex = 2;
            this.athleticIdText.Text = "-";
            this.athleticIdText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 356);
            this.Controls.Add(this.athleticIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchesGridView);
            this.Name = "ViewMatchesForm";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.ViewMatchesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondo_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondodbDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matchesGridView;
        private teakwondo_dbDataSet teakwondo_dbDataSet;
        private System.Windows.Forms.BindingSource teakwondodbDataSetBindingSource;
        private System.Windows.Forms.BindingSource teakwondodbDataSetBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label athleticIdText;
    }
}