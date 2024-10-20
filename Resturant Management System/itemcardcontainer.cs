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
    public partial class itemcardcontainer : UserControl
    {
        int flag;
        string connectionString = @"Data Source=SHEHAN-HP15S\SQLEXPRESS;Initial Catalog=RESTURANT;Integrated Security=True";
        public itemcardcontainer(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }


        private void containerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemcardcontainer_Load(object sender, EventArgs e)
        {
            // DataTable dt = new DataTable();
            //dt.Rows.Add(new object[] {10});

            int rowCount = GetRowCountFromFoodsTable();
            List<int> foodIds = GetFoodIdsFromFoodsTable();

            foreach (int foodId in foodIds)
            {
                itemcard ic = new itemcard(foodId,flag);
                containerpanel.Controls.Add(ic);
            }

            /*for (int i = 0; i < rowCount; i++)
            {
                itemcard ic = new itemcard(i);
                containerpanel.Controls.Add(ic);
            }*/
        }

        private int GetRowCountFromFoodsTable()
        {
            int rowCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Foods";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    rowCount = (int)command.ExecuteScalar();
                }
            }
            return rowCount;
        }

        private List<int> GetFoodIdsFromFoodsTable()
        {
            List<int> foodIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT food_id FROM Foods";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int foodId = reader.GetInt32(0);
                        foodIds.Add(foodId);
                    }
                    reader.Close();
                }
            }
            return foodIds;
        }
    }
}
