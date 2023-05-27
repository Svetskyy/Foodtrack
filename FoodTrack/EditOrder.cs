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
    public partial class EditOrder : Form
    {
        public EditOrder()
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

        //Create Display class
        private void Display()
        {
            string orderNo = Convert.ToString(txtOrderNo.Text);

            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name WHERE order_no='" + orderNo + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOrderItems.DataSource = dt;
            con.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            int orderNo = Convert.ToInt32(txtOrderNo.Text);
            string date = Convert.ToString(dtpDate.Text);
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

            string abc = "UPDATE OrdersList SET OrderNo = '" + orderNo + "', Date ='" + date + "', Customer ='" + customer + "', TotalAmount ='" + totalAmount + "', PaymentStatus ='" + payment + "', Progress ='" + progress + "'  WHERE OrderNo = '" + orderNo + "'";
            cmd = new SqlCommand(abc, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("One record updated");
            Display();
            con.Close();

        }

        //Create Display Info class
        private void DisplayInfo()
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
                dtpDate.Text = dr.GetValue(1).ToString();
                txtCustomer.Text = dr.GetValue(2).ToString();
                txtTotal.Text = dr.GetValue(3).ToString();
                String payment = (string)dr.GetValue(4);
                if (payment == "Paid      ")
                {
                    radPaid.Checked = true;
                }
                else if (payment == "COD       ")
                {
                    radCOD.Checked = true;
                }
                cboProgress.Text = dr.GetValue(5).ToString();
            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name WHERE order_no =" + orderNo, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOrderItems.DataSource = dt;
            con.Close();
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            DisplayInfo();
        }

    }
}
