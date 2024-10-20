using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Resturant_Management_System
{
    public partial class Dashboard : Form
    {
        

        String foodname;
        String qntity;
        String totprice;
        public Dashboard()
        {
            InitializeComponent();


        }

        public Dashboard(String foodname, String qntity, String tot)
        {
            this.foodname = foodname;
            this.qntity = qntity;
            totprice = tot;
            
        }


    

        private void Dashboard_Load(object sender, EventArgs e)
        {

            itemcardcontainer itemc = new itemcardcontainer(1);
            itemPanel.Controls.Add(itemc);
        }

        private void confirmorderbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminLoginbtn_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.ShowDialog();
        }

        private void fooditembtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(new itemcardcontainer(1));
        }

        private void drinkitembtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(new drinkitemsContainer(2));
        }

        private void dessertsitembtn_Click(object sender, EventArgs e)
        {
            ShowUserControl(new dessertsItemsContainer(3));
        }

        private void ShowUserControl(UserControl userControl)
        {
            // Clear the panel before showing a new user control
            itemPanel.Controls.Clear();

            // Set the user control properties
            userControl.Dock = DockStyle.Fill;

            // Add the user control to the main panel
            itemPanel.Controls.Add(userControl);
        }

    }
}

