using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.member;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;



namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view
{
    public partial class AdminManageForm : Form
    {
        public AdminManageForm()
        {
            InitializeComponent();
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
        }

        private void AdminManageForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminManageForm_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = false;
        }

        private void memberSearchBtn_Click(object sender, EventArgs e)
        {
            Member member = MemberController.SearchMemberByAthleticId(searchMemberText.Text);
            if (searchMemberText.Text != "")
            {
                if (member != null)
                {
                    MemberViewAndUpdate addAdminForm = new MemberViewAndUpdate(member, true);
                    addAdminForm.Show();
                    return;
                }
                MessageBox.Show(searchMemberText.Text + " is not a member of Nationl Taekwondo Federation!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Enter ahtletic id to search.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
