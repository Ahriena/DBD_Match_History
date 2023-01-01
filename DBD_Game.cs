using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBD_Match_History
{
    struct Name_And_ID
    {
        int ID;
        string Name;
    }

    struct Character
    {
        Name_And_ID Character_Name;
        Name_And_ID Perk1;
        Name_And_ID Perk2;
        Name_And_ID Perk3;
        Name_And_ID Perk4;
        Name_And_ID Offering;
        Name_And_ID Item_Or_Power;
        Name_And_ID Addon1;
        Name_And_ID Addon2;
        Name_And_ID Outcome;
        int Score;
        bool Player_Character;
    };

    class DBD_Game
    {
        Character Survivor1;
        Character Survivor2;
        Character Survivor3;
        Character Survivor4;
        Character Killer;

        // MAKE THIS INTO A TIME VARIABLE LATER WHEN WE FIGURE OUT WHAT WE WANT
        string Game_Duration;
        //                              TODO                      


        DateTime Date_Played;
        DateTime Time_Played;


    }   
}
