using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            PNameTb.Text = "";
            PGenderCb.SelectedIndex = -1;
            PAgeTb.Text = "";
            PAddressTb.Text = "";
            PPhoneTb.Text = "";
            PBGCb.SelectedIndex = -1;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAddressTb.Text == "" || PBGCb.SelectedIndex == -1 || PGenderCb.SelectedIndex == -1 || PAgeTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\BloodBankmDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                SqlConnection con = new SqlConnection(ConnectionString);

                // Opening the connection to the database
                con.Open();

                // SQL command to insert data into the UserTable
                SqlCommand cmd = new SqlCommand("INSERT INTO PatientTbl(PName, PGender, PPhone, PAge, PBloodGroup, PAddress) VALUES(@PName, @PGender, @PPhone, @PAge, @PBloodGroup, @PAddress)", con);

                cmd.Parameters.AddWithValue("@PName", PNameTb.Text);
                cmd.Parameters.AddWithValue("@PGender", PGenderCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PPhone", PPhoneTb.Text);
                cmd.Parameters.AddWithValue("@PAge", PAgeTb.Text);
                cmd.Parameters.AddWithValue("@PBloodGroup", PBGCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PAddress", PAddressTb.Text);
                MessageBox.Show("Patient Added");
                // Executing the SQL command to insert the data into the database
                cmd.ExecuteNonQuery();

                con.Close();
            }
            Reset();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.ShowDialog();
            this.Hide();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
    }
}
