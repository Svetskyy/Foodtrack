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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create Connection object
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logform = new Login();
            this.Hide();
            logform.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderMenu menuform = new OrderMenu();
            this.Hide();
            menuform.Show();
        }

        //Create Display class
        private void Display()
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select * from OrdersList", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOverview.DataSource = dt;
            con.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            int a = Convert.ToInt32(txtSearch.Text);
            string abc = "SELECT OrderNo,Date,Customer,TotalAmount,PaymentStatus,Progress FROM OrdersList where OrderNo='" + a + "'";
            cmd = new SqlCommand(abc, con);
            MessageBox.Show("one record search:");
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvOverview.DataSource = dt;
            con.Close();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            int a = Convert.ToInt32(txtRemove.Text);

            cmd = new SqlCommand("DELETE FROM OrdersList where orderNo='" + a + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One record Deleted");
            Display();
            con.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOrder editform = new EditOrder();
            this.Hide();
            editform.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewOrder viewform = new ViewOrder();
            this.Hide();
            viewform.Show();
        }
    }
}
