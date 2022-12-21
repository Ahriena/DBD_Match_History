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
            SolidColorBrush test = new(Colors.DarkBlue);
            test.Opacity = 0;
            Game1.Fill = test;

            Uri image = new(@"/Resources/Killer_Icons/Twins_Portrait.png", UriKind.Relative);

            Testing.Killer_Portrait.Source = new BitmapImage(Int_To_Killer_Portrait(100));





            Game1Image.Source = new BitmapImage(Int_To_Killer_Portrait(100));
            Game2Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game3Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game4Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game5Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game6Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game7Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game8Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game9Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));
            Game10Image.Source = new BitmapImage(Int_To_Killer_Portrait(R.Next() % 30));


            Game1Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game1Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game1Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game1Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game2Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game2Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game2Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game2Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game3Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game3Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game3Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game3Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game4Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game4Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game4Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game4Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game5Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game5Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game5Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game5Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game6Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game6Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game6Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game6Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game7Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game7Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game7Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game7Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game8Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game8Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game8Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game8Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game9Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game9Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game9Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game9Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game10Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game10Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game10Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game10Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
        }
    }
}
