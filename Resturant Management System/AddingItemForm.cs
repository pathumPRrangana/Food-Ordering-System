using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class AddingItemForm : Form
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public AddingItemForm(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void AddingItemForm_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string itemName = itemname.Text;
            string availableSize = "";
            if (regularsize.Checked && Large.Checked)
            {
                availableSize = "All";

            }
            else if (regularsize.Checked)
            {
                availableSize = "Regular";
            }
            else if (Large.Checked)
            {
                availableSize = "Large";
            }


            decimal regularPrice = 0.00m;
            decimal largePrice = 0.00m;

            try
            {
                if (!string.IsNullOrWhiteSpace(regularprice.Text))
                {
                    regularPrice = decimal.Parse(regularprice.Text);
                }

                if (!string.IsNullOrWhiteSpace(largeprice.Text))
                {
                    largePrice = decimal.Parse(largeprice.Text);
                }
            }
            catch (FormatException)
            {
                regularPrice = 0.00m;
                largePrice = 0.00m;
            }

            bool availability = yesavailability.Checked;

            // Save data to the database
            SaveToDatabase(itemName, availableSize, availability, regularPrice, largePrice);

            

           
             
            /*AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.AdminDashboard_Load(null, EventArgs.Empty);*/

            this.Hide();

        }

        

        private void SaveToDatabase(string itemName, string availableSize, bool availability, decimal regularPrice, decimal largePrice)
        {
            if (flag == 1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Foods (name, available_size, availability, regular_price, large_price) 
                                VALUES (@Name, @Size, @Availability, @RegularPrice, @LargePrice)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", itemName);
                        command.Parameters.AddWithValue("@Size", availableSize);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        command.Parameters.AddWithValue("@LargePrice", largePrice);
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else if (flag == 2) {

                
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Drinks (name, available_size, availability, regular_price, large_price) 
                                VALUES (@Name, @Size, @Availability, @RegularPrice, @LargePrice)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", itemName);
                        command.Parameters.AddWithValue("@Size", availableSize);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        command.Parameters.AddWithValue("@LargePrice", largePrice);
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else if (flag == 3)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Desserts (name, available_size, availability, regular_price, large_price) 
                                VALUES (@Name, @Size, @Availability, @RegularPrice, @LargePrice)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", itemName);
                        command.Parameters.AddWithValue("@Size", availableSize);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        command.Parameters.AddWithValue("@LargePrice", largePrice);
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            
        }

        
    }
}
