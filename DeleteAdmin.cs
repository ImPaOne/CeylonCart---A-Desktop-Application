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

namespace CSE24
{
    public partial class frmDeleteAdmin : Form
    {
        public frmDeleteAdmin()
        {
            InitializeComponent();
        }

       

        private void DataGrideUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myQuery = "DELETE FROM Admins WHERE Username= @un";
            SqlCommand myCom = new SqlCommand(myQuery, conn);
            myCom.Parameters.AddWithValue("@un", txtUsername.Text);
            myCom.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!!");

            txtUsername.Text = "";


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myquery = "SELECT * FROM Admins";
            SqlDataAdapter d1 = new SqlDataAdapter(myquery, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            DataGrideUsers.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAddAdmin f2 = new frmAddAdmin();
            f2.Show();
            this.Hide();
        }

        private void frmDeleteAdmin_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string myquery = "SELECT * FROM Admins";
            SqlDataAdapter d1 = new SqlDataAdapter(myquery, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            DataGrideUsers.DataSource = dt;
        }
    }
}
