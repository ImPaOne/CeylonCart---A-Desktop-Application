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
    public partial class frmUpdateAdmin : Form
    {
        public frmUpdateAdmin()
        {
            InitializeComponent();
        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtConfirmPass.Text)
            {


                string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string checkCom = "SELECT COUNT(UserName) FROM Admins WHERE Username=@un";
                SqlCommand cheCk = new SqlCommand(checkCom, conn);
                cheCk.Parameters.AddWithValue("@un", txtUsername.Text);
                int usercount = (int)cheCk.ExecuteScalar();

                if (usercount == 1)
                {

                    string myQuery = "UPDATE Admins SET Passwords=@pw WHERE Username=@un";
                    SqlCommand myCom = new SqlCommand(myQuery, conn);
                    myCom.Parameters.AddWithValue("@un", txtUsername.Text);
                    myCom.Parameters.AddWithValue("@pw", txtConfirmPass.Text);
                    myCom.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully!!");

                    txtConfirmPass.Text = "";
                    txtNewPass.Text = "";
                    txtUsername.Text = "";
                }
                else
                {
                    MessageBox.Show("User not found");
                    txtUsername.Text = "";
                }
            }
            else
            {
                MessageBox.Show("pASSWORD IS mISSMATCHED!");
                txtConfirmPass.Text = "";
                txtNewPass.Text = "";


            }
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

        private void frmUpdateAdmin_Load(object sender, EventArgs e)
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

        private void DataGrideUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
