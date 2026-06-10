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
    public partial class frmAdminlog : Form
    {
        public frmAdminlog()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();


            string checkCom = "SELECT COUNT(Username) FROM Admins WHERE Username=@un and Passwords=@pw";
            SqlCommand cheCk = new SqlCommand(checkCom, conn);
            cheCk.Parameters.AddWithValue("@un", txtUserName.Text);
            cheCk.Parameters.AddWithValue("@pw", txtPass.Text);
            int usercount = (int)cheCk.ExecuteScalar();



            if (usercount == 1)
            {
                
                frmAddAdmin f7 = new frmAddAdmin();
                f7.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("You are not an admin");
                txtUserName.Text = "";
                txtPass.Text = "";
                frmLogin f7 = new frmLogin();
                f7.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome f7 = new frmHome();
            f7.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
