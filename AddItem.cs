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
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
        }


        private void frmAddItem_Load(object sender, EventArgs e)
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myQuery = "INSERT INTO Items(PID,Productname,Brandname,Quantity,Price)VALUES(@pid,@pn,@pb,@qty,@price)";
            SqlCommand myCom = new SqlCommand(myQuery, conn);
            myCom.Parameters.AddWithValue("@pid", txtProductId.Text);
            myCom.Parameters.AddWithValue("@pn", txtProductName.Text);
            myCom.Parameters.AddWithValue("@pb", txtProductBrand.Text);
            myCom.Parameters.AddWithValue("@qty", txtQuantity.Text);
            myCom.Parameters.AddWithValue("@price", txtPrice.Text);
            myCom.ExecuteNonQuery();
            MessageBox.Show("Items Add Successfully");

            txtPrice.Text = "";
            txtProductId.Text = "";
            txtQuantity.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAddAdmin f2 = new frmAddAdmin();
            f2.Show();
            this.Hide(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
