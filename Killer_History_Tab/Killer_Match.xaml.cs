﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Killer_Match : UserControl
    {
        Random R = new Random();

        public Killer_Match()
        {
            InitializeComponent();
            Killer_Portrait.Source = new BitmapImage(Killer_History_Tab.Int_To_Killer_Portrait(R.Next() % 30));

            Perk1.Source = new BitmapImage(Killer_History_Tab.Int_To_Killer_Perk(R.Next() % 103));
            Perk2.Source = new BitmapImage(Killer_History_Tab.Int_To_Killer_Perk(R.Next() % 103));
            Perk3.Source = new BitmapImage(Killer_History_Tab.Int_To_Killer_Perk(R.Next() % 103));
            Perk4.Source = new BitmapImage(Killer_History_Tab.Int_To_Killer_Perk(R.Next() % 103));

            Survivor1.Source = new BitmapImage(Killer_History_Tab.Int_To_Survivor_Fate(R.Next() % 4));
            Survivor2.Source = new BitmapImage(Killer_History_Tab.Int_To_Survivor_Fate(R.Next() % 4));
            Survivor3.Source = new BitmapImage(Killer_History_Tab.Int_To_Survivor_Fate(R.Next() % 4));
            Survivor4.Source = new BitmapImage(Killer_History_Tab.Int_To_Survivor_Fate(R.Next() % 4));


        }
    }
}
