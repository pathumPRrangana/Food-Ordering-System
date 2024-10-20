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

namespace Resturant_Management_System
{
    public partial class AdminLogin : Form
    {
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = adminnametxt.Text;
            string password = psswdtxt.Text;

            if (AuthenticateUser(username, password))
            {
                // Login successful, open the dashboard
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Close();
                AdminDashboard ad = new AdminDashboard();
                ad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                adminnametxt.Text = string.Empty;
                psswdtxt.Text = string.Empty;
            }

        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Admins WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isAuthenticated = true;
                    }
                }
            }

            return isAuthenticated;
        }

        private void showpsswdbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpsswdbox.Checked)
            {
                
                psswdtxt.PasswordChar = '\0';
            }
            else
            {
                
                psswdtxt.PasswordChar = '●';
            }
        }
    }
}
