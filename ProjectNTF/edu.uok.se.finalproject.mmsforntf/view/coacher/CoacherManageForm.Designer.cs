namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher
{
    partial class CoacherManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoacherManageForm));
            this.seachMemberBtn = new System.Windows.Forms.Button();
            this.searchMemberText = new System.Windows.Forms.TextBox();
            this.deleteWorkedPlacesBtn = new System.Windows.Forms.Button();
            this.addWorkedPlacesBtn = new System.Windows.Forms.Button();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.addCoursesBtn = new System.Windows.Forms.Button();
            this.deleteInternationalStudentBtn = new System.Windows.Forms.Button();
            this.worked_placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teakwondo_dbDataSet = new ProjectNTF.teakwondo_dbDataSet();
            this.addInternationalStudentBtn = new System.Windows.Forms.Button();
            this.worked_placesTableAdapter = new ProjectNTF.teakwondo_dbDataSetTableAdapters.worked_placesTableAdapter();
            this.nationallevelstudentTableAdapter = new ProjectNTF.teakwondo_dbDataSetTableAdapters.nationallevelstudentTableAdapter();
            this.nationallevelstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ProjectNTF.teakwondo_dbDataSetTableAdapters.TableAdapterManager();
            this.deleteNationalStudentBtn = new System.Windows.Forms.Button();
            this.teakwondodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateBtn = new System.Windows.Forms.Button();
            this.instructorLevelText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.viewDetailsBtn = new System.Windows.Forms.Button();
            this.addNationalStudentBtn = new System.Windows.Forms.Button();
            this.coursesTable = new System.Windows.Forms.DataGridView();
            this.workedPlacesGridView = new System.Windows.Forms.DataGridView();
            this.internationalStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.nationalStudentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.worked_placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondo_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationallevelstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondodbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workedPlacesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalStudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalStudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // seachMemberBtn
            // 
            this.seachMemberBtn.BackColor = System.Drawing.Color.Navy;
            this.seachMemberBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.seachMemberBtn.Location = new System.Drawing.Point(798, 474);
            this.seachMemberBtn.Name = "seachMemberBtn";
            this.seachMemberBtn.Size = new System.Drawing.Size(57, 28);
            this.seachMemberBtn.TabIndex = 46;
            this.seachMemberBtn.Text = "Search";
            this.seachMemberBtn.UseVisualStyleBackColor = false;
            this.seachMemberBtn.Click += new System.EventHandler(this.seachMemberBtn_Click);
            // 
            // searchMemberText
            // 
            this.searchMemberText.Location = new System.Drawing.Point(762, 448);
            this.searchMemberText.Name = "searchMemberText";
            this.searchMemberText.Size = new System.Drawing.Size(139, 20);
            this.searchMemberText.TabIndex = 43;
            this.searchMemberText.TextChanged += new System.EventHandler(this.searchMemberText_TextChanged);
            // 
            // deleteWorkedPlacesBtn
            // 
            this.deleteWorkedPlacesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteWorkedPlacesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteWorkedPlacesBtn.Location = new System.Drawing.Point(752, 323);
            this.deleteWorkedPlacesBtn.Name = "deleteWorkedPlacesBtn";
            this.deleteWorkedPlacesBtn.Size = new System.Drawing.Size(81, 28);
            this.deleteWorkedPlacesBtn.TabIndex = 42;
            this.deleteWorkedPlacesBtn.Text = "Delete";
            this.deleteWorkedPlacesBtn.UseVisualStyleBackColor = false;
            this.deleteWorkedPlacesBtn.Click += new System.EventHandler(this.deleteWorkedPlacesBtn_Click);
            // 
            // addWorkedPlacesBtn
            // 
            this.addWorkedPlacesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addWorkedPlacesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addWorkedPlacesBtn.Location = new System.Drawing.Point(646, 323);
            this.addWorkedPlacesBtn.Name = "addWorkedPlacesBtn";
            this.addWorkedPlacesBtn.Size = new System.Drawing.Size(81, 28);
            this.addWorkedPlacesBtn.TabIndex = 41;
            this.addWorkedPlacesBtn.Text = "Add";
            this.addWorkedPlacesBtn.UseVisualStyleBackColor = false;
            this.addWorkedPlacesBtn.Click += new System.EventHandler(this.addWorkedPlacesBtn_Click);
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteCourseBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteCourseBtn.Location = new System.Drawing.Point(261, 323);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(81, 28);
            this.deleteCourseBtn.TabIndex = 40;
            this.deleteCourseBtn.Text = "Delete";
            this.deleteCourseBtn.UseVisualStyleBackColor = false;
            this.deleteCourseBtn.Click += new System.EventHandler(this.deleteCourseBtn_Click);
            // 
            // addCoursesBtn
            // 
            this.addCoursesBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addCoursesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addCoursesBtn.Location = new System.Drawing.Point(165, 323);
            this.addCoursesBtn.Name = "addCoursesBtn";
            this.addCoursesBtn.Size = new System.Drawing.Size(81, 28);
            this.addCoursesBtn.TabIndex = 39;
            this.addCoursesBtn.Text = "Add";
            this.addCoursesBtn.UseVisualStyleBackColor = false;
            this.addCoursesBtn.Click += new System.EventHandler(this.addCoursesBtn_Click);
            // 
            // deleteInternationalStudentBtn
            // 
            this.deleteInternationalStudentBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteInternationalStudentBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteInternationalStudentBtn.Location = new System.Drawing.Point(266, 615);
            this.deleteInternationalStudentBtn.Name = "deleteInternationalStudentBtn";
            this.deleteInternationalStudentBtn.Size = new System.Drawing.Size(81, 28);
            this.deleteInternationalStudentBtn.TabIndex = 38;
            this.deleteInternationalStudentBtn.Text = "Delete";
            this.deleteInternationalStudentBtn.UseVisualStyleBackColor = false;
            this.deleteInternationalStudentBtn.Click += new System.EventHandler(this.deleteInternationalStudentBtn_Click);
            // 
            // teakwondo_dbDataSet
            // 
            this.teakwondo_dbDataSet.DataSetName = "teakwondo_dbDataSet";
            this.teakwondo_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addInternationalStudentBtn
            // 
            this.addInternationalStudentBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addInternationalStudentBtn.ForeColor = System.Drawing.Color.Honeydew;
            this.addInternationalStudentBtn.Location = new System.Drawing.Point(170, 615);
            this.addInternationalStudentBtn.Name = "addInternationalStudentBtn";
            this.addInternationalStudentBtn.Size = new System.Drawing.Size(81, 28);
            this.addInternationalStudentBtn.TabIndex = 37;
            this.addInternationalStudentBtn.Text = "Add";
            this.addInternationalStudentBtn.UseVisualStyleBackColor = false;
            this.addInternationalStudentBtn.Click += new System.EventHandler(this.addInternationalStudentBtn_Click);
            // 
            // worked_placesTableAdapter
            // 
            this.worked_placesTableAdapter.ClearBeforeFill = true;
            // 
            // nationallevelstudentTableAdapter
            // 
            this.nationallevelstudentTableAdapter.ClearBeforeFill = true;
            // 
            // nationallevelstudentBindingSource
            // 
            this.nationallevelstudentBindingSource.DataMember = "nationallevelstudent";
            this.nationallevelstudentBindingSource.DataSource = this.teakwondo_dbDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coacher_coursesTableAdapter = null;
            this.tableAdapterManager.coacherTableAdapter = null;
            this.tableAdapterManager.internationalstudentTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.nationallevelstudentTableAdapter = this.nationallevelstudentTableAdapter;
            this.tableAdapterManager.player_coursesTableAdapter = null;
            this.tableAdapterManager.player_international_matchesTableAdapter = null;
            this.tableAdapterManager.player_local_matchesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectNTF.teakwondo_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.worked_placesTableAdapter = this.worked_placesTableAdapter;
            // 
            // deleteNationalStudentBtn
            // 
            this.deleteNationalStudentBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.deleteNationalStudentBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteNationalStudentBtn.Location = new System.Drawing.Point(837, 533);
            this.deleteNationalStudentBtn.Name = "deleteNationalStudentBtn";
            this.deleteNationalStudentBtn.Size = new System.Drawing.Size(81, 28);
            this.deleteNationalStudentBtn.TabIndex = 36;
            this.deleteNationalStudentBtn.Text = "Delete";
            this.deleteNationalStudentBtn.UseVisualStyleBackColor = false;
            this.deleteNationalStudentBtn.Click += new System.EventHandler(this.deleteNationalStudentBtn_Click);
            // 
            // teakwondodbDataSetBindingSource
            // 
            this.teakwondodbDataSetBindingSource.DataSource = this.teakwondo_dbDataSet;
            this.teakwondodbDataSetBindingSource.Position = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updateBtn.Location = new System.Drawing.Point(689, 52);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(166, 28);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "Update Coacher Details";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // instructorLevelText
            // 
            this.instructorLevelText.Location = new System.Drawing.Point(335, 68);
            this.instructorLevelText.Name = "instructorLevelText";
            this.instructorLevelText.Size = new System.Drawing.Size(144, 20);
            this.instructorLevelText.TabIndex = 33;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(335, 27);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(271, 20);
            this.nameText.TabIndex = 32;
            // 
            // viewDetailsBtn
            // 
            this.viewDetailsBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.viewDetailsBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewDetailsBtn.Location = new System.Drawing.Point(608, 615);
            this.viewDetailsBtn.Name = "viewDetailsBtn";
            this.viewDetailsBtn.Size = new System.Drawing.Size(81, 28);
            this.viewDetailsBtn.TabIndex = 31;
            this.viewDetailsBtn.Text = "View Details";
            this.viewDetailsBtn.UseVisualStyleBackColor = false;
            this.viewDetailsBtn.Click += new System.EventHandler(this.viewDetailsBtn_Click);
            // 
            // addNationalStudentBtn
            // 
            this.addNationalStudentBtn.BackColor = System.Drawing.Color.SlateGray;
            this.addNationalStudentBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addNationalStudentBtn.Location = new System.Drawing.Point(740, 533);
            this.addNationalStudentBtn.Name = "addNationalStudentBtn";
            this.addNationalStudentBtn.Size = new System.Drawing.Size(81, 28);
            this.addNationalStudentBtn.TabIndex = 35;
            this.addNationalStudentBtn.Text = "Add";
            this.addNationalStudentBtn.UseVisualStyleBackColor = false;
            this.addNationalStudentBtn.Click += new System.EventHandler(this.addNationalStudentBtn_Click);
            // 
            // coursesTable
            // 
            this.coursesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.coursesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.coursesTable.Location = new System.Drawing.Point(34, 131);
            this.coursesTable.Name = "coursesTable";
            this.coursesTable.Size = new System.Drawing.Size(445, 186);
            this.coursesTable.TabIndex = 47;
            // 
            // workedPlacesGridView
            // 
            this.workedPlacesGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workedPlacesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workedPlacesGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.workedPlacesGridView.Location = new System.Drawing.Point(562, 131);
            this.workedPlacesGridView.Name = "workedPlacesGridView";
            this.workedPlacesGridView.Size = new System.Drawing.Size(356, 186);
            this.workedPlacesGridView.TabIndex = 48;
            // 
            // internationalStudentDataGridView
            // 
            this.internationalStudentDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.internationalStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.internationalStudentDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.internationalStudentDataGridView.Location = new System.Drawing.Point(78, 412);
            this.internationalStudentDataGridView.Name = "internationalStudentDataGridView";
            this.internationalStudentDataGridView.Size = new System.Drawing.Size(356, 186);
            this.internationalStudentDataGridView.TabIndex = 49;
            // 
            // nationalStudentGridView
            // 
            this.nationalStudentGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nationalStudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nationalStudentGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.nationalStudentGridView.Location = new System.Drawing.Point(580, 412);
            this.nationalStudentGridView.Name = "nationalStudentGridView";
            this.nationalStudentGridView.Size = new System.Drawing.Size(147, 186);
            this.nationalStudentGridView.TabIndex = 50;
            this.nationalStudentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nationalStudentGridView_CellContentClick);
            this.nationalStudentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nationalStudentGridView_CellContentClick);
            this.nationalStudentGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nationalStudentGridView_CellDoubleClick);
            // 
            // CoacherManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 675);
            this.Controls.Add(this.nationalStudentGridView);
            this.Controls.Add(this.internationalStudentDataGridView);
            this.Controls.Add(this.workedPlacesGridView);
            this.Controls.Add(this.coursesTable);
            this.Controls.Add(this.seachMemberBtn);
            this.Controls.Add(this.searchMemberText);
            this.Controls.Add(this.deleteWorkedPlacesBtn);
            this.Controls.Add(this.addWorkedPlacesBtn);
            this.Controls.Add(this.deleteCourseBtn);
            this.Controls.Add(this.addCoursesBtn);
            this.Controls.Add(this.deleteInternationalStudentBtn);
            this.Controls.Add(this.addInternationalStudentBtn);
            this.Controls.Add(this.deleteNationalStudentBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.instructorLevelText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.viewDetailsBtn);
            this.Controls.Add(this.addNationalStudentBtn);
            this.Name = "CoacherManageForm";
            this.Text = "CoacherManageForm";
            this.Load += new System.EventHandler(this.CoacherManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worked_placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondo_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationallevelstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teakwondodbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workedPlacesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalStudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalStudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seachMemberBtn;
        private System.Windows.Forms.TextBox searchMemberText;
        private System.Windows.Forms.Button deleteWorkedPlacesBtn;
        private System.Windows.Forms.Button addWorkedPlacesBtn;
        private System.Windows.Forms.Button deleteCourseBtn;
        private System.Windows.Forms.Button addCoursesBtn;
        private System.Windows.Forms.Button deleteInternationalStudentBtn;
        private System.Windows.Forms.BindingSource worked_placesBindingSource;
        private teakwondo_dbDataSet teakwondo_dbDataSet;
        private System.Windows.Forms.Button addInternationalStudentBtn;
        private teakwondo_dbDataSetTableAdapters.worked_placesTableAdapter worked_placesTableAdapter;
        private teakwondo_dbDataSetTableAdapters.nationallevelstudentTableAdapter nationallevelstudentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource nationallevelstudentBindingSource;
        private teakwondo_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button deleteNationalStudentBtn;
        private System.Windows.Forms.BindingSource teakwondodbDataSetBindingSource;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox instructorLevelText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button viewDetailsBtn;
        private System.Windows.Forms.Button addNationalStudentBtn;
        private System.Windows.Forms.DataGridView coursesTable;
        private System.Windows.Forms.DataGridView workedPlacesGridView;
        private System.Windows.Forms.DataGridView internationalStudentDataGridView;
        private System.Windows.Forms.DataGridView nationalStudentGridView;
    }
}