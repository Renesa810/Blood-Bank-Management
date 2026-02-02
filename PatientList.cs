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
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
            Populate();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\BloodBankmDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public void Populate()
        {
            con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGVpatient.DataSource = ds.Tables[0];
            con.Close();

        }

        private void PatientList_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.ShowDialog();
            this.Hide();
        }

        //int key = 0;
        private void DGVpatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = DGVpatient.SelectedRows[0].Cells[1].Value.ToString();
            PGenderCb.SelectedItem=DGVpatient.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneTb.Text = DGVpatient.SelectedRows[0].Cells[3].Value.ToString();
            PAgeTb.Text = DGVpatient.SelectedRows[0].Cells[4].Value.ToString();
            PBloodGroupCb.SelectedItem = DGVpatient.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = DGVpatient.SelectedRows[0].Cells[6].Value.ToString();

        }
    }
}
