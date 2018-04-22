using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.animation;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.member;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;


namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view
{
    public partial class Home : Form
    {
        Font f;
        Control activeLable;
        Control activePicBox;
        Control activePanel;
        Boolean curState = false;
        Boolean isPlayeBtnEnable = false;
        Boolean isSearched = false;
        Member focasedMember = null;
        Login login;

        Boolean admin = false;

        public Home()
        {
            InitializeComponent();
           
            playerPanel.Size = new Size(0, 0);
           // this.login = login;
            this.Size = new Size(1100, 700);
            playerPanel.Location = new Point(178, 75);
            f = addMemberLable.Font;
            memberPanel.Size = new Size(0, 284);
            searchPanel.Size = new Size(0, 72);
            memberListPanel.Size = new Size(580, 0);
        }
        public Home(String name)
        {

            this.admin = true;
            //this.login = login;
            InitializeComponent();

            loginNameText.Text = name;
            stateLable.Text = "Administrator";
            playerPanel.Size = new Size(0, 0);
            this.Size = new Size(1100, 700);
            playerPanel.Location = new Point(178, 75);
            f = addMemberLable.Font;
            memberPanel.Size = new Size(0, 0);
            searchPanel.Size = new Size(0, 72);
            memberListPanel.Size = new Size(580, 0);
            adminBtn.Visible = true;
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            reset();
            activePanel = memberPanel;
            animatePanel(270,284);
        }

        private void coacherBtn_Click(object sender, EventArgs e)
        {

            searchText.Focus();
            if (!isSearched)
            {
                MessageBox.Show("Search first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                CoacherManageForm coacherManageForm = new CoacherManageForm(focasedMember);
                coacherManageForm.Show();
            }
           
           // CoacherManageForm coacherManageForm = new CoacherManageForm();
           // coacherManageForm.Show();
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            //PlayerManageForm playerManageForm = new PlayerManageForm();
            //playerManageForm.Show();
            reset();
            activePanel = playerPanel;
            animatePanel(307, 402);

        }

        private void refreeBtn_Click(object sender, EventArgs e)
        {
            ExpandAnimation en = new ExpandAnimation();
            en.Start(tableLayoutPanel1, new Size(200, 500), TransitionType.Linear, 20);
        }   
       

        private void addMemberLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = addMemberLable;
            activePicBox = addMemberPicBox;
            animateController();
           
        }

        private void updateMemberLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = updateMemberLable;
            activePicBox = updateMemberPicBox;
            animateController();
        }

        private void addMemberLable_MouseLeave(object sender, EventArgs e)
        {       
            animateController();
        }

       

        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            reset();


        }

        private void updateMemberLable_Click(object sender, EventArgs e)
        {
            searchPanel.Location = new Point(448,148);
            ExpandAnimation en = new ExpandAnimation();
            en.Start(searchPanel, new Size(239, 72), TransitionType.Linear, 20);

        }



       

        private void getMemberListLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = getMemberListLable;
            activePicBox = getMemberListPicBox;
            animateController();
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            animateController();
        }

        private void removeMemberLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = removeMemberLable;
            activePicBox = removeMemberPicBox;
            animateController();
        }

        private void animateController()
        {
            if (activeLable != null && activePicBox != null)
            {
                if (curState)
                {
                    activeLable.ForeColor = Color.White;
                    activeLable.Font = f;
                    activePicBox.BackColor = Color.White;
                    activeLable = null;
                    activePicBox = null;
                    curState = false;
                }
                else
                {
                    activeLable.ForeColor = Color.Orange;
                    activeLable.Font = new Font(f.FontFamily, 11, FontStyle.Underline);
                    activePicBox.BackColor = Color.NavajoWhite;
                    curState = true;
                }
            }else if(activeLable != null && activePicBox == null)
            {
                if (curState)
                {
                    activeLable.ForeColor = Color.White;
                    activeLable.Font = f;
                    activeLable = null;
                    curState = false;
                }
                else
                {
                    activeLable.ForeColor = Color.Orange;
                    activeLable.Font = new Font(f.FontFamily, 11, FontStyle.Underline);
                    curState = true;
                }
            }
        }


        private void animatePanel(int width, int height)
        {
            ExpandAnimation en = new ExpandAnimation();
            en.Start(activePanel, new Size(width, height), TransitionType.Linear, 20);
        }

        private void addMemberLable_Click(object sender, EventArgs e)
        {
            MemberManageForm memberManageForm = new MemberManageForm();
            memberManageForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teakwondo_dbDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.teakwondo_dbDataSet.member);

        }

        private void getMemberListLable_Click(object sender, EventArgs e)
        {
            memberListPanel.Location = new Point(490,75);
            ExpandAnimation en = new ExpandAnimation();
            en.Start(memberListPanel, new Size(580, 303), TransitionType.Linear, 20);
        }

        private void removeMemberLable_Click(object sender, EventArgs e)
        {
            searchPanel.Location = new Point(448, 287);
            ExpandAnimation en = new ExpandAnimation();
            en.Start(searchPanel, new Size(239, 72), TransitionType.Linear, 20);
        }

        private void memberPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reset()
        {
            if (searchPanel.Size.Width > 0)
            {
                ExpandAnimation en = new ExpandAnimation();
                en.Start(searchPanel, new Size(0, 72), TransitionType.EaseOutQuad, 20);

            }else if (searchPanel.Size.Width == 0)
            {
                if (activePanel != null)
                {
                    ExpandAnimation en = new ExpandAnimation();
                    en.Start(activePanel, new Size(0, 0), TransitionType.EaseOutQuad, 20);
                }
            }

           
            
           
            activePanel = null;
            activeLable = null;
            activePicBox = null;
        }

        private void addPlayerLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = addPlayerLable;
            animateController();
        }

        private void searchPlayerBtn_Click(object sender, EventArgs e)
        {


           Member m = MemberController.SearchMemberByAthleticId(athleticIdText.Text);

            try
            {
                if (PlayerController.GetMatches(athleticIdText.Text, PlayerMatchType.Local).Select()[0] != null)
                {
                    addPlayerMatchesLable.BackColor = Color.FromArgb(70, 0, 40);
                    addPlayerCoursesLable.BackColor = Color.FromArgb(70, 0, 40);
                    viewCoursesLable.BackColor = Color.FromArgb(70, 0, 40);
                    viewMatchesLable.BackColor = Color.FromArgb(70, 0, 40);
                    updatePlayeDetailsLable.BackColor = Color.FromArgb(70, 0, 40);
                    isPlayeBtnEnable = true;
                }
            }catch(Exception ex)
            {
                if (m != null)
                {
                    MessageBox.Show(athleticIdText.Text + " is not a player!", "Message", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                else
                {
                    if(athleticIdText.Text == "")
                    {
                        MessageBox.Show("Enter ahtletic id to search.", "Message", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                    MessageBox.Show(athleticIdText.Text + " is not a member of Nationl Taekwondo Federation!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void addPlayerMatchesLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = addPlayerMatchesLable;
            animateController();
        }

        private void addPlayerCoursesLable_MouseEnter(object sender, EventArgs e)
        {
            activeLable = addPlayerCoursesLable;
            animateController();
        }

        private void viewMatchesLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = viewMatchesLable;
            animateController();
        }

        private void viewCoursesLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = viewCoursesLable;
            animateController();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            athleticIdText.Clear();
            isPlayeBtnEnable = false;
            addPlayerMatchesLable.BackColor = Color.Gray;
            addPlayerCoursesLable.BackColor = Color.Gray;
            viewCoursesLable.BackColor = Color.Gray;
            viewMatchesLable.BackColor = Color.Gray;
            updatePlayeDetailsLable.BackColor = Color.Gray;

        }

        private void updatePlayeDetailsLable_MouseHover(object sender, EventArgs e)
        {
            activeLable = updatePlayeDetailsLable;
            animateController();
        }

        private void ListcloseBtn_Click(object sender, EventArgs e)
        {
            ExpandAnimation en = new ExpandAnimation();
            en.Start(memberListPanel, new Size(580, 0), TransitionType.EaseInExpo, 20);
        }

        private void memberSearchBtn_Click(object sender, EventArgs e)
        {
                
            Member member = MemberController.SearchMemberByAthleticId(searchMemberText.Text);
                
                try
                {            
                    if (member != null)
                    {
                        MemberViewAndUpdate memberViewAndUpdate = new MemberViewAndUpdate(member);
                        memberViewAndUpdate.Show();
                    }
                    else
                    {
                        MessageBox.Show("Member not found!","Message", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }

        private void addPlayerLable_Click(object sender, EventArgs e)
        {
            PlayerManageForm playeManageForm = new PlayerManageForm(false);
            playeManageForm.Show();
        }

        private void addPlayerMatchesLable_Click(object sender, EventArgs e)
        {
            if (isPlayeBtnEnable)
            {
                new AddPlayedMatches(athleticIdText.Text).Show();
            }
        }

        private void addPlayerCoursesLable_Click(object sender, EventArgs e)
        {
            if (isPlayeBtnEnable)
            {
                new player.AddCourses(athleticIdText.Text).Show();
            }
        }

        private void updatePlayeDetailsLable_Click(object sender, EventArgs e)
        {
            if (isPlayeBtnEnable)
            {
                new PlayerManageForm(athleticIdText.Text).Show();
            }
           
        }

        private void viewMatchesLable_Click(object sender, EventArgs e)
        {
            if (isPlayeBtnEnable)
            {
                try
                {
                    new player.ViewMatchesForm(athleticIdText.Text).Show();
                }catch(Exception ex)
                {
                    throw ex;
                }
                
            }
        }

        private void athleticIdText_TextChanged(object sender, EventArgs e)
        {
            if (athleticIdText.Text == "")
            {
                resetBtn.PerformClick();
            }
           
        }

        private void viewCoursesLable_Click(object sender, EventArgs e)
        {
            if (isPlayeBtnEnable)
            {
                try
                {
                    new player.ViewCoacherForm(athleticIdText.Text).Show();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                focasedMember = MemberController.SearchMemberByAthleticId(searchText.Text);

                isSearched = (focasedMember != null);
                MessageBox.Show(isSearched.ToString());
            }
            catch (Exception ex)
            {

            }     
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            new AdminManageForm().Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to logout!","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                var form = new Login();
                form.Closed += (s, args) => this.Close();
                form.Show();
                return;
            }
           
        }
    }
}