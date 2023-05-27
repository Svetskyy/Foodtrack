using System.Data.SqlClient;

namespace FoodTrack
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Create Connection object
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //If Txtbox is Empty
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUname.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill out all the boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Register Account
                con = new SqlConnection("Data Source=LAPTOP-TRISH\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
                con.Open();
                string a = txtName.Text;
                string b = txtEmail.Text;
                string c = txtUname.Text;
                string d = txtPassword.Text;
                cmd = new SqlCommand("Insert Into Registration values ('" + a + "','" + b + "', '" + c + "', '" + d + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("One Record Added");

                txtName.Clear();
                txtEmail.Clear();
                txtUname.Clear();
                txtPassword.Clear();

                Login logform = new Login();
                this.Hide();
                logform.Show();
            }
                        
        }

        private void lbliLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lbliLogin.LinkVisited = true;

            Login logform = new Login();
            this.Hide();
            logform.Show();
        }
    }
}