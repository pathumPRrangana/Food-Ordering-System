using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class itemcard : UserControl
    {
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        int i;
        int flag;
        public itemcard(int i, int flag)
        {
            InitializeComponent();
            this.i = i;
            this.flag = flag;
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            

           ItemOrderForm itemOrderForm = new ItemOrderForm(i,flag);
            itemOrderForm.ShowDialog();
        }

        private void itemcard_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string query = "SELECT name, regular_price, large_price, availability FROM Foods WHERE food_id = @foodId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@foodId", i);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string foodName = reader.GetString(0);
                        decimal regularPrice = reader.GetDecimal(1);
                        decimal largePrice = reader.GetDecimal(2);
                        bool availability = reader.GetBoolean(3);

                        itemname.Text = foodName;
                        regularpricelbl.Text = regularPrice.ToString();
                        largepricelbl.Text = largePrice.ToString();

                        if (availability)
                        {
                            availabilitylbl.Text = "Available";
                        }
                        else
                        {
                            availabilitylbl.Text = "Currently Unavailable";
                        }
                    }

                    reader.Close();
                }
            }
            else if (flag == 2)
            {
                string query = "SELECT name, regular_price, large_price, availability FROM Drinks WHERE drink_id = @DrinkId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DrinkId", i);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string foodName = reader.GetString(0);
                        decimal regularPrice = reader.GetDecimal(1);
                        decimal largePrice = reader.GetDecimal(2);
                        bool availability = reader.GetBoolean(3);

                        itemname.Text = foodName;
                        regularpricelbl.Text = regularPrice.ToString();
                        largepricelbl.Text = largePrice.ToString();

                        if (availability)
                        {
                            availabilitylbl.Text = "Available";
                        }
                        else
                        {
                            availabilitylbl.Text = "Currently Unavailable";
                        }
                    }

                    reader.Close();
                }
            }
            else if (flag == 3)
            {
                string query = "SELECT name, regular_price, large_price, availability FROM Desserts WHERE dessert_id = @DessertId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DessertId", i);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string foodName = reader.GetString(0);
                        decimal regularPrice = reader.GetDecimal(1);
                        decimal largePrice = reader.GetDecimal(2);
                        bool availability = reader.GetBoolean(3);

                        itemname.Text = foodName;
                        regularpricelbl.Text = regularPrice.ToString();
                        largepricelbl.Text = largePrice.ToString();

                        if (availability)
                        {
                            availabilitylbl.Text = "Available";
                        }
                        else
                        {
                            availabilitylbl.Text = "Currently Unavailable";
                        }
                    }

                    reader.Close();
                }
            }
            
        }

        
    }
}
