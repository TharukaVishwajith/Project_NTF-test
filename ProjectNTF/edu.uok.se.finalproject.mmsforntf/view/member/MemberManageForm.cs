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

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.member
{
    public partial class MemberManageForm : Form
    {
        public MemberManageForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String fullName = fullNameText.Text;
            String nameWithInitials = nameWithInText.Text;
            String nic = nicText.Text;
            String dob = dobText.Text;
            String address = addressText.Text;
            String athleticId = athleticIdText.Text;
            String mobile = mobileNoText.Text;
            String tel = telNoText.Text;
            String email = emailText.Text;
            String occupation = occupationText.Text;
            String kukkiwonNo = kukkiwonNoText.Text;
            String dan = dangupText.Text;
            String belt = beltText.Text;
            String club = clubText.Text;
            String coacher = coacherText.Text;

            try
            {
                string[] dateformat = dob.Split('/');
                dob = dateformat[2] + "-" + dateformat[0] + "-" + dateformat[1];

                Member member = new Member(athleticId, fullName, nameWithInitials, dob, nic, address, Int32.Parse(tel), Int32.Parse(mobile), occupation, email, dan, kukkiwonNo, belt, club, coacher);

                MemberController.AddMember(member);
                MessageBox.Show("Member added success..!", "TVS", MessageBoxButtons.OK);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }
    }
}
