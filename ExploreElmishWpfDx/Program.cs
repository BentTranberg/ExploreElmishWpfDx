using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ExploreElmishWpfDx
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application app = new Application();
            Window mainWindow = new MainWindow();
            ExploreElmishWpfDx.Models.MainWindow.entryPoint(args, mainWindow);
        }
    }
}
