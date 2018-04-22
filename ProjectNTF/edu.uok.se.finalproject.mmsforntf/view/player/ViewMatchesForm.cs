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

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.player
{
    public partial class ViewMatchesForm : Form
    {
        public ViewMatchesForm(String id)
        {
            InitializeComponent();
            athleticIdText.Text = id;
            try
            {
                matchesGridView.DataSource = PlayerController.GetCourses(id, PlayerCourseType.All);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        private void ViewMatchesForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
