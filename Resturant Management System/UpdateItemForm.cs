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
    public partial class UpdateItemForm : Form
    {

        int foodid;
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public UpdateItemForm(int foodid, int flag)
        {
            InitializeComponent();
            this.foodid = foodid;
            this.flag = flag;
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string query = "SELECT name, available_size, availability, regular_price, large_price FROM Foods WHERE food_id = @FoodId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FoodId", foodid);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            itemname.Text = reader["name"].ToString();
                            string availablesize = reader["available_size"].ToString();
                            if (availablesize == "All")
                            {
                                regularsize.Checked = true;
                                Large.Checked = true;
                                regularprice.Text = reader["regular_price"].ToString();
                                largeprice.Text = reader["large_price"].ToString();
                            }
                            else if (availablesize == "Regular")
                            {
                                regularsize.Checked = true;
                                Large.Checked = false;
                                regularprice.Text = reader["regular_price"].ToString();
                                largeprice.Text = "No Large";
                            }
                            else if (availablesize == "Large")
                            {
                                regularsize.Checked = false;
                                Large.Checked = true;
                                regularprice.Text = "No Regular";
                                largeprice.Text = reader["large_price"].ToString();
                            }

                            string availability = reader["availability"].ToString();
                            if (availability == "True")
                            {
                                yesavailability.Checked = true;
                                noavailability.Checked = false;
                            }
                            else if (availability == "False")
                            {
                                yesavailability.Checked = false;
                                noavailability.Checked = true;
                            }
                            else
                            {
                                yesavailability.Checked = false;
                                noavailability.Checked = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No data found for the given food id.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (flag == 2)
            {
                string query = "SELECT name, available_size, availability, regular_price, large_price FROM Drinks WHERE drink_id = @DrinkId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DrinkId", foodid);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            itemname.Text = reader["name"].ToString();
                            string availablesize = reader["available_size"].ToString();
                            if (availablesize == "All")
                            {
                                regularsize.Checked = true;
                                Large.Checked = true;
                                regularprice.Text = reader["regular_price"].ToString();
                                largeprice.Text = reader["large_price"].ToString();
                            }
                            else if (availablesize == "Regular")
                            {
                                regularsize.Checked = true;
                                Large.Checked = false;
                                regularprice.Text = reader["regular_price"].ToString();
                                largeprice.Text = "No Large";
                            }
                            else if (availablesize == "Large")
                            {
                                regularsize.Checked = false;
                                Large.Checked = true;
                                regularprice.Text = "No Regular";
                                largeprice.Text = reader["large_price"].ToString();
                            }

                            string availability = reader["availability"].ToString();
                            if (availability == "True")
                            {
                                yesavailability.Checked = true;
                                noavailability.Checked = false;
                            }
                            else if (availability == "False")
                            {
                                yesavailability.Checked = false;
                                noavailability.Checked = true;
                            }
                            else
                            {
                                yesavailability.Checked = false;
                                noavailability.Checked = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No data found for the given food id.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (flag == 3)
            {
                string query = "SELECT name, available_size, availability, regular_price, large_price FROM Desserts WHERE dessert_id = @DessertId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DessertId", foodid);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            itemname.Text = reader["name"].ToString();
                            string availablesize = reader["available_size"].ToString();
                            if (availablesize == "All")
                            {
                                regularsize.Checked = true;
                                Large.Checked = true;
                                regularprice.Text = reader["regular_price"].ToString();
                                largeprice.Text = reader["large_price"].ToString();
                            }
                            else if (availablesize == "Regular")
                            {
                                regularsize.Checked = true;
                                Large.Checked = false;
                                regularprice.Text = reader["regular_price"].ToString();
                                largeprice.Text = "No Large";
                                largeprice.Enabled = false;
                            }
                            else if (availablesize == "Large")
                            {
                                regularsize.Checked = false;
                                Large.Checked = true;
                                regularprice.Text = "No Regular";
                                regularprice.Enabled = false;
                                largeprice.Text = reader["large_price"].ToString();
                            }

                            string availability = reader["availability"].ToString();
                            if (availability == "True")
                            {
                                yesavailability.Checked = true;
                                noavailability.Checked = false;
                            }
                            else if (availability == "False")
                            {
                                yesavailability.Checked = false;
                                noavailability.Checked = true;
                            }
                            else
                            {
                                yesavailability.Checked = false;
                                noavailability.Checked = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No data found for the given food id.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
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

            decimal regularPrice = decimal.Parse(regularprice.Text);
            decimal largePrice = decimal.Parse(largeprice.Text);
            bool availability = yesavailability.Checked;

            // Save data to the database
            SaveToDatabase(foodid, itemName, availableSize, availability, regularPrice, largePrice);
        }

        private void SaveToDatabase(int foodid, string itemName, string availableSize, bool availability, decimal regularPrice, decimal largePrice)
        {
            if (flag == 1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Foods 
                         SET name = @Name, 
                             available_size = @Size, 
                             availability = @Availability, 
                             regular_price = @RegularPrice, 
                             large_price = @LargePrice, 
                             picture_url = @PictureURL
                         WHERE food_id = @FoodId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodId", foodid);
                        command.Parameters.AddWithValue("@Name", itemName);
                        command.Parameters.AddWithValue("@Size", availableSize);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        command.Parameters.AddWithValue("@LargePrice", largePrice);



                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Database update successful.");
                                this.Hide(); // Hide the form if the update is successful
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating database: " + ex.Message);
                        }
                        this.Hide();
                    }
                }
            }

            else if (flag == 2)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Drinks 
                                SET name = @Name,
                                    available_size = @Size,
                                    availability = @Availability, 
                                    regular_price = @RegularPrice, 
                                    large_price = @LargePrice
                                WHERE drink_id = @DrinkId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DrinkId", foodid);
                        command.Parameters.AddWithValue("@Name", itemName);
                        command.Parameters.AddWithValue("@Size", availableSize);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        command.Parameters.AddWithValue("@LargePrice", largePrice);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Database update successful.");
                                this.Hide(); // Hide the form if the update is successful
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating database: " + ex.Message);
                        }
                        this.Hide();
                    }
                }
            }

            else if (flag == 3)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Desserts 
                                SET name = @Name,
                                    available_size = @Size,
                                    availability = @Availability, 
                                    regular_price = @RegularPrice, 
                                    large_price = @LargePrice, 
                                    picture_url = @PictureURL
                                WHERE dessert_id = @DessertId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DessertId", foodid);
                        command.Parameters.AddWithValue("@Name", itemName);
                        command.Parameters.AddWithValue("@Size", availableSize);
                        command.Parameters.AddWithValue("@Availability", availability);
                        command.Parameters.AddWithValue("@RegularPrice", regularPrice);
                        command.Parameters.AddWithValue("@LargePrice", largePrice);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Database update successful.");
                                this.Hide(); // Hide the form if the update is successful
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error updating database: " + ex.Message);
                        }
                        this.Hide();
                    }
                }
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteRowFromDatabase(foodid);
        }

        private void DeleteRowFromDatabase(int foodId)
        {
            if (flag == 1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Foods WHERE food_id = @FoodId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FoodId", foodId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Row deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows deleted. Row with food_id " + foodId + " not found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting row: " + ex.Message);
                        }
                    }
                }
            }
            
            else if (flag == 2)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Drinks WHERE drink_id = @DrinkId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DrinkId", foodId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Row deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows deleted. Row with food_id " + foodId + " not found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting row: " + ex.Message);
                        }
                    }
                }
            }
            else if (flag == 3)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Desserts WHERE dessert_id = @DessertId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DessertId", foodId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Row deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows deleted. Row with food_id " + foodId + " not found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting row: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
