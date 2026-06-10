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
    public partial class frmAddAdmin : Form
    {
        public frmAddAdmin()
        {
            InitializeComponent();
        }

        

        private void frmAddAdmin_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string myquery = "SELECT * FROM Admins";
            SqlDataAdapter d1 = new SqlDataAdapter(myquery, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            DataGrideAdmins.DataSource = dt;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
           
            string myQuery1 = "UPDATE Users SET Admins = 1 WHERE Username = @un";
            SqlCommand myCom1 = new SqlCommand(myQuery1, conn);
            myCom1.Parameters.AddWithValue("@un", txtUsername.Text);    
            myCom1.ExecuteNonQuery();

            string myQuery = "INSERT INTO Admins(Username,Passwords,Mobile)VALUES(@un,@pw,@nb)";
            SqlCommand myCom = new SqlCommand(myQuery, conn);
            myCom.Parameters.AddWithValue("@un", txtUsername.Text);
            myCom.Parameters.AddWithValue("@pw", txtPass.Text);
            myCom.Parameters.AddWithValue("@nb", txtPhone.Text);
            myCom.ExecuteNonQuery();

            MessageBox.Show("Admin add successfully !!");


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome f2 = new frmHome();
            f2.Show();
            this.Hide();
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateAdmin f2 = new frmUpdateAdmin();
            f2.Show();
            this.Hide();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteUser f7 = new frmDeleteUser();
            f7.Show();
            this.Hide();
        }

        private void deleteAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteAdmin f7 = new frmDeleteAdmin();
            f7.Show();
            this.Hide();
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddItem f2 = new frmAddItem();
            f2.Show();
            this.Hide();
        }

        private void deleteItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteItems f2 = new frmDeleteItems();
            f2.Show();
            this.Hide();
        }

        private void updateItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateItems f2 = new frmUpdateItems();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string myquery = "SELECT * FROM Admins";
            SqlDataAdapter d1 = new SqlDataAdapter(myquery, conn);
            DataTable dt = new DataTable();
            d1.Fill(dt);
            DataGrideAdmins.DataSource = dt;
        }
    }
}
