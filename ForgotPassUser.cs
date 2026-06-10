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
    public partial class frmForgotPass : Form
    {
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPassUser_Lo(object sender, EventArgs e)
        {

        }

        private void frmResetUser_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConfirmPass.Text)
            {


                string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string checkCom = "SELECT COUNT(Username) FROM Users WHERE Username=@un";
                SqlCommand cheCk = new SqlCommand(checkCom, conn);
                cheCk.Parameters.AddWithValue("@un", txtUserName.Text);
                int usercount = (int)cheCk.ExecuteScalar();

                if (usercount == 1)
                {

                    string myQuery = "UPDATE Users SET Passwords=@pw WHERE Username=@un";
                    SqlCommand myCom = new SqlCommand(myQuery, conn);
                    myCom.Parameters.AddWithValue("@un", txtUserName.Text);
                    myCom.Parameters.AddWithValue("@pw", txtConfirmPass.Text);
                    myCom.ExecuteNonQuery();
                    MessageBox.Show("Reset Successfully!!");

                    frmLogin f2 = new frmLogin();
                    f2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User not found");
                    txtUserName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("pASSWORD IS mISSMATCHED!");
                txtConfirmPass.Text = "";
                txtPass.Text = "";


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin f2 = new frmLogin();
            f2.Show();
            this.Hide();
        }

        
    }
}
