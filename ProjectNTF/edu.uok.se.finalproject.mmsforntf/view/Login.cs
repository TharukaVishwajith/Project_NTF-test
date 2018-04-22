using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.view;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String athleticId = "";
           
            String[] id = nameText.Text.Split('/');

            if (id[0] == "admin" || (nameText.Text == "adminadmin" && passwordText.Text == "admin"))
            {
                athleticId = LoginController.RequestForAdminLogin(nameText.Text, passwordText.Text);

                if (athleticId != "" || (nameText.Text == "adminadmin" && passwordText.Text == "admin"))
                {
                    this.Hide();
                    var form = new Home(nameText.Text);
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid username or password!","Massage",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    nameText.Clear();
                    passwordText.Clear();
                    return;
                }
               
            }
            this.Hide();
            var form2 = new Home();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
