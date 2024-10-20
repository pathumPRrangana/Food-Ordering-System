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
    public partial class addDessertsForm : UserControl
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public addDessertsForm(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }
        private void addDessertsForm_Load(object sender, EventArgs e)
        {
            int rowCount = GetRowCountFromFoodsTable();
            List<int> dessertIds = GetDessertIdsFromDessertsTable();

            foreach (int dessertId in dessertIds)
            {
                adminitemcard ac = new adminitemcard(dessertId,flag);
                addDessertpnl.Controls.Add(ac);
            }

            additembtnpnl aib = new additembtnpnl(3);
            addDessertpnl.Controls.Add(aib);
        }

        private int GetRowCountFromFoodsTable()
        {
            int rowCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Desserts";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    rowCount = (int)command.ExecuteScalar();
                }

            }
            return rowCount;
        }

        private List<int> GetDessertIdsFromDessertsTable()
        {
            List<int> dessertIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT dessert_id FROM Desserts";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int dessertId = reader.GetInt32(0);
                        dessertIds.Add(dessertId);
                    }
                    reader.Close();
                }
            }

            return dessertIds;
        }
    }
}
