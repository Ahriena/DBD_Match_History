﻿using Microsoft.Win32;
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
            Recent_Killer_Matches.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                var Test = new Killer_Match();
                Recent_Killer_Matches.Items.Add(Test);
            }
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
            //SolidColorBrush test = new(Colors.DarkBlue);
            //test.Opacity = 0;





        }

        private void AddItem(object sender, RoutedEventArgs e)
        {
            var Test = new Killer_Match();
            Recent_Killer_Matches.Items.Insert(0, Test);

            while (Recent_Killer_Matches.Items.Count >= 21)
            {
                Recent_Killer_Matches.Items.RemoveAt(Recent_Killer_Matches.Items.Count - 1);
            }

        }

        private void ModItem(object sender, RoutedEventArgs e)
        {
            if (Recent_Killer_Matches.Items.Count == 0)
            {
                return;
            }
            
            var Test = Recent_Killer_Matches.Items.GetItemAt(0) as Killer_Match;

            Test.Game_Duration.Text = "0";

            //Recent_Killer_Matches.Items.Clear();


        }
    }
}
