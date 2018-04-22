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
    public partial class ViewCoacherForm : Form
    {
        public ViewCoacherForm(String id)
        {
            InitializeComponent();
            athleticIdText.Text = id;
            try
            {
                matchesGridView.DataSource = PlayerController.GetMatches(id, PlayerMatchType.Local);
                internationlCoureseGridView.DataSource = PlayerController.GetMatches(id, PlayerMatchType.Forign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ViewCoacherForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
