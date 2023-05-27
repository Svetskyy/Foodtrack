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
    public partial class AddOrder : Form
    {
        public AddOrder()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashform = new Dashboard();
            this.Hide();
            dashform.Show();
        }

        //Create Display class
        private void Display()
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT OrdersItems.no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name WHERE order_no =" + OrderMenu.orderNo, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOrderItems.DataSource = dt;
            con.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomer.Text) || string.IsNullOrEmpty(txtTotal.Text) || string.IsNullOrEmpty(cboProgress.Text))
            {
                MessageBox.Show("Please fill out all the boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();

            string date = dtpDate.Value.ToString("MMMM-dd-yyyy");
            string customer = txtCustomer.Text;
            int totalAmount = Convert.ToInt32(txtTotal.Text);
            string progress = cboProgress.Text;
            String payment = "";
            if (radPaid.Checked)
            {
                payment = radPaid.Text;
            }
            if (radCOD.Checked)
            {
                payment = radCOD.Text;
            }

            txtOrderNo.Text = Convert.ToString(OrderMenu.orderNo);

            cmd = new SqlCommand("Insert Into OrdersList values ('" + OrderMenu.orderNo + "','" + date + "', '" + customer + "' , '" + totalAmount + "' , '" + payment + "' , '" + progress + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One Order Added");
            con.Close();
            txtOrderNo.Clear();
            dtpDate.ResetText();
            txtCustomer.Clear();
            txtTotal.Clear();
            cboProgress.ResetText();


        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            OrderMenu menuform = new OrderMenu();
            this.Hide();
            menuform.Show();
        }

        private void btnDisplayItems_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
