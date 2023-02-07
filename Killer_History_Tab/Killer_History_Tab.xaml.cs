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
using System.Windows.Markup;
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
        Data data = new Data();

        public Killer_History_Tab()
        {
            InitializeComponent();
            Recent_Killer_Matches.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                var Test = new Killer_Match();
                Recent_Killer_Matches.Items.Add(Test);
            }

            Player1.Survivor_Character();
            Player2.Survivor_Character();
            Player3.Survivor_Character();
            Player4.Survivor_Character();
            Player5.Killer_Character();

            Player1.Item.Source = new BitmapImage(data.Int_To_Survivor_Item(R.Next() % 30));
            Player2.Item.Source = new BitmapImage(data.Int_To_Survivor_Item(R.Next() % 30));
            Player3.Item.Source = new BitmapImage(data.Int_To_Survivor_Item(R.Next() % 30));
            Player4.Item.Source = new BitmapImage(data.Int_To_Survivor_Item(R.Next() % 30));
            Player5.Item.Source = new BitmapImage(data.Int_To_Killer_Power(R.Next() % 31));

            Player1.Addon1.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 0));
            Player1.Addon2.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 1)); 
            
            Player2.Addon1.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 2)); 
            Player2.Addon2.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 3)); 
            
            Player3.Addon1.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 4));
            Player3.Addon2.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 5));
            
            Player4.Addon1.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 6)); 
            Player4.Addon2.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 7)); 
            
            Player5.Addon1.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 8)); 
            Player5.Addon2.Source = new BitmapImage(data.Int_To_Survivor_Addon(6, 9));


        }

        // scroll wheel functionality for the scrollviewer object
        private void ScrollViewer_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
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
