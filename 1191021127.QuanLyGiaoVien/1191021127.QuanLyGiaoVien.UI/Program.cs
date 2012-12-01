using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _1191021127.QuanLyGiaoVien.UI.Common;

namespace _1191021127.QuanLyGiaoVien.UI
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
            Application.Run(new DangNhap());
        }
    }
}
