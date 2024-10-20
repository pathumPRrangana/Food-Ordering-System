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
    public partial class Messagebox : Form
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public Messagebox(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Messagebox_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string query = "SELECT TOP 1 food_order_id, total_price FROM FOOD_ORDER ORDER BY food_order_id DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        decimal price = reader.GetDecimal(1);

                        ordernolbl.Text = orderId.ToString();
                        billpricelbl.Text = price.ToString();
                    }

                    reader.Close();
                }
            }

            else if (flag == 2)
            {
                string query = "SELECT TOP 1 drink_order_id, total_price FROM Drink_ORDER ORDER BY drink_order_id DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        decimal price = reader.GetDecimal(1);

                        ordernolbl.Text = orderId.ToString();
                        billpricelbl.Text = price.ToString();
                    }

                    reader.Close();
                }
            }
            else if (flag == 3)
            {
                string query = "SELECT TOP 1 dessert_order_id, total_price FROM Dessert_ORDER ORDER BY dessert_order_id DESC";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        decimal price = reader.GetDecimal(1);

                        ordernolbl.Text = orderId.ToString();
                        billpricelbl.Text = price.ToString();
                    }

                    reader.Close();
                }
            }
            
        }
    }
}
