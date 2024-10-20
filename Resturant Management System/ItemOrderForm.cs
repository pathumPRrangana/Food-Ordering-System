using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Resturant_Management_System
{
    public partial class ItemOrderForm : Form
    {
        int foodId;
        string foodname;
        string regularPrice;
        string largePrice;
        string Total;
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";

        public ItemOrderForm(int foodId, int flag)
        {
            InitializeComponent();
            this.foodId = foodId;
            this.flag = flag;
        }

        private void addorderbtn_Click(object sender, EventArgs e)
        {
            string size = foodsizetxt.SelectedItem.ToString();
            string qntity = quantity.Text.ToString();
            double regprice = double.Parse(regularPrice);
            double lprice = double.Parse(largePrice);
            double q = Convert.ToDouble(quantity.Text);
            double tot;

            if (size == "Regular")
            {
                tot = q * regprice;
            }
            else if (size == "Large")
            {
                tot = q * lprice;
            }
            else
            {
                return;
            }

            Total = Convert.ToString(tot);

            // Insert order data into the database
            try
            {
                if (flag == 1)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO FOOD_ORDER (food_id, quantity, total_price,foodname) 
                  VALUES (@FoodId, @Quantity, @TotalPrice,@FoodName)";

                        SqlCommand command = new SqlCommand(query, connection);
                        
                        command.Parameters.AddWithValue("@FoodId", foodId);
                        command.Parameters.AddWithValue("@Quantity", qntity);
                        command.Parameters.AddWithValue("@TotalPrice", Total);
                        command.Parameters.AddWithValue("@FoodName", foodname);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Messagebox messagebox = new Messagebox(flag);
                            messagebox.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save order!");
                        }
                    }
                }
                else if (flag == 2)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO Drink_ORDER (drink_id, quantity, total_price,drinkname) 
                         VALUES (@DrinkId, @Quantity, @TotalPrice, @Drinkname)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DrinkId", foodId);
                        command.Parameters.AddWithValue("@Quantity", qntity);
                        command.Parameters.AddWithValue("@TotalPrice", Total);
                        command.Parameters.AddWithValue("@Drinkname", foodname);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Messagebox messagebox = new Messagebox(flag);
                            messagebox.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save order!");
                        }
                    }
                }
                else if (flag == 3)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO Dessert_ORDER (dessert_id, quantity, total_price,dessertname) 
                         VALUES (@DessertId, @Quantity, @TotalPrice, @Dessertname)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@DessertId", foodId);
                        command.Parameters.AddWithValue("@Quantity", qntity);
                        command.Parameters.AddWithValue("@TotalPrice", Total);
                        command.Parameters.AddWithValue("@Dessertname", foodname);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Messagebox messagebox = new Messagebox(flag);
                            messagebox.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save order!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Close the current form
            this.Close();

            
        }

        private void ItemOrderForm_Load(object sender, EventArgs e)
        {
         
            if (flag == 1)
            {
                string query = "SELECT name, available_size, regular_price, large_price FROM Foods WHERE food_id = @FoodId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FoodId", foodId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            foodnametxt.Text = reader["name"].ToString();
                            String sizes = reader["available_size"].ToString();
                            regulerpriselbl.Text = reader["regular_price"].ToString();
                            largepricelbl.Text = reader["large_price"].ToString();

                            foodname = reader["name"].ToString();
                            regularPrice = reader["regular_price"].ToString();
                            largePrice = reader["large_price"].ToString();

                            if (sizes == "All")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Regular");
                                foodsizetxt.Items.Add("Large");
                            }
                            else if (sizes == "Regular")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Regular");
                            }
                            else if (sizes == "Large")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Large");
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
                string query = "SELECT name, available_size, regular_price, large_price FROM Drinks WHERE drink_id = @DrinkId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DrinkId", foodId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            foodnametxt.Text = reader["name"].ToString();
                            String sizes = reader["available_size"].ToString();
                            regulerpriselbl.Text = reader["regular_price"].ToString();
                            largepricelbl.Text = reader["large_price"].ToString();

                            foodname = reader["name"].ToString();
                            regularPrice = reader["regular_price"].ToString();
                            largePrice = reader["large_price"].ToString();

                            if (sizes == "All")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Regular");
                                foodsizetxt.Items.Add("Large");
                            }
                            else if (sizes == "Regular")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Regular");
                            }
                            else if (sizes == "Large")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Large");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given drink id.");
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
                string query = "SELECT name, available_size, regular_price, large_price FROM Desserts WHERE dessert_id = @DessertId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DessertId", foodId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            foodnametxt.Text = reader["name"].ToString();
                            String sizes = reader["available_size"].ToString();
                            regulerpriselbl.Text = reader["regular_price"].ToString();
                            largepricelbl.Text = reader["large_price"].ToString();

                            foodname = reader["name"].ToString();
                            regularPrice = reader["regular_price"].ToString();
                            largePrice = reader["large_price"].ToString();

                            if (sizes == "All")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Regular");
                                foodsizetxt.Items.Add("Large");
                            }
                            else if (sizes == "Regular")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Regular");
                            }
                            else if (sizes == "Large")
                            {
                                foodsizetxt.Items.Clear();

                                // Add items one by one
                                foodsizetxt.Items.Add("Large");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given dessert id.");
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

    }
}