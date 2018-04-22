using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.member;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher
{
    public partial class CoacherManageForm : Form
    {
        Member member = null;
        Member student = null;
        String selectedStudent = null;

        public CoacherManageForm()
        {
            InitializeComponent();
        }
        
        public CoacherManageForm(Member member)
        {
            InitializeComponent();
            nameText.Text = member.NamewithInitials;
            this.member = member;
            addNationalStudentBtn.Enabled = false;
            //viewDetailsBtn.Enabled = false;

        }

        private void addCoursesBtn_Click(object sender, EventArgs e)
        {
            AddCourses addCourses = new AddCourses(member.AthleticId,this);
            
            addCourses.Show();
        }

        private void addWorkedPlacesBtn_Click(object sender, EventArgs e)
        {
            AddPlaces addPlaces = new AddPlaces(member.AthleticId,this);
            addPlaces.Show();
        }

        private void addNationalStudentBtn_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                try
                {
                    CoacherController.AddLocalStudent(student.AthleticId, member.AthleticId);
                    
                    MessageBox.Show("Student added success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                try
                {
                    nationalStudentGridView.DataSource = CoacherController.GetLocalStudents(member.AthleticId, StudentSelectType.Under_Coacher);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(instructorLevelText.Text == "")
                {
                    CoacherController.AddNewCoacher(instructorLevelText.Text, member.AthleticId);
                    MessageBox.Show("Coacher added success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    CoacherController.UpdateCoacher(instructorLevelText.Text, member.AthleticId);
                    MessageBox.Show("Coacher updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void CoacherManageForm_Load(object sender, EventArgs e)
        {
            try
            {
                instructorLevelText.Text = CoacherController.SearchCoacher(member.AthleticId);
                LoadData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }
        
        public void LoadData()
        {
            coursesTable.DataSource = CoacherController.GetCourses(member.AthleticId, CoacherCourseType.All);
            workedPlacesGridView.DataSource = CoacherController.GetWorkedPlaces(member.AthleticId);
            internationalStudentDataGridView.DataSource = CoacherController.GetForignStudents(member.AthleticId, StudentSelectType.Under_Coacher);
            nationalStudentGridView.DataSource = CoacherController.GetLocalStudents(member.AthleticId, StudentSelectType.Under_Coacher);

        }

        private void addInternationalStudentBtn_Click(object sender, EventArgs e)
        {
            AddInternationalStudent addInternationalStudent = new AddInternationalStudent(member.AthleticId, this);
            addInternationalStudent.Show();
        }

        private void seachMemberBtn_Click(object sender, EventArgs e)
        {

            try
            {
                 student = MemberController.SearchMemberByAthleticId(searchMemberText.Text);
                if (student != null)
                {
                    MessageBox.Show("Member Found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    addNationalStudentBtn.Enabled = true;
                    viewDetailsBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Member Not Found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchMemberText_TextChanged(object sender, EventArgs e)
        {
            if(searchMemberText.Text == "")
            {
                student = null;
                addNationalStudentBtn.Enabled = false;
               // viewDetailsBtn.Enabled = false;
            }
        }

        private void viewDetailsBtn_Click(object sender, EventArgs e)
        {
            if (addNationalStudentBtn.Enabled)
            {
                new MemberViewAndUpdate(student).Show();
            }
            else
            {
                if(selectedStudent != "")
                {
                    new MemberViewAndUpdate(MemberController.SearchMemberByAthleticId(selectedStudent)).Show();
                }     
            }
        }

        private void nationalStudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchMemberText.Clear();
            addNationalStudentBtn.Enabled = false;

            int selectedrowindex = nationalStudentGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = nationalStudentGridView.Rows[selectedrowindex];
            selectedStudent = Convert.ToString(selectedRow.Cells[0].Value);

        }

        private void nationalStudentGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewDetailsBtn.PerformClick();
        }

        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = coursesTable.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = coursesTable.Rows[selectedrowindex];

            try
            {
                CoacherController.DeleteCourses(Convert.ToString(selectedRow.Cells[0].Value), Convert.ToString(selectedRow.Cells[1].Value), Convert.ToString(selectedRow.Cells[3].Value),member.AthleticId);
                coursesTable.DataSource = CoacherController.GetCourses(member.AthleticId, CoacherCourseType.All);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteWorkedPlacesBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = workedPlacesGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = workedPlacesGridView.Rows[selectedrowindex];
            WorkedPlace wp;
            try
            {
                 wp = new WorkedPlace(Convert.ToString(selectedRow.Cells[0].Value), Convert.ToString(selectedRow.Cells[1].Value), Convert.ToString(selectedRow.Cells[2].Value), Convert.ToString(selectedRow.Cells[3].Value));
            }
            catch
            {
                return;
            }
            try
            {
                CoacherController.DeleteWorkedPlace(wp);
                workedPlacesGridView.DataSource = CoacherController.GetWorkedPlaces(member.AthleticId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteInternationalStudentBtn_Click(object sender, EventArgs e)
        {

            int selectedrowindex = internationalStudentDataGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = internationalStudentDataGridView.Rows[selectedrowindex];
            ForignStudent fs = new ForignStudent(Convert.ToString(selectedRow.Cells[0].Value), Convert.ToString(selectedRow.Cells[1].Value), Convert.ToString(selectedRow.Cells[2].Value),member.AthleticId);
            try
            {
                CoacherController.DeleteForignStudent(fs);
                internationalStudentDataGridView.DataSource = CoacherController.GetForignStudents(member.AthleticId, StudentSelectType.Under_Coacher);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void deleteNationalStudentBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = nationalStudentGridView.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = nationalStudentGridView.Rows[selectedrowindex];
           
            try
            {
                CoacherController.DeleteLocalStudent(Convert.ToString(selectedRow.Cells[0].Value),member.AthleticId);
                nationalStudentGridView.DataSource = CoacherController.GetLocalStudents(member.AthleticId, StudentSelectType.Under_Coacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
