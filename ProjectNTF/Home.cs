
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.member;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.dbconnection;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;


namespace ProjectNTF
{
    public partial class HomePage : Form
    {
       

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          MemberManageForm memberForm = new MemberManageForm();
            memberForm.Show();
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            memberBtn.BackColor = Color.Teal;
        }

        private void memberBtn_MouseLeave(object sender, EventArgs e)
        {
            memberBtn.BackColor = Color.DarkSlateGray;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PlayerManageForm playerForm = new PlayerManageForm();
            playerForm.Show();
        }

        private void playerBtn_MouseHover(object sender, EventArgs e)
        {
            playerBtn.BackColor = Color.Teal;
        }

        private void playerBtn_MouseLeave(object sender, EventArgs e)
        {
            playerBtn.BackColor = Color.DarkSlateGray;
        }

        private void coacherBtn_MouseHover(object sender, EventArgs e)
        {
            coacherBtn.BackColor = Color.Teal;
        }

        private void coacherBtn_MouseLeave(object sender, EventArgs e)
        {
            coacherBtn.BackColor = Color.DarkSlateGray;
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            refreeBtn.BackColor = Color.Teal;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            refreeBtn.BackColor = Color.DarkSlateGray;
        }

        private void administratorBtn_MouseHover(object sender, EventArgs e)
        {
            administratorBtn.BackColor = Color.Teal;
        }

        private void administratorBtn_MouseLeave(object sender, EventArgs e)
        {
            administratorBtn.BackColor = Color.DarkSlateGray;
        }

        private void coacherBtn_Click(object sender, EventArgs e)
        {
            CoacherManageForm coacherManageForm = new CoacherManageForm();
            coacherManageForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = DBConnection.getDbConnection().getConnection();
            
            MySqlCommand mcd;
            MySqlDataReader mdr;

            
            try
            {
                connection.Open();
                string s = "select * from MEMBER where athleticId='" + searchText.Text + "'";
                mcd = new MySqlCommand(s, connection);
                mdr = mcd.ExecuteReader();
                if (mdr.Read())
                {
                    Member member = new Member(mdr.GetString("athleticId"),
                        mdr.GetString("fullName"),
                        mdr.GetString("nameWithInitials"),
                        mdr.GetString("dob"), 
                        mdr.GetString("NICNo"),
                        mdr.GetString("address"), 
                        mdr.GetInt32("telNo"),
                        mdr.GetInt32("mobileNo"),
                        mdr.GetString("occupation"),
                        mdr.GetString("email"),
                        mdr.GetString("DANorGUP"), 
                        mdr.GetString("kukkiwonNo"),
                        mdr.GetString("belt"), mdr.GetString("club"),
                        mdr.GetString("coacher"));
                    //MessageBox.Show(mdr.GetString("nameWithInitials"));

                    MemberViewAndUpdate memberViweAndUpdateForm = new MemberViewAndUpdate(member);
                    memberViweAndUpdateForm.Show();
                }
                else
                {
                    MessageBox.Show("NO DATA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               // mdr.Close();
                connection.Close();
            }
            
        }
             

            
        }
    }

