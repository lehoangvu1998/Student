using Project1.GUI;
using System;
using System.Windows.Forms;

namespace Project1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fKhoa());
        }
    }
}
