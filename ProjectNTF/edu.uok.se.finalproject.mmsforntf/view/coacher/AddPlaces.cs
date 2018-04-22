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
using ProjectNTF.edu.uok.se.finalproject.mmsforntf.model;


namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.view.coacher
{
    public partial class AddPlaces : Form
    {
        CoacherManageForm c;
        public AddPlaces(String id,CoacherManageForm c)
        {
            InitializeComponent();
            this.c = c;
            IdText.Text = id;
        }

      
        private void AddPlaces_Load(object sender, EventArgs e)
        {
           
        }     

        private void addPlacesBtn_Click(object sender, EventArgs e)
        {
            String sDate = startedDatePicker.Text;
            String eDate = endDatePicker.Text;


            try
            {
                if (workedPlaceText.Text != "")
                {
                    string[] dateformat = sDate.Split('/');
                    sDate = dateformat[2] + "-" + dateformat[0] + "-" + dateformat[1];

                    dateformat = eDate.Split('/');
                    eDate = dateformat[2] + "-" + dateformat[0] + "-" + dateformat[1];
                    CoacherController.AddWorkedPlaces(new WorkedPlace(workedPlaceText.Text, sDate, eDate, IdText.Text));
                    MessageBox.Show("Data added success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    c.LoadData();
                    workedPlaceText.Clear();
                }
                else
                {
                    MessageBox.Show("Complete required fields! ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
