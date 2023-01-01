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
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Score_Screen_Character : UserControl
    {
        Random R = new Random();
        Data data = new Data();

        public Score_Screen_Character()
        {
            InitializeComponent();
        }

        public void Survivor_Character()
        {
            int Index = (R.Next() % 42);

            Portrait.Source = new BitmapImage(data.Int_To_Survivor_Portrait(Index));
            Character_Name.Text = data.Int_To_Survivor_Name(Index);

            Perk1.Source = new BitmapImage(data.Int_To_Survivor_Perk(12));
            Perk2.Source = new BitmapImage(data.Int_To_Survivor_Perk(13));
            Perk3.Source = new BitmapImage(data.Int_To_Survivor_Perk(14));
            Perk4.Source = new BitmapImage(data.Int_To_Survivor_Perk(15));
        }
        public void Killer_Character()
        {
            int Index = (R.Next() % 30);

            Portrait.Source = new BitmapImage(data.Int_To_Killer_Portrait(Index));
            Character_Name.Text = data.Int_To_Killer_Name(Index);
            Character_Name.Foreground = Brushes.Red;

            Perk1.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));
            Perk2.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));
            Perk3.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));
            Perk4.Source = new BitmapImage(data.Int_To_Killer_Perk(R.Next() % 103));


        }
    }
}
