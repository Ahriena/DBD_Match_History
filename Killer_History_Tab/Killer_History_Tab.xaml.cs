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


            Game1Perk1.Source = new BitmapImage(Int_To_Killer_Perk(53));
            Game1Perk2.Source = new BitmapImage(Int_To_Killer_Perk(54));
            Game1Perk3.Source = new BitmapImage(Int_To_Killer_Perk(55));
            Game1Perk4.Source = new BitmapImage(Int_To_Killer_Perk(56));

            Game2Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game2Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game2Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game2Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));

            Game3Perk1.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game3Perk2.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game3Perk3.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));
            Game3Perk4.Source = new BitmapImage(Int_To_Killer_Perk(R.Next() % 103));



        }
    }
}
