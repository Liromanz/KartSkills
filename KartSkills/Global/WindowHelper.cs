using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KartSkills.Global
{
    public class WindowHelper
    {
        public Window MainWindow = Application.Current.MainWindow;

        public static void OpenNewWindow(Window window)
        {
            Application.Current.MainWindow = window;
            Application.Current.MainWindow.Show();
        }
    }
}
