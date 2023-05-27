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

namespace FoodTrack
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create Connection object
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public static string username;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            string uname = txtUname.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string query = "Select * from Registration where username = '" + uname + "' and password = '" + pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (string.IsNullOrEmpty(txtUname.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill out all the boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt.Rows.Count == 1)
            {
                username = uname;
                Dashboard dashform = new Dashboard();
                this.Hide();
                dashform.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");
            }
        }

        private void lbliRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lbliRegister.LinkVisited = true;

            Registration regform = new Registration();
            this.Hide();
            regform.Show();
        }
    }

}
