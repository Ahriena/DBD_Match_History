using System;
using System.Collections.Generic;
using System.Windows;

namespace DBD_Match_History
{
    // likely prune later


    // code for modifying the backend
    public partial class MainWindow : Window
    {
        List<DBD_Game> All_Killer_Games = new List<DBD_Game>();

        // fills the list with 20 new, completely randomized games for use
        void Randomize_Games()
        {
            Random R = new Random();
            for (int i = 0; i < 20; i++)
            {
                DBD_Game game = new DBD_Game();
                game.Time_Played = DateTime.UtcNow;
            }
        }
    }
}