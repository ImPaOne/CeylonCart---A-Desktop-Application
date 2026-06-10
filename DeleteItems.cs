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
    public partial class frmDeleteItems : Form
    {
        public frmDeleteItems()
        {
            InitializeComponent();
        }

        private void DeleteItems_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myQuery = "DELETE FROM Items WHERE PID=@pid";
            SqlCommand myCom = new SqlCommand(myQuery, conn);
            myCom.Parameters.AddWithValue("@pid", txtProductId.Text);
            myCom.ExecuteNonQuery();
            MessageBox.Show("Items Deleted Successfully");

            txtProductId.Text = "";
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myquery = "SELECT * FROM Items";
            SqlDataAdapter d1 = new SqlDataAdapter(myquery, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            DataGrideUsers.DataSource = dt;
        }

        private void DeleteItems_Load_1(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myquery = "SELECT * FROM Items";
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
    }
}
