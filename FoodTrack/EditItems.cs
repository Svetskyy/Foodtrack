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
    public partial class EditItems : Form
    {
        public EditItems()
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

        //Create Display class
        private void Display()
        {

            string orderNo = Convert.ToString(txtOrderNo.Text);

            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("SELECT OrdersItems.no_of_items, OrdersItems.name, Items.price FROM OrdersItems JOIN Items ON OrdersItems.name = Items.name WHERE order_no='" + orderNo + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvSummary.DataSource = dt;
            con.Close();

        }

        // Create Display Info class
        private void DisplayInfo()
        {

            int orderNo = Convert.ToInt32(txtOrderNo.Text);

            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();

            cmd = new SqlCommand("SELECT OrdersItems.no_of_items, OrdersItems.name, Items.price FROM OrdersItems, Items WHERE order_no =" + orderNo, con);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "Select * from OrdersItems where order_no =" + orderNo;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetValue(1).ToString();
                if (name == "Chicken Rice Meal") {
                    nudChicken.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Burger Steak Rice Meal")
                {
                    nudBurgerSteak.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Sisig Rice Meal")
                {
                    nudSisig.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Burger with Fries")
                {
                    nudBurgerFries.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Spaghetti with Fries")
                {
                    nudSpaghetti.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Iced Tea")
                {
                    nudIcedTea.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Coke")
                {
                    nudCoke.Text = dr.GetValue(2).ToString();
                }
                else if (name == "Pineapple Juice")
                {
                    nudPineapple.Text = dr.GetValue(2).ToString();
                }

            }
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT OrdersItems.no_of_items, OrdersItems.name, Items.price FROM OrdersItems, Items WHERE order_no =" + orderNo, con);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select * from Items";
            dr = cmd.ExecuteReader();
            int totalAmount = 0;
            while (dr.Read())
            {
                //totalAmount = (int)dr.GetValue(2);
                string orderName = dr.GetValue(1).ToString();

                decimal nudFood1 = nudChicken.Value;
                decimal nudFood2 = nudBurgerSteak.Value;
                decimal nudFood3 = nudSisig.Value;
                decimal nudFood4 = nudBurgerFries.Value;
                decimal nudFood5 = nudSpaghetti.Value;

                decimal nudDrink1 = nudIcedTea.Value;
                decimal nudDrink2 = nudCoke.Value;
                decimal nudDrink3 = nudPineapple.Value;

                int chickenPrice = 100;
                int burgerSteakPrice = 90;
                int sisigPrice = 100;
                int burgerFriesPrice = 75;
                int spaghettiPrice = 80;

                int icedTeaPrice = 20;
                int cokePrice = 15;
                int pineapplePrice = 25;
                                
                if (orderName == "Chicken Rice Meal")
                {
                    totalAmount += chickenPrice * Convert.ToInt32(nudFood1);
                }
                if (orderName == "Burger Steak Rice Meal")
                {
                    totalAmount += burgerSteakPrice * Convert.ToInt32(nudFood2);
                }
                if (orderName == "Sisig Rice Meal")
                {
                    totalAmount += sisigPrice * Convert.ToInt32(nudFood3);
                }
                if (orderName == "Burger with Fries")
                {
                    totalAmount += burgerFriesPrice * Convert.ToInt32(nudFood4);
                }
                if (orderName == "Spaghetti with Fries")
                {
                    totalAmount += spaghettiPrice * Convert.ToInt32(nudFood5);
                }
                if (orderName == "Iced Tea")
                {
                    totalAmount += icedTeaPrice * Convert.ToInt32(nudDrink1);
                }
                if (orderName == "Coke")
                {
                    totalAmount += cokePrice * Convert.ToInt32(nudDrink2);
                }
                if (orderName == "Pineapple Juice")
                {
                    totalAmount += pineapplePrice * Convert.ToInt32(nudDrink3);
                }
                txtTotalAmount.Text = totalAmount.ToString();

            }
            con.Close();
        }

        private void btnDisplayOrder_Click(object sender, EventArgs e)
        {
            Display();
            DisplayInfo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EditOrder editform = new EditOrder();
            this.Hide();
            editform.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string orderNo = Convert.ToString(txtOrderNo.Text);

            con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
            con.Open();
            //int chicken = Convert.ToInt32(nudChicken.Text);
            //int burgerSteak = Convert.ToInt32(nudBurgerSteak.Text);

            decimal nudFood1 = nudChicken.Value;
            decimal nudFood2 = nudBurgerSteak.Value;
            decimal nudFood3 = nudSisig.Value;
            decimal nudFood4 = nudBurgerFries.Value;
            decimal nudFood5 = nudSpaghetti.Value;

            decimal nudDrink1 = nudIcedTea.Value;
            decimal nudDrink2 = nudCoke.Value;
            decimal nudDrink3 = nudPineapple.Value;

            string chicken = "Chicken Rice Meal";
            string burgerSteak = "Burger Steak Rice Meal";
            string sisig = "Sisig Rice Meal";
            string burgerFries = "Burger with Fries";
            string spaghetti = "Spaghetti with Fries";

            string icedTea = "Iced Tea";
            string coke = "Coke";
            string pineapple = "Pineapple Juice";

            int chickenPrice = 100;
            int burgerSteakPrice = 90;
            int sisigPrice = 100;
            int burgerFriesPrice = 75;
            int spaghettiPrice = 80;

            int icedTeaPrice = 20;
            int cokePrice = 15;
            int pineapplePrice = 25;

            int total = 0;
            int orderId = 0;

            string id = "UPDATE Items SET Id = '" + orderId + "'";

            if (nudFood1 != 0 && orderId == 1)
            {
                //string food1 = "UPDATE OrdersItems SET name ='" + chicken + "', no_of_items ='" + nudFood1 + "'  WHERE order_no = '" + orderNo + "'";
                string food1 = "UPDATE Items SET name ='" + chicken + "', no_of_items ='" + nudFood1 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(food1, con);
                cmd.ExecuteNonQuery();
                total += chickenPrice * Convert.ToInt32(nudFood1);
            }
            if (nudFood2 != 0 && orderId == 2)
            {
                string food2 = "UPDATE OrdersItems SET name ='" + burgerSteak + "', no_of_items ='" + nudFood2 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(food2, con);
                cmd.ExecuteNonQuery();
                total += burgerSteakPrice * Convert.ToInt32(nudFood2);
            }
            if (nudFood3 != 0 && orderId == 3)
            {
                string food3 = "UPDATE OrdersItems SET name ='" + sisig + "', no_of_items ='" + nudFood3 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(food3, con);
                cmd.ExecuteNonQuery();
                total += sisigPrice * Convert.ToInt32(nudFood3);
            }
            if (nudFood4 != 0 && orderId == 4)
            {
                string food4 = "UPDATE OrdersItems SET name ='" + burgerFries + "', no_of_items ='" + nudFood4 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(food4, con);
                cmd.ExecuteNonQuery();
                total += burgerFriesPrice * Convert.ToInt32(nudFood4);

            }
            if (nudFood5 != 0 && orderId == 5)
            {
                string food5 = "UPDATE OrdersItems SET name ='" + spaghetti + "', no_of_items ='" + nudFood5 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(food5, con);
                cmd.ExecuteNonQuery();
                total += spaghettiPrice * Convert.ToInt32(nudFood5);

            }
            if (nudDrink1 != 0 && orderId == 6)
            {
                string drink1 = "UPDATE OrdersItems SET name ='" + icedTea + "', no_of_items ='" + nudDrink1 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(drink1, con);
                cmd.ExecuteNonQuery();
                total += icedTeaPrice * Convert.ToInt32(nudDrink1);

            }
            if (nudDrink2 != 0 && orderId == 7)
            {
                string drink2 = "UPDATE OrdersItems SET name ='" + coke + "', no_of_items ='" + nudDrink2 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(drink2, con);
                cmd.ExecuteNonQuery();
                total += cokePrice * Convert.ToInt32(nudDrink2);

            }
            if (nudDrink3 != 0 && orderId == 8)
            {
                string drink3 = "UPDATE OrdersItems SET name ='" + pineapple + "', no_of_items ='" + nudDrink3 + "'  WHERE order_no = '" + orderNo + "'";
                cmd = new SqlCommand(drink3, con);
                cmd.ExecuteNonQuery();
                total += pineapplePrice * Convert.ToInt32(nudDrink3);

            }

            txtTotalAmount.Text = total.ToString();


            //string abc = "UPDATE Items SET name ='" + chicken + "', no_of_items ='" + nudFood1 + "'  WHERE order_no = '" + orderNo + "'";
            //cmd = new SqlCommand(abc, con);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("One record updated");
            Display();
            con.Close();
        }

    }
}
