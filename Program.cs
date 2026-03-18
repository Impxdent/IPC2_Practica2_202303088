using System;
using System.Windows.Forms;

namespace IPC2_Practica2_202303088
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}