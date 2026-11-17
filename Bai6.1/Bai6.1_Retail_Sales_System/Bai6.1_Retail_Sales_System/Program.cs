using Bai6._1_Retail_Sales_System.GUI;
using System;
using System.Windows.Forms;

namespace Bai6._1_Retail_Sales_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}