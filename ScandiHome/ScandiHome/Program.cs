﻿using ScandiHome.Settings;
using System;
using System.Windows.Forms;

namespace ScandiHome
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmST_Quota());
        }
    }
}
