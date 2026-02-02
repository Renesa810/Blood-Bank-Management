using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BloodBankManagement
{
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void Reset() {
            DNameTb.Text = "";
            DGenderCb.SelectedIndex = -1;
            DAgeTb.Text = "";
            DAddressTb.Text = "";
            DPhoneTb.Text = "";
            DBGCb.SelectedIndex = -1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DPhoneTb.Text == "" || DAddressTb.Text == "" || DBGCb.SelectedIndex == -1 || DGenderCb.SelectedIndex == -1 || DAgeTb.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else {
                string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\BloodBankmDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                SqlConnection con = new SqlConnection(ConnectionString);

                // Opening the connection to the database
                con.Open();

                // SQL command to insert data into the UserTable
                SqlCommand cmd = new SqlCommand("INSERT INTO DonorTbl(DName, DGender, DPhone, DAge, DBloodGroup, DAddress) VALUES(@DName, @DGender, @DPhone, @DAge, @DBloodGroup, @DAddress)", con);

                cmd.Parameters.AddWithValue("@DName", DNameTb.Text);
                cmd.Parameters.AddWithValue("@DGender", DGenderCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DPhone", DPhoneTb.Text);
                cmd.Parameters.AddWithValue("@DAge", DAgeTb.Text);
                cmd.Parameters.AddWithValue("@DBloodGroup", DBGCb.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DAddress", DAddressTb.Text);
                MessageBox.Show("Donor Added");
                // Executing the SQL command to insert the data into the database
                cmd.ExecuteNonQuery();

                con.Close();
                Reset();

                // Displaying a message box to confirm that the user was added successfully
                


            }
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.ShowDialog();
            this.Hide();
        }
    }
}
