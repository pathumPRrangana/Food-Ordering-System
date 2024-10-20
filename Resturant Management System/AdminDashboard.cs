using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class AdminDashboard : Form
    {
        


        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void menupanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void AdminDashboard_Load(object sender, EventArgs e)
        {
            orderHistory oh = new orderHistory();
            AdminItempnl.Controls.Add(oh);
        }

        private void foodsaddbtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(new addfoodform(1));
        }

        private void drinksaddbtn_Click(object sender, EventArgs e)
        {

            ShowUserControl(new addDrinksForm(2));
        }

        private void dessertsaddbtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(new addDessertsForm(3));
        }

        private void AdminItempnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowUserControl(UserControl userControl)
        {
            // Clear the panel before showing a new user control
            AdminItempnl.Controls.Clear();

            // Set the user control properties
            userControl.Dock = DockStyle.Fill;

            // Add the user control to the main panel
            AdminItempnl.Controls.Add(userControl);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
            this.Close();
        }

        private void orderhistorybtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(new orderHistory());
        }
    }
}
