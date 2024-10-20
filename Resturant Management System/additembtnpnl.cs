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
    
    public partial class additembtnpnl : UserControl
    {
        int flag;
        public additembtnpnl(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void additembtn_Click(object sender, EventArgs e)
        {
            AddingItemForm aif = new AddingItemForm(flag);
            aif.ShowDialog();
        }
    }
}
