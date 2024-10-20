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
    public partial class dessertsItemsContainer : UserControl
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public dessertsItemsContainer(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void dessertsItemsContainer_Load(object sender, EventArgs e)
        {
            int rowCount = GetRowCountFromDessertsTable();
            List<int> dessertIds = GetDessertsIdsFromDessertsTable();

            foreach (int dessertId in dessertIds)
            {
                itemcard ic = new itemcard(dessertId, flag);
                dessertItempnl.Controls.Add(ic);
            }

        }

        private int GetRowCountFromDessertsTable()
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

        private List<int> GetDessertsIdsFromDessertsTable()
        {
            List<int> dessertsIds = new List<int>();

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
                        dessertsIds.Add(dessertId);
                    }
                    reader.Close();
                }
            }

            return dessertsIds;
        }
    }
}
