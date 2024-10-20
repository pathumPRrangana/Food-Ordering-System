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
    public partial class orderHistory : UserControl
    {
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";

        public orderHistory()
        {
            InitializeComponent();
        }

        private void orderHistory_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView controls
            LoadFoodOrderData();
            LoadDrinkOrderData();
            LoadDessertOrderData();
        }

        private void LoadFoodOrderData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT foodname AS [Food Name], quantity AS [Quantity], total_price AS [Total Price] FROM FOOD_ORDER";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                foodorderhistory.DataSource = table;

                // Set header font properties
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);
                foodorderhistory.ColumnHeadersDefaultCellStyle = headerStyle;
            }
        }

        private void LoadDrinkOrderData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT drinkname AS [Drink Name], quantity AS [Quantity], total_price AS [Total Price] FROM Drink_ORDER";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                drinkOrderhistory.DataSource = table;

                // Set header font properties
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);
                drinkOrderhistory.ColumnHeadersDefaultCellStyle = headerStyle;
            }
        }

        private void LoadDessertOrderData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT dessertname AS [Dessert Name], quantity AS [Quantity], total_price AS [Total Price] FROM Dessert_ORDER";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dessertorderHistory.DataSource = table;

                // Set header font properties
                DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
                headerStyle.Font = new Font("Segoe UI", 10.2f, FontStyle.Bold);
                dessertorderHistory.ColumnHeadersDefaultCellStyle = headerStyle;
            }
        }
    }
}
