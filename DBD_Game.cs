using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBD_Match_History
{
    public struct Unit_Information
    {
        int ID { set; get; }
        string Name { set; get; }
        string Description { set; get; }
    }

    public class Character
    {
        Unit_Information Character_Name { set; get; }
        Unit_Information Character_ID { set; get; }
        Unit_Information Perk1 { set; get; }
        Unit_Information Perk2 { set; get; }
        Unit_Information Perk3 { set; get; }
        Unit_Information Perk4 { set; get; }
        Unit_Information Offering { set; get; }
        Unit_Information Addon1 { set; get; }
        Unit_Information Addon2 { set; get; }
        int Score { set; get; }
        bool Player_Character { set; get; }
    };

    public class Killer : Character
    {
        int kills { set; get; }
    }

    public class Survivor : Character
    {
        Unit_Information Item { set; get; }
    }

    public class DBD_Game
    {
        public Survivor? Survivor1 { set; get; }
        public Survivor? Survivor2 { set; get; }
        public Survivor Survivor3 { set; get; }
        public Survivor Survivor4 { set; get; }
        public Killer Killer { set; get; }

        // MAKE THIS INTO A TIME VARIABLE LATER WHEN WE FIGURE OUT WHAT FORMAT WE WANT
        public string Game_Duration;
        //                              TODO                      

        public DateTime Time_Played { set; get; }
    }   
}
