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
    public partial class addDrinksForm : UserControl
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public addDrinksForm(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }
        private void addDrinksForm_Load(object sender, EventArgs e)
        {
            int rowCount = GetRowCountFromFoodsTable();
            List<int> drinkIds = GetDrinkIdsFromDrinksTable();

            foreach (int drinkId in drinkIds)
            {
                adminitemcard ac = new adminitemcard(drinkId,flag);
                addDrinkpnl.Controls.Add(ac);
            }

            additembtnpnl aib = new additembtnpnl(2);
            addDrinkpnl.Controls.Add(aib);
        }

        private int GetRowCountFromFoodsTable()
        {
            int rowCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Drinks";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    rowCount = (int)command.ExecuteScalar();
                }

            }
            return rowCount;
        }

        private List<int> GetDrinkIdsFromDrinksTable()
        {
            List<int> drinkIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT drink_id FROM Drinks";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int drinkId = reader.GetInt32(0);
                        drinkIds.Add(drinkId);
                    }
                    reader.Close();
                }
            }

            return drinkIds;
        }
    }
}
