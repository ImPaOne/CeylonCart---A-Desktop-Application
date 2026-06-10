using System;
using System.Collections;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome f2 = new frmHome();
            f2.Show();
            this.Hide();
        }

        private void lklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister f2 = new frmRegister();
            f2.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();




         
            {
                string checkCom = "SELECT COUNT(Username) FROM Users WHERE Username=@un AND Passwords=@pw";
                SqlCommand cheCk = new SqlCommand(checkCom, conn);
                cheCk.Parameters.Add("@un", SqlDbType.VarChar).Value = txtUserName.Text;
                cheCk.Parameters.Add("@pw", SqlDbType.VarChar).Value = txtPass.Text;

                object result = cheCk.ExecuteScalar();
                int usercount = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                if (usercount == 1)
                {
                    string checkCom1 = "SELECT COUNT(Admins) FROM Users WHERE Username=@un AND Passwords=@pw";
                    SqlCommand cheCk1 = new SqlCommand(checkCom1, conn);
                    cheCk1.Parameters.AddWithValue("@un", txtUserName.Text);
                    cheCk1.Parameters.AddWithValue("@pw", txtPass.Text);

                    object adminResult = cheCk1.ExecuteScalar();

                    if (adminResult != null && adminResult is int)
                    {
                        int adminStatus = (int)adminResult;

                        if (adminStatus == 1)
                        {
                            MessageBox.Show("Login as an Admin");
                            frmAddAdmin f7 = new frmAddAdmin();
                            f7.Show();
                            this.Hide();
                        }
                        else if (adminStatus == 0)
                        {
                            MessageBox.Show("Login as a User");
                            frmItems f7 = new frmItems();
                            f7.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    txtUserName.Text = "";
                    txtPass.Text = "";
                }
            }




        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frmForgotPass f2 = new frmForgotPass();
            f2.Show();
            this.Hide();
        }
    }
}
