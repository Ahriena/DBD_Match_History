using System;
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
    public partial class Killer_Match : UserControl
    {
        readonly Random R = new();
        Data data = new Data();

        public Killer_Match()
        {
            InitializeComponent();
            Killer_Portrait.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));

            Perk1.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));
            Perk2.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));
            Perk3.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));
            Perk4.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));

            Survivor1.Source = new BitmapImage(data.Int_To_Survivor_Fate(R.Next() % 4));
            Survivor2.Source = new BitmapImage(data.Int_To_Survivor_Fate(R.Next() % 4));
            Survivor3.Source = new BitmapImage(data.Int_To_Survivor_Fate(R.Next() % 4));
            Survivor4.Source = new BitmapImage(data.Int_To_Survivor_Fate(R.Next() % 4));

            DateTime Today= DateTime.Now;
            DatePlayed.Text = Today.ToString("M/d/yyyy");
            MapPlayed.Text = data.Int_To_Map_Name(R.Next() % 39);

            string Game_Duration1 = (R.Next() % 60).ToString() + ":";
            int seconds = R.Next() % 60;
            if (seconds < 10)
            {
                Game_Duration1 += "0" + seconds.ToString();
            }
            else
            {
                Game_Duration1 += seconds.ToString();
            }

            Game_Duration.Text = Game_Duration1;
        }
    }
}
