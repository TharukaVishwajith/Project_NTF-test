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
    public partial class MemberViewAndUpdate : Form
    {
        Member member;
        public MemberViewAndUpdate()
        {
            InitializeComponent();
          
            
        }
        public MemberViewAndUpdate(Member me,bool isAdmin)
        {
            InitializeComponent();
            saveBtn.Visible = false;
            deleteBtn.Visible = false;
            makeAdminBtn.Visible = true;
            member = me;
            if (me != null)
            {
                fullNameText.Text = me.FullName;
                nameWithInText.Text = me.NamewithInitials;
                nicText.Text = me.NICNo1;
                dobText.Text = me.Dob;
                addressText.Text = me.Address;
                athleticIdText.Text = me.AthleticId;
                mobileNoText.Text = me.MobileNo.ToString();
                telNoText.Text = me.TelNo.ToString();
                emailText.Text = me.Email;
                occupationText.Text = me.Occupation;
                kukkiwonNoText.Text = me.KukkiwonNo;
                dangupText.Text = me.DANorGUP1;
                beltText.Text = me.Belt;
                clubText.Text = me.Club;
                coacherText.Text = me.Coacher;
            }

        }

        public MemberViewAndUpdate(Member me)
        {
            InitializeComponent();

            if (me != null)
            {
                fullNameText.Text = me.FullName;
                nameWithInText.Text = me.NamewithInitials;
                nicText.Text = me.NICNo1;
                dobText.Text = me.Dob;
                addressText.Text = me.Address;
                athleticIdText.Text = me.AthleticId;
                mobileNoText.Text = me.MobileNo.ToString();
                telNoText.Text = me.TelNo.ToString();
                emailText.Text = me.Email;
                occupationText.Text = me.Occupation;
                kukkiwonNoText.Text = me.KukkiwonNo;
                dangupText.Text = me.DANorGUP1;
                beltText.Text = me.Belt;
                clubText.Text = me.Club;
                coacherText.Text = me.Coacher;
            }
          
        }



        private void MemberViewAndUpdate_Load(object sender, EventArgs e)
        {

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

                MemberController.UpdateMember(member);
                MessageBox.Show("Member details updated..!", "Message", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MemberController.DeleteMember(athleticIdText.Text);
                MessageBox.Show("Member deleted..!", "Message", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

        }

        private void makeAdminBtn_Click(object sender, EventArgs e)
        {
            if (AdminController.SearchAdmin(member.AthleticId) == "" || (AdminController.SearchAdmin(member.AthleticId) == null))
            {
                new AdminLoginForm(member.AthleticId).Show();
            }
        }
    }
}
