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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            
            
                
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Address1=@address";
                SqlCommand cmd = new SqlCommand(checkQuery, conn);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@address", txtAdress.Text);
                conn.Open();

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount == 1)
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Invalid username or address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputs();
                }
            }
        

        private void ClearInputs()
        {
            txtUser.Text = "";
            txtAdress.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmItems f7 = new frmItems();
            f7.Show();
            this.Hide();
        }
    }
}

