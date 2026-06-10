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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome f2 = new frmHome();
            f2.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {


            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myQuery = "INSERT INTO Users(UserName,Passwords,Mobile,Address1)VALUES(@un,@pw,@nb,@add)";
            SqlCommand myCom = new SqlCommand(myQuery, conn);
            myCom.Parameters.AddWithValue("@un", txtUserName.Text);
            myCom.Parameters.AddWithValue("@pw", txtPass.Text);
            myCom.Parameters.AddWithValue("@nb", txtMobile.Text);
            myCom.Parameters.AddWithValue("@add", txtAddress.Text);
            myCom.ExecuteNonQuery();
            MessageBox.Show("Register Successfully!!");

            frmLogin f2 = new frmLogin();
            f2.Show();
            this.Hide();
        }

       
    }
}
