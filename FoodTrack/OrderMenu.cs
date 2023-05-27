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
    public partial class OrderMenu : Form
    {
        public OrderMenu()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create Connection object
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        public static int orderNo;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logform = new Login();
            this.Hide();
            logform.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddOrder addform = new AddOrder();
            this.Hide();
            addform.Show();
        }

        //Create Display class
        private void Display()
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT OrdersItems.no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name WHERE order_no='"+orderNo+"'", con);
            //cmd = new SqlCommand("SELECT no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSummary.DataSource = dt;
            con.Close();
        }

        private void btnDisplayOrder_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();

            //Check if orderNo value exists in database
            bool orderNum = true;

            //Auto-generation of Order No.
            while (orderNum)
            {
                cmd = new SqlCommand("SELECT * FROM OrdersItems WHERE order_no= '" + orderNo + "'", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //If OrderNo exists in database, else will add value of OrderNo by +1
                if (dt.Rows.Count == 0)
                    orderNum = false;
                else
                    orderNo += 1;
            }

            txtOrderNo.Text = Convert.ToString(OrderMenu.orderNo);

            decimal nudFood1 = nudChicken.Value;
            decimal nudFood2 = nudBurgerSteak.Value;
            decimal nudFood3 = nudSisig.Value;
            decimal nudFood4 = nudBurgerFries.Value;
            decimal nudFood5 = nudSpaghetti.Value;

            decimal nudDrink1 = nudIcedTea.Value;
            decimal nudDrink2 = nudCoke.Value;
            decimal nudDrink3 = nudPineapple.Value;

            string chicken = lblChicken.Text;
            string burgerSteak = lblBurgerSteak.Text;
            string sisig = lblSisig.Text;
            string burgerFries = lblBurgerFries.Text;
            string spaghetti = lblSpaghetti.Text;

            string icedTea = lblIcedTea.Text;
            string coke = lblCoke.Text;
            string pineapple = lblPineapple.Text;

            int chickenPrice = Convert.ToInt32(lblChickenPrice.Text);
            int burgerSteakPrice = Convert.ToInt32(lblBurgerSteakPrice.Text);
            int sisigPrice = Convert.ToInt32(lblSisigPrice.Text);
            int burgerFriesPrice = Convert.ToInt32(lblBurgerFriesPrice.Text);
            int spaghettiPrice = Convert.ToInt32(lblSpaghettiPrice.Text);

            int icedTeaPrice = Convert.ToInt32(lblIcedTeaPrice.Text);
            int cokePrice = Convert.ToInt32(lblCokePrice.Text);
            int pineapplePrice = Convert.ToInt32(lblPineapplePrice.Text);

            int total = 0;

            if (nudFood1 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + chicken + "', '" + nudFood1 + "')", con);
                cmd.ExecuteNonQuery();
                total += chickenPrice * Convert.ToInt32(nudFood1);
            }
            if (nudFood2 != 0)
            { 
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + burgerSteak + "', '" + nudFood2 + "')", con);
                cmd.ExecuteNonQuery();
                total += burgerSteakPrice * Convert.ToInt32(nudFood2);
            }
            if (nudFood3 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + sisig + "', '" + nudFood3 + "')", con);
                cmd.ExecuteNonQuery();
                total += sisigPrice * Convert.ToInt32(nudFood3);
            }
            if (nudFood4 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + burgerFries + "', '" + nudFood4 + "')", con);
                cmd.ExecuteNonQuery();
                total += burgerFriesPrice * Convert.ToInt32(nudFood4);

            }
            if (nudFood5 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + spaghetti + "', '" + nudFood5 + "')", con);
                cmd.ExecuteNonQuery();
                total += spaghettiPrice * Convert.ToInt32(nudFood5);

            }
            if (nudDrink1 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + icedTea + "', '" + nudDrink1 + "')", con);
                cmd.ExecuteNonQuery();
                total += icedTeaPrice * Convert.ToInt32(nudDrink1);

            }
            if (nudDrink2 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + coke + "', '" + nudDrink2 + "')", con);
                cmd.ExecuteNonQuery();
                total += cokePrice * Convert.ToInt32(nudDrink2);

            }
            if (nudDrink3 != 0)
            {
                cmd = new SqlCommand("Insert Into OrdersItems values ('" + orderNo + "','" + pineapple + "', '" + nudDrink3 + "')", con);
                cmd.ExecuteNonQuery();
                total += pineapplePrice * Convert.ToInt32(nudDrink3);

            }
            MessageBox.Show("One Order Added");
            Display();

            txtTotalAmount.Text = Convert.ToString(total);
            con.Close();

        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            Dashboard dashform = new Dashboard();
            this.Hide();
            dashform.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            AddOrder addform = new AddOrder();
            this.Hide();
            addform.Show();
        }
    }
}
