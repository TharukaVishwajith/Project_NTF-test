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

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player
{
    public partial class PlayerManageForm : Form
    {
        bool isEnable;

        public PlayerManageForm()
        {
            InitializeComponent();
        }
        
        public PlayerManageForm(bool isEnable)
        {
            this.isEnable = isEnable;

            InitializeComponent();
            if (!isEnable)
            {
               
                viewMatchesBtn.Enabled = false;
                courseViewBtn.Enabled = false;
                addMatchesBtn.Enabled = false;
                addCoursesBtn.Enabled = false;
            }
        }
        public PlayerManageForm(String id)
        {
           
            InitializeComponent();
            athleticIdText.Text = id;
            athleticIdText.Enabled = false;
        }

        private void localMatchBtn_Click(object sender, EventArgs e)
        {
           // AddPlayedMatches addMatches = new AddPlayedMatches();
           // addMatches.Show();
        }

        private void addMatchesBtn_Click(object sender, EventArgs e)
        {
            if(athleticIdText.Text != "")
            {
                AddPlayedMatches addPlayedMatches = new AddPlayedMatches(athleticIdText.Text);
                addPlayedMatches.Show();
            }           
        }

        private void addCoursesBtn_Click(object sender, EventArgs e)
        {
            AddCourses addCourses = new AddCourses(athleticIdText.Text);
            addCourses.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Member m = null;
            try
            {
               m = MemberController.SearchMemberByAthleticId(athleticIdText.Text);
            }catch(Exception ex)
            {

            }

            if (athleticIdText.Text == "")
            {
                MessageBox.Show("Enter ahtletic id to search.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (m == null)
                {
                MessageBox.Show(athleticIdText.Text + " is not a member of Nationl Taekwondo Federation!", "Message", MessageBoxButtons.OK);
                return;
                }

            if (!isEnable)
            {

                viewMatchesBtn.Enabled = true;
                courseViewBtn.Enabled = true;
                addMatchesBtn.Enabled = true;
                addCoursesBtn.Enabled = true;
            }
           

        }

        private void athleticIdText_TextChanged(object sender, EventArgs e)
        {
            if(athleticIdText.Text == "")
            {
               
                viewMatchesBtn.Enabled = false;
                courseViewBtn.Enabled = false;
                addMatchesBtn.Enabled = false;
                addCoursesBtn.Enabled = false;
            }
        }

        private void viewMatchesBtn_Click(object sender, EventArgs e)
        {
            new ViewMatchesForm(athleticIdText.Text).Show();
        }

        private void courseViewBtn_Click(object sender, EventArgs e)
        {
            new ViewCoacherForm(athleticIdText.Text).Show();
        }
    }
}
