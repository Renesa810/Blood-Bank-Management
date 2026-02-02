using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panelDonor_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panelDonor_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void panelPatientList_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelPatientList_Click(object sender, EventArgs e)
        {
            PatientList patientList = new PatientList();
            patientList.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PatientList patientList = new PatientList();
            patientList.Show();
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            
            DonorList donorList = new DonorList();
            donorList.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DonorList donorList = new DonorList();
            donorList.Show();
            this.Hide();
        }


    }
}
