using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DBD_Match_History
{
    /// <summary>
    /// Interaction logic for Killer History Tab.xaml
    /// </summary>
    public partial class Killer_History_Tab : UserControl
    {
        Random R = new Random();

        public Killer_History_Tab()
        {
            InitializeComponent();
            Change_Stuff();
        }

        // scroll wheel functionality for the scrollviewer object
        private void ScrollViewer_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        //randomly modifies stuff for testing
        private void Change_Stuff()
        {



        }
    }
}
