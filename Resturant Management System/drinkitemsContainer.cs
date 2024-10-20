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
    public partial class drinkitemsContainer : UserControl
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public drinkitemsContainer(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void drinkitemsContainer_Load(object sender, EventArgs e)
        {
            int rowCount = GetRowCountFromDrinksTable();
            List<int> drinkIds = GetDrinksIdsFromDrinksTable();

            foreach (int drinkId in drinkIds)
            {
                itemcard ic = new itemcard(drinkId, flag);
                drinkItemcontainerpnl.Controls.Add(ic);
            }
        }

        private int GetRowCountFromDrinksTable()
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

        private List<int> GetDrinksIdsFromDrinksTable()
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
