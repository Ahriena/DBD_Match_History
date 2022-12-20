using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DBD_Match_History
{
    public partial class Killer_History_Tab : UserControl
    {
        // converts an int into the associated killer portrait
        static private Uri Int_To_Killer_Portrait(int input)
        {
            /* 
             *  0 = Trapper
             *  1 = Wraith
             *  2 = Hillbilly
             *  3 = Nurse
             *  4 = Huntress
             *  5 = Myers
             *  6 = Hag
             *  7 = Doctor
             *  8 = Bubba
             *  9 = Freddy
             * 10 = Pig
             * 11 = Clown
             * 12 = Spirit
             * 13 = Legion
             * 14 = Plague
             * 15 = Ghostface
             * 16 = Demogorgon
             * 17 = Oni
             * 18 = Deathslinger
             * 19 = Pyramid Head
             * 20 = Blight
             * 21 = Twins
             * 22 = Trickster
             * 23 = Nemesis
             * 24 = Pinhead
             * 25 = Artist
             * 26 = Onryo
             * 27 = Dredge
             * 28 = Wesker
             * 29 = Knight
             */

            Uri image;
            switch (input)
            {
                case 0:
                    image = new(@"/Resources/Killer_Icons/Trapper_Portrait.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Killer_Icons/Wraith_Portrait.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Killer_Icons/Hillbilly_Portrait.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Killer_Icons/Nurse_Portrait.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Killer_Icons/Huntress_Portrait.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Killer_Icons/Shape_Portrait.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Killer_Icons/Hag_Portrait.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Killer_Icons/Doctor_Portrait.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Killer_Icons/Cannibal_Portrait.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Killer_Icons/Nightmare_Portrait.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Killer_Icons/Pig_Portrait.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"/Resources/Killer_Icons/Clown_Portrait.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Killer_Icons/Spirit_Portrait.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Killer_Icons/Legion_Portrait.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Killer_Icons/Plague_Portrait.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Killer_Icons/Ghost_Face_Portrait.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Killer_Icons/Demogorgon_Portrait.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Killer_Icons/Oni_Portrait.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Killer_Icons/Deathslinger_Portrait.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Killer_Icons/Executioner_Portrait.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Killer_Icons/Blight_Portrait.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Killer_Icons/Twins_Portrait.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Killer_Icons/Trickster_Portrait.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Killer_Icons/Nemesis_Portrait.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Killer_Icons/Cenobite_Portrait.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Killer_Icons/Artist_Portrait.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Killer_Icons/Onryo_Portrait.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Killer_Icons/Dredge_Portrait.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Killer_Icons/Mastermind_Portrait.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"/Resources/Killer_Icons/Knight_Portrait.png", UriKind.Relative);
                    return image;
                default:
                    image = new(@"/Resources/Misc/Missing_Person.png", UriKind.Relative);
                    return image;
            }
        }



        // converts an int into the associated killer portrait

        static private Uri Int_To_Killer_Perk(int input)
        {
            /*  ALPHABETICAL ORDER THROUGH KNIGHT RELEASE, THEN IN RELEASE ORDER
             *  Mostly because I can't be fucked to change every one every time a new character comes out
             * 
             *  0 = A nurses calling
             *  1 = Agitation
             *  2 = Awakened Awareness
             *  3 = Bamboozle
             *  4 = BBQ and chili
             *  5 = Beast of Prey
             *  6 = Bitter Murmur
             *  7 = Blood Echo
             *  8 = Blood Warden
             *  9 = Bloodhound
             * 10 = Brutal Strength
             *
             *
             *
             *
             *
             *
             *
             *
             */



            Uri image;
            switch (input)
            {
                case 0:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ANursesCalling.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Agitation.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Killer_Perks/IconPerks_AwakenedAwareness.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Bamboozle.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Killer_Perks/IconPerks_BarbecueAndChilli.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Killer_Perks/IconPerks_BeastOfPrey.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Killer_Perks/IconPerks_BitterMurmur.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Killer_Perks/IconPerks_BloodEcho.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Killer_Perks/IconPerks_BloodWarden.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Bloodhound.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Killer_Perks/IconPerks_BrutalStrength.png", UriKind.Relative);
                    return image;

                default:
                    image = new(@"/Resources/Misc/Transparent_Background.png", UriKind.Relative);
                    return image;

            }
        }

    }
}
