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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create Connection object
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logform = new Login();
            this.Hide();
            logform.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashform = new Dashboard();
            this.Hide();
            dashform.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOrder editform = new EditOrder();
            this.Hide();
            editform.Show();
        }

        //Create Display class
        private void Display()
        {
            int orderNo = Convert.ToInt32(txtOrderNo.Text);

            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT OrdersList.Date, OrdersList.Customer, OrdersList.TotalAmount, OrdersList.PaymentStatus, OrdersList.Progress FROM OrdersList WHERE orderNo =" + orderNo, con);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Select * from OrdersList where orderNo =" + orderNo;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtDate.Text = dr.GetValue(1).ToString();
                txtCustomer.Text = dr.GetValue(2).ToString();
                txtTotal.Text = dr.GetValue(3).ToString();
                txtPayment.Text = dr.GetValue(4).ToString();
                txtProgress.Text = dr.GetValue(5).ToString();
            }
            con.Close();
            
            con.Open();
            cmd = new SqlCommand("SELECT no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name WHERE order_no =" + orderNo, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSummary.DataSource = dt;
            con.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
