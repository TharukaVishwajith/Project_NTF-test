using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.controller;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm(String id)
        {
            InitializeComponent();
            athleticIdText.Text = id;
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void addInternationalStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminController.AddNewAdmin(loginNameText.Text, passwordText.Text, athleticIdText.Text);
                MessageBox.Show("Administrator added success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
