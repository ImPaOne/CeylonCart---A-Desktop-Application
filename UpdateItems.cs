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
    public partial class frmUpdateItems : Form
    {
        public frmUpdateItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {


            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string myQuery = "UPDATE Items SET Productname = @pn, Brandname = @bn, Quantity = @qty, Price = @price WHERE pid = @pid";
            SqlCommand myCom = new SqlCommand(myQuery, conn);
            myCom.Parameters.AddWithValue("@pid", txtProductId.Text);
            myCom.Parameters.AddWithValue("@qty", txtQuantity.Text);     
            myCom.Parameters.AddWithValue("@price", txtPrice.Text);
            myCom.Parameters.AddWithValue("@pn", txtProductName.Text);
            myCom.Parameters.AddWithValue("@bn", txtProductBrand.Text);
            myCom.ExecuteNonQuery();
           
           
            MessageBox.Show("Items Update Successfully");

            txtPrice.Text = "";
            txtProductId.Text = "";
            txtQuantity.Text = "";
        }

 
  
        
        private void btnRefresh_Click_1(object sender, EventArgs e)
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

        private void DataGrideUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUpdateItems_Load(object sender, EventArgs e)
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