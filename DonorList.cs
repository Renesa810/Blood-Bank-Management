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
    public partial class DonorList : Form
    {
        public DonorList()
        {
            InitializeComponent();
            Populate();
        }
        //string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\BloodBankmDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\BloodBankmDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public void Populate() {
            con.Open();
            string query = "select * from DonorTbl";
            SqlDataAdapter sda=new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds=new DataSet();
            sda.Fill(ds);
            DGVdonor.DataSource = ds.Tables[0];
            con.Close();

        }
        private void DonorList_Load(object sender, EventArgs e)
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
