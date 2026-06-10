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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSE24
{
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {


            frmHome f6 = new frmHome();
            f6.Show();
            this.Hide();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=CeylonCart;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string myquery = "SELECT Price FROM Items WHERE PID = 1";
            SqlCommand command = new SqlCommand(myquery, conn);
            var result = command.ExecuteScalar();
            lblprice1.Text = result.ToString();

            string myquery2 = "SELECT Price FROM Items WHERE PID = 2";
            SqlCommand command2 = new SqlCommand(myquery2, conn);
            var result2 = command2.ExecuteScalar();
            lblprice2.Text = result2.ToString();

            string myquery3 = "SELECT Price FROM Items WHERE PID = 3";
            SqlCommand command3 = new SqlCommand(myquery3, conn);
            var result3 = command3.ExecuteScalar();
            lblprice3.Text = result3.ToString();

            string myquery4 = "SELECT Price FROM Items WHERE PID = 4";
            SqlCommand command4 = new SqlCommand(myquery4, conn);
            var result4 = command4.ExecuteScalar();
            lblprice4.Text = result4.ToString();

            string myquery5 = "SELECT Price FROM Items WHERE PID = 5";
            SqlCommand command5 = new SqlCommand(myquery5, conn);
            var result5 = command5.ExecuteScalar();
            lblprice5.Text = result5.ToString();

            string myquery6 = "SELECT Price FROM Items WHERE PID = 6";
            SqlCommand command6 = new SqlCommand(myquery6, conn);
            var result6 = command6.ExecuteScalar();
            lblprice6.Text = result6.ToString();

            string myquery7 = "SELECT Price FROM Items WHERE PID = 7";
            SqlCommand command7 = new SqlCommand(myquery7, conn);
            var result7 = command7.ExecuteScalar();
            lblprice7.Text = result7.ToString();

            string myquery8 = "SELECT Price FROM Items WHERE PID = 8";
            SqlCommand command8 = new SqlCommand(myquery8, conn);
            var result8 = command8.ExecuteScalar();
            lblprice8.Text = result8.ToString();

            string myquery9 = "SELECT Price FROM Items WHERE PID = 9";
            SqlCommand command9 = new SqlCommand(myquery9, conn);
            var result9 = command9.ExecuteScalar();
            lable99.Text = result9.ToString();

            string myquery10 = "SELECT Price FROM Items WHERE PID = 10";
            SqlCommand command10 = new SqlCommand(myquery10, conn);
            var result10 = command10.ExecuteScalar();
            lblprice10.Text = result10.ToString();

            string myquery11 = "SELECT Price FROM Items WHERE PID = 11";
            SqlCommand command11 = new SqlCommand(myquery10, conn);
            var result11 = command11.ExecuteScalar();
            lblPrice11.Text = result11.ToString();
        }

        

        private void btnCart2_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart3_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart4_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart5_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart6_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart7_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart8_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart9_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart11_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void btnCart10_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmCart f2 = new frmCart();
            f2.Show();
            this.Hide();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
