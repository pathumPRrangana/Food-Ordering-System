﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Customer());
            Application.Run(new Dashboard());
            //Application.Run(new ItemOrderForm());
            //Application.Run(new AdminDashboard());
            //Application.Run(new adminitemform());
            //Application.Run(new AdminLogin());
        }
    }
}