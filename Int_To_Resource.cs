using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace DBD_Match_History
{
    // used to convert integer values into images
    public class Data
    {
        // converts an int into the associated killer portrait
        public Uri Int_To_Killer_Portrait(int input)
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

        // converts int to a killer power
        public Uri Int_To_Killer_Power(int input)
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
                    image = new(@"/Resources/Killer_Powers/IconPowers_Trap.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Killer_Powers/IconPowers_Bell.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Killer_Powers/IconPowers_Chainsaw.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Killer_Powers/IconPowers_Breath.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Killer_Powers/IconPowers_HuntingHatchets.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Killer_Powers/IconPowers_Stalker.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Killer_Powers/IconPowers_BlackenedCatalyst.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Killer_Powers/IconPowers_CartersSpark.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Killer_Powers/IconPowers_BubbasChainsaw.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Killer_Powers/IconPowers_DreamDemon.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Killer_Powers/IconPowers_JigsawsBaptism.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"/Resources/Killer_Powers/IconPowers_GasBomb.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Killer_Powers/IconPowers_YamaokasHaunting.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Killer_Powers/IconPowers_FeralFrenzy.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Killer_Powers/IconPowers_VilePurge.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Killer_Powers/IconPowers_NightShroud.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Killer_Powers/IconPowers_OfTheAbyss.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Killer_Powers/IconPowers_YamaokasWrath.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Killer_Powers/IconPowers_TheRedeemer.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Killer_Powers/IconPowers_RitesOfJudgement.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Killer_Powers/IconPowers_BlightedCorruption.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Killer_Powers/IconPowers_BloodBond.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Killer_Powers/IconPowers_Showstopper.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Killer_Powers/IconPowers_T-Virus.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Killer_Powers/IconPowers_SummonsOfPain.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Killer_Powers/IconPowers_BirdsOfTorment.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Killer_Powers/IconPowers_DelugeOfFear.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Killer_Powers/IconPowers_ReignOfDarkness.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Killer_Powers/IconPowers_VirulentBound.png", UriKind.Relative);
                    return image;


                    // THIS ONE IS DIFFERENT BECAUSE I COULDN'T FIND THE ICON WITH A TRANSPARENT BACKGROUND
                    // YES I AM ANGRY ABOUT IT
                case 29:
                    image = new(@"/Resources/Killer_Powers/IconPowers_Guardia.png", UriKind.Relative);
                    return image;
                default:
                    image = new(@"/Resources/Misc/Transparent_Background.png", UriKind.Relative);
                    return image;
            }
        }

        // converts int to a killer power
        public Uri Int_To_Killer_Addon(int killer, int input)
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
            switch(killer)
            {

                // trapper
                case 0:
                    switch(input)
                    {
                        /*
                         * 0 = bloody coil
                         * 1 = iridescent stone
                         * 2 = honing stone
                         * 3 = oily coil
                         * 4 = tension spring
                         * 5 = trapper sack
                         * 6 = fastening tools
                         * 7 = rusted jaws
                         * 8 = secondary coil
                         * 9 = tar bottle
                         * 10 = trapper bag
                         * 11 = 4-coil spring kit
                         * 12 = coffee grounds
                         * 13 = lengthened jaws
                         * 14 = serrated jaws
                         * 15 = wax brick
                         * 16 = bear oil
                         * 17 = makeshift wrap
                         * 18 = padded jaws
                         * 19 = trapper gloves
                         * */

                        // bloody coil
                        case 0:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/BloodyCoil.png", UriKind.Relative);
                            return image;

                        // iridescent stone
                        case 1:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/IridescentStone.png", UriKind.Relative);
                            return image;

                        // Honing stone
                        case 2:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/HoningStone.png", UriKind.Relative);
                            return image;

                        // oily coil
                        case 3:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/OilyCoil.png", UriKind.Relative);
                            return image;

                        // tension spring
                        case 4:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/TensionSpring.png", UriKind.Relative);
                            return image;

                        // trapper sack
                        case 5:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/TrapperSack.png", UriKind.Relative);
                            return image;

                        // fastening tools
                        case 6:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/FasteningTools.png", UriKind.Relative);
                            return image;

                        // rusted jaws
                        case 7:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/RustedJaws.png", UriKind.Relative);
                            return image;

                        // secondary coil
                        case 8:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/SecondaryCoil.png", UriKind.Relative);
                            return image;

                        // tar bottle
                        case 9:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/TarBottle.png", UriKind.Relative);
                            return image;

                        // trapper bag
                        case 10:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/TrapperBag.png", UriKind.Relative);
                            return image;

                        // 4-coil spring kit
                        case 11:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/4-CoilSpringKit.png", UriKind.Relative);
                            return image;

                        // coffee grounds
                        case 12:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/CoffeeGrounds.png", UriKind.Relative);
                            return image;

                        // lengthened jaws
                        case 13:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/LengthenedJaws.png", UriKind.Relative);
                            return image;

                        // serrated jaws
                        case 14:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/SerratedJaws.png", UriKind.Relative);
                            return image;

                        // wax brick
                        case 15:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/WaxBrick.png", UriKind.Relative);
                            return image;

                        // bear oil
                        case 16:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/BearOil.png", UriKind.Relative);
                            return image;

                        // makeshift wrap
                        case 17:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/MakeshiftWrap.png", UriKind.Relative);
                            return image;

                        // padded jaws
                        case 18:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/PaddedJaws.png", UriKind.Relative);
                            return image;

                        // trapper gloves
                        case 19:
                            image = new(@"/Resources/Killer_Powers/Addons/Trapper/TrapperGloves.png", UriKind.Relative);
                            return image;

                        default:
                            image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                            return image;

                    }

                default:
                    image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                    return image;
            }


        }

        // converts an int into the associated killer portrait
        public string Int_To_Killer_Name(int input)
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

            switch (input)
            {
                case 0:
                    return "The Trapper";
                case 1:
                    return "The Wraith";
                case 2:
                    return "The Hillbilly";
                case 3:
                    return "The Nurse";
                case 4:
                    return "The Huntress";
                case 5:
                    return "The Shape";
                case 6:
                    return "The Hag";
                case 7:
                    return "The Doctor";
                case 8:
                    return "The Cannibal";
                case 9:
                    return "The Nightmare";
                case 10:
                    return "The Pig";
                case 11:
                    return "The Clown";
                case 12:
                    return "The Spirit";
                case 13:
                    return "The Legion";
                case 14:
                    return "The Plague";
                case 15:
                    return "The Ghost Face";
                case 16:
                    return "The Demogorgon";
                case 17:
                    return "The Oni";
                case 18:
                    return "The Deathslinger";
                case 19:
                    return "The Executioner";
                case 20:
                    return "The Blight";
                case 21:
                    return "The Twins";
                case 22:
                    return "The Trickster";
                case 23:
                    return "The Nemesis";
                case 24:
                    return "The Cenobite";
                case 25:
                    return "The Artist";
                case 26:
                    return "The Onryo";
                case 27:
                    return "The Dredge";
                case 28:
                    return "The Mastermind";
                case 29:
                    return "The Knight";
                default:
                    return "";
            }
        }

        // converts int to a survivor portrait
        public Uri Int_To_Survivor_Portrait(int input)
        {
            /* Set in the random order my half-unlocked characters were sorted in
             * 
             * 0 = Dwight
             * 1 = Meg
             * 2 = Claudette
             * 3 = Jake
             * 4 = Nea
             * 5 = Bill
             * 6 = David
             * 7 = Laurie
             * 8 = Feng
             * 9 = Quentin
             * 10 = Detective Tapp
             * 11 = Kate
             * 12 = Adam
             * 13 = Yui
             * 14 = Zarena
             * 15 = Cheryl
             * 16 = Felix
             * 17 = Jill
             * 18 = Leon
             * 19 = Yoichi
             * 20 = Haddie 
             * 21 = Ada
             * 22 = Rebecca
             * 23 = Vittorio
             * 24 = Jonah
             * 25 = Mikaela 
             * 26 = Yun-Jin
             * 27 = Elodie 
             * 28 = Ash
             * 29 = Jane
             * 30 = Jeff
             * 31 = Ace
             * 32 = Nancy
             * 33 = Steve
             * 34 = Jonathan
             * 35 = Chris 
             * 36 = Claire
             * 37 = Carlos
             * 38 = Cybil
             * 39 = James
             * 40 = Lisa
             * 41 = Sheva
             * 
             * 
             */
            
            
            
            
            
            Uri image;

            switch (input)
            {
                case 0:
                    image = new(@"/Resources/Survivor_Icons/Dwight_Portrait.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Survivor_Icons/Meg_Portrait.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Survivor_Icons/Claudette_Portrait.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Survivor_Icons/Jake_Portrait.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Survivor_Icons/Nea_Portrait.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Survivor_Icons/Bill_Portrait.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Survivor_Icons/David_Portrait.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Survivor_Icons/Laurie_Portrait.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Survivor_Icons/Feng_Portrait.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Survivor_Icons/Quentin_Portrait.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Survivor_Icons/Tapp_Portrait.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"/Resources/Survivor_Icons/Kate_Portrait.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Survivor_Icons/Adam_Portrait.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Survivor_Icons/Yui_Portrait.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Survivor_Icons/Zarena_Portrait.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Survivor_Icons/Cheryl_Portrait.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Survivor_Icons/Felix_Portrait.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Survivor_Icons/Jill_Portrait.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Survivor_Icons/Leon_Portrait.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Survivor_Icons/Yoichi_Portrait.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Survivor_Icons/Haddie_Portrait.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Survivor_Icons/Ada_Portrait.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Survivor_Icons/Rebecca_Portrait.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Survivor_Icons/Vittorio_Portrait.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Survivor_Icons/Jonah_Portrait.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Survivor_Icons/Mikaela_Portrait.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Survivor_Icons/Yun-Jin_Portrait.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Survivor_Icons/Elodie_Portrait.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Survivor_Icons/Ash_Portrait.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"/Resources/Survivor_Icons/Jane_Portrait.png", UriKind.Relative);
                    return image;
                case 30:
                    image = new(@"/Resources/Survivor_Icons/Jeff_Portrait.png", UriKind.Relative);
                    return image;
                case 31:
                    image = new(@"/Resources/Survivor_Icons/Ace_Portrait.png", UriKind.Relative);
                    return image;
                case 32:
                    image = new(@"/Resources/Survivor_Icons/Nancy_Portrait.png", UriKind.Relative);
                    return image;
                case 33:
                    image = new(@"/Resources/Survivor_Icons/Steve_Portrait.png", UriKind.Relative);
                    return image;
                case 34:
                    image = new(@"/Resources/Survivor_Icons/Jonathan_Portrait.png", UriKind.Relative);
                    return image;
                case 35:
                    image = new(@"/Resources/Survivor_Icons/Chris_Portrait.png", UriKind.Relative);
                    return image;
                case 36:
                    image = new(@"/Resources/Survivor_Icons/Claire_Portrait.png", UriKind.Relative);
                    return image;
                case 37:
                    image = new(@"/Resources/Survivor_Icons/Carlos_Portrait.png", UriKind.Relative);
                    return image;
                case 38:
                    image = new(@"/Resources/Survivor_Icons/Cybil_Portrait.png", UriKind.Relative);
                    return image;
                case 39:
                    image = new(@"/Resources/Survivor_Icons/James_Portrait.png", UriKind.Relative);
                    return image;
                case 40:
                    image = new(@"/Resources/Survivor_Icons/Lisa_Portrait.png", UriKind.Relative);
                    return image;
                case 41:
                    image = new(@"/Resources/Survivor_Icons/Sheva_Portrait.png", UriKind.Relative);
                    return image;

                default:
                    image = new(@"/Resources/Misc/Missing_Person.png", UriKind.Relative);
                    return image;

            }
        }

        // converts into to a survivor name
        public string Int_To_Survivor_Name(int input)
        {
            switch (input)
            {
                case 0:
                    return "Dwight Fairfield";
                case 1:
                    return "Meg Thomas";
                case 2:
                    return "Claudette Morel";
                case 3:
                    return "Jake Park";
                case 4:
                    return "Nea Karllson";
                case 5:
                    return "William \"Bill\" Overbeck";
                case 6:
                    return "David King";
                case 7:
                    return "Laurie Strode";
                case 8:
                    return "Feng Min";
                case 9:
                    return "Quentin Smith";
                case 10:
                    return "Detective Tapp";
                case 11:
                    return "Kate Denson";
                case 12:
                    return "Adam Francis";
                case 13:
                    return "Yui Kimura";
                case 14:
                    return "Zarina Kassir";
                case 15:
                    return "Cheryl Mason";
                case 16:
                    return "Felix Richter";
                case 17:
                    return "Jill Valentine";
                case 18:
                    return "Leon S. Kennedy";
                case 19:
                    return "Yoichi Asakawa";
                case 20:
                    return "Haddie Kaur";
                case 21:
                    return "Ada Wong";
                case 22:
                    return "Rebecca Chambers";
                case 23:
                    return "Vittorio Toscano";
                case 24:
                    return "Jonah Vasquez";
                case 25:
                    return "Mikaela Reid";
                case 26:
                    return "Yun-Jin Lee";
                case 27:
                    return "Elodie Rakoto";
                case 28:
                    return "Ashley J. Williams";
                case 29:
                    return "Jane Romero";
                case 30:
                    return "Jeff Johansen";
                case 31:
                    return "Ace Visconti";
                case 32:
                    return "Nancy Wheeler";
                case 33:
                    return "Steve Harrington";
                case 34:
                    return "Jonathan Byers";
                case 35:
                    return "Chris Redfield";
                case 36:
                    return "Claire Redfield";
                case 37:
                    return "Carlos Oliveira";
                case 38:
                    return "Cybil Bennett";
                case 39:
                    return "James Sunderland";
                case 40:
                    return "Lisa Garland";
                case 41:
                    return "Sheva Alomar";

                default:
                    return "";
            }
        }

        // converts int to a survivor perk
        public Uri Int_To_Survivor_Perk(int input)
        {
            /*
             * 0 = Ace In The Hole 
             * 1 = Adrenaline
             * 2 = Aftercare
             * 3 = Alert
             * 4 = Any Means Necessary
             * 5 = Appraisal
             * 6 = Autodidact
             * 7 = Balanced Landing
             * 8 = Better Than New
             * 9 = Bite the Bullet
             * 10 = Blast Mine
             * 11 = Blood Pact
             * 12 = Boil Over
             * 13 = Boon: Circle of Healing
             * 14 = Boon: Dark Theory
             * 15 = Boon: Exponential
             * 16 = Boon: Shadow Step
             * 17 = Bond
             * 18 = Borrowed Time
             * 19 = Botany Knowledge
             * 20 = Breakdown
             * 21 = Breakout
             * 22 = Buckle Up
             * 23 = Built To Last
             * 24 = Calm Spirit
             * 25 = Corrective action
             * 26 = Counterforce
             * 27 = Clairvoyance
             * 28 = Dance With Me
             * 29 = Dark Sense
             * 30 = Dead Hard
             * 31 = Deception
             * 32 = Decisive Strike
             * 33 = Deja Vu
             * 34 = Deliverance
             * 35 = Desperate Measures
             * 36 = Detective's Hunch
             * 37 = Distortion
             * 38 = Diversion
             * 39 = Empathic Connection
             * 40 = Empathy
             * 41 = Fast Track
             * 42 = Flashbang
             * 43 = Flip-Flop
             * 44 = Fogwise
             * 45 = For The People
             * 46 = Guardian
             * 47 = Head On
             * 48 = Hope
             * 49 = Hyperfocus
             * 50 = Inner Focus
             * 51 = Inner Healing
             * 52 = Iron Will
             * 53 = Kindred
             * 54 = Kinship
             * 55 = Leader
             * 56 = Left Behind
             * 57 = Lightweight
             * 58 = Lithe
             * 59 = Low Profile
             * 60 = Lucky Break
             * 61 = Mettle of man
             * 62 = No Mither
             * 63 = No One Left Behind
             * 64 = Object of Obsession
             * 65 = Off The Record
             * 66 = Open-Handed
             * 67 = Overcome
             * 68 = Overzealous
             * 69 = Parental Guidance
             * 70 = Pharmacy
             * 71 = Plunderer's Instinct
             * 72 = Poised
             * 73 = Potential Energy
             * 74 = Power Struggle
             * 75 = Premonition
             * 76 = Prove Thyself
             * 77 = Quick Gambit
             * 78 = Quick and Quiet
             * 79 = Reactive Healing
             * 80 = Reassurance
             * 81 = Red Herring
             * 82 = Renewal
             * 83 = Repressed Alliance
             * 84 = Residual Manifest
             * 85 = Resilience
             * 86 = Resurgence
             * 87 = Rookie Spirit
             * 88 = Saboteur
             * 89 = Self-Aware
             * 90 = Self-Care
             * 91 = Self-Preservation
             * 92 = Situational Awareness
             * 93 = Slippery Meat
             * 94 = Small Game
             * 95 = Smash Hit
             * 96 = Sole Survivor
             * 97 = Solidarity
             * 98 = Soul Guard
             * 99 = Spine Chill
             * 100 = Sprint Burst
             * 101 = Stake Out
             * 102 = Streetwise
             * 103 = Technician
             * 104 = Tenacity
             * 105 = This Is Not Happening
             * 106 = Unbreakable
             * 107 = Up The Ante
             * 108 = Urban Evasion
             * 109 = Vigil
             * 110 = Visionary
             * 111 = Wake Up
             * 112 = We'll Make it
             * 113 = We're Gonna Live Forever
             * 114 = Windows of Opportunity
             * 115 = Wiretap
             * 
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

            switch(input)
            {
                case 0:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_AceInTheHole.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Adrenaline.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Aftercare.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Alert.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_AnyMeansNecessary.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Appraisal.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Autodidact.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BalancedLanding.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BetterThanNew.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BiteTheBullet.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BlastMine.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BloodPact.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BoilOver.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BoonCircleOfHealing.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BoonDarkTheory.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BoonExponential.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BoonShadowStep.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Bond.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BorrowedTime.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BotanyKnowledge.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Breakdown.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Breakout.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BuckleUp.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_BuiltToLast.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_CalmSpirit.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_CorrectiveAction.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Counterforce.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Clairvoyance.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DanceWithMe.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DarkSense.png", UriKind.Relative);
                    return image;
                case 30:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DeadHard.png", UriKind.Relative);
                    return image;
                case 31:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Deception.png", UriKind.Relative);
                    return image;
                case 32:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DecisiveStrike.png", UriKind.Relative);
                    return image;
                case 33:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DejaVu.png", UriKind.Relative);
                    return image;
                case 34:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Deliverance.png", UriKind.Relative);
                    return image;
                case 35:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DesperateMeasures.png", UriKind.Relative);
                    return image;
                case 36:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_DetectivesHunch.png", UriKind.Relative);
                    return image;
                case 37:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Distortion.png", UriKind.Relative);
                    return image;
                case 38:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Diversion.png", UriKind.Relative);
                    return image;
                case 39:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_EmpathicConnection.png", UriKind.Relative);
                    return image;
                case 40:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Empathy.png", UriKind.Relative);
                    return image;
                case 41:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_FastTrack.png", UriKind.Relative);
                    return image;
                case 42:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Flashbang.png", UriKind.Relative);
                    return image;
                case 43:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Flip-Flop.png", UriKind.Relative);
                    return image;
                case 44:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Fogwise.png", UriKind.Relative);
                    return image;
                case 45:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ForThePeople.png", UriKind.Relative);
                    return image;
                case 46:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Guardian.png", UriKind.Relative);
                    return image;
                case 47:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_HeadOn.png", UriKind.Relative);
                    return image;
                case 48:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Hope.png", UriKind.Relative);
                    return image;
                case 49:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Hyperfocus.png", UriKind.Relative);
                    return image;
                case 50:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_InnerFocus.png", UriKind.Relative);
                    return image;
                case 51:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_InnerHealing.png", UriKind.Relative);
                    return image;
                case 52:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_IronWill.png", UriKind.Relative);
                    return image;
                case 53:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Kindred.png", UriKind.Relative);
                    return image;
                case 54:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Kinship.png", UriKind.Relative);
                    return image;
                case 55:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Leader.png", UriKind.Relative);
                    return image;
                case 56:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_LeftBehind.png", UriKind.Relative);
                    return image;
                case 57:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Lightweight.png", UriKind.Relative);
                    return image;
                case 58:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Lithe.png", UriKind.Relative);
                    return image;
                case 59:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_LowProfile.png", UriKind.Relative);
                    return image;
                case 60:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_LuckyBreak.png", UriKind.Relative);
                    return image;
                case 61:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_MettleOfMan.png", UriKind.Relative);
                    return image;
                case 62:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_NoMither.png", UriKind.Relative);
                    return image;
                case 63:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_NoOneLeftBehind.png", UriKind.Relative);
                    return image;
                case 64:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ObjectOfObsession.png", UriKind.Relative);
                    return image;
                case 65:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_OffTheRecord.png", UriKind.Relative);
                    return image;
                case 66:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Open-Handed.png", UriKind.Relative);
                    return image;
                case 67:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Overcome.png", UriKind.Relative);
                    return image;
                case 68:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Overzealous.png", UriKind.Relative);
                    return image;
                case 69:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ParentalGuidance.png", UriKind.Relative);
                    return image;
                case 70:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Pharmacy.png", UriKind.Relative);
                    return image;
                case 71:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_PlunderersInstinct.png", UriKind.Relative);
                    return image;
                case 72:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Poised.png", UriKind.Relative);
                    return image;
                case 73:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_PotentialEnergy.png", UriKind.Relative);
                    return image;
                case 74:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_PowerStruggle.png", UriKind.Relative);
                    return image;
                case 75:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Premonition.png", UriKind.Relative);
                    return image;
                case 76:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ProveThyself.png", UriKind.Relative);
                    return image;
                case 77:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_QuickGambit.png", UriKind.Relative);
                    return image;
                case 78:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_QuickAndQuiet.png", UriKind.Relative);
                    return image;
                case 79:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ReactiveHealing.png", UriKind.Relative);
                    return image;
                case 80:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Reassurance.png", UriKind.Relative);
                    return image;
                case 81:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_RedHerring.png", UriKind.Relative);
                    return image;
                case 82:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Renewal.png", UriKind.Relative);
                    return image;
                case 83:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_RepressedAlliance.png", UriKind.Relative);
                    return image;
                case 84:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ResidualManifest.png", UriKind.Relative);
                    return image;
                case 85:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Resilience.png", UriKind.Relative);
                    return image;
                case 86:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Resurgence.png", UriKind.Relative);
                    return image;
                case 87:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_RookieSpirit.png", UriKind.Relative);
                    return image;
                case 88:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Saboteur.png", UriKind.Relative);
                    return image;
                case 89:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SelfAware.png", UriKind.Relative);
                    return image;
                case 90:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Self-Care.png", UriKind.Relative);
                    return image;
                case 91:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Self-Preservation.png", UriKind.Relative);
                    return image;
                case 92:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SituationalAwareness.png", UriKind.Relative);
                    return image;
                case 93:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SlipperyMeat.png", UriKind.Relative);
                    return image;
                case 94:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SmallGame.png", UriKind.Relative);
                    return image;
                case 95:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SmashHit.png", UriKind.Relative);
                    return image;
                case 96:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SoleSurvivor.png", UriKind.Relative);
                    return image;
                case 97:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Solidarity.png", UriKind.Relative);
                    return image;
                case 98:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SoulGuard.png", UriKind.Relative);
                    return image;
                case 99:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SpineChill.png", UriKind.Relative);
                    return image;
                case 100:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_SprintBurst.png", UriKind.Relative);
                    return image;
                case 101:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_StakeOut.png", UriKind.Relative);
                    return image;
                case 102:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Streetwise.png", UriKind.Relative);
                    return image;
                case 103:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Technician.png", UriKind.Relative);
                    return image;
                case 104:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Tenacity.png", UriKind.Relative);
                    return image;
                case 105:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_ThisIsNotHappening.png", UriKind.Relative);
                    return image;
                case 106:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Unbreakable.png", UriKind.Relative);
                    return image;
                case 107:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_UpTheAnte.png", UriKind.Relative);
                    return image;
                case 108:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_UrbanEvasion.png", UriKind.Relative);
                    return image;
                case 109:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Vigil.png", UriKind.Relative);
                    return image;
                case 110:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Visionary.png", UriKind.Relative);
                    return image;
                case 111:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_WakeUp.png", UriKind.Relative);
                    return image;
                case 112:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_WellMakeIt.png", UriKind.Relative);
                    return image;
                case 113:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_WereGonnaLiveForever.png", UriKind.Relative);
                    return image;
                case 114:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_WindowsOfOpportunity.png", UriKind.Relative);
                    return image;
                case 115:
                    image = new(@"/Resources/Survivor_Perks/IconPerks_Wiretap.png", UriKind.Relative);
                    return image;
                default:
                    image = new(@"/Resources/Misc/Transparent_Background.png", UriKind.Relative);
                    return image;
            }
        }

        // converts int to survivor fate icon
        public Uri Int_To_Survivor_Fate(int input)
        {
            // 0 = DC
            // 1 = Escaped
            // 2 = Sacrificed
            // 3 = Dead
            // 4 = Killer          


            Uri image;
            switch (input)
            {
                case 0:
                    image = new(@"/Resources/Misc/Game_Outcomes/Disconnect_Icon.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Misc/Game_Outcomes/Escaped_Icon.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Misc/Game_Outcomes/Sacrificed_Icon.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Misc/Game_Outcomes/Death_Icon.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Misc/Killer_Icon.png", UriKind.Relative);
                    return image;

                default:
                    image = new(@"/Resources/Misc/Missing_Person.png", UriKind.Relative);
                    return image;
            }
        }

        // converts int to a survivor offering
        public Uri Int_To_Survivor_Offering(int input)
        {
            /*
             * 0 = Murky Reagent
             * 1 = Petrified Oak
             * 2 = Shiny Coin
             * 3 = Shroud of Binding
             * 4 = Vigos Jar of Salty Lips
             * 5 = White Ward
             * 6 = Azarovs Key
             * 7 = Beef Tallow Mixture
             * 8 = Black Salt Statuette
             * 9 = Charred Wedding Photograph
             * 10 = Crow's Eye
             * 11 = Damaged Photo
             * 12 = Dusty Noose
             * 13 = Grandma's Cookbook
             * 14 = Heart Locket
             * 15 = Ichorous Loam
             * 16 = Ivory Chalk Pouch
             * 17 = Jigsaw Piece
             * 18 = MacMillan's Phalanx Bone
             * 19 = Marys Letter
             * 20 = RPD Badge
             * 21 = Sacrificial Ward
             * 22 = Shattered Glasses
             * 23 = Strode Realty Key
             * 24 = The Last Mask
             * 25 = The Pied Piper
             * 26 = Yamaoka Family Crest
             * 27 = Cream Chalk Pouch
             * 28 = Hazy Reagent
             * 29 = Salt Pouch
             * 30 = Shroud of Union
             * 31 = Tarnished Coin
             * 32 = Vigo's Shroud
             * 33 = Annotated Blueprint
             * 34 = Bloodied Blueprint
             * 35 = Chalk Pouch
             * 36 = Clear Reagent
             * 37 = Faint Reagent
             * 38 = Torn Blueprint
             * 39 = Vigo's Blueprint
             * 
             * */
            
            Uri image;
            switch(input)
            {
                case 0:
                    image = new(@"Resources/Killer_Offerings/MurkyReagent.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"Resources/Survivor_Offerings/PetrifiedOak.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"Resources/Survivor_Offerings/ShinyCoin.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"Resources/Survivor_Offerings/ShroudOfBinding.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"Resources/Survivor_Offerings/VigosJarOfSaltyLips.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"Resources/Survivor_Offerings/WhiteWard.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"Resources/Killer_Offerings/AzarovsKey.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"Resources/Killer_Offerings/BeefTallowMixture.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"Resources/Survivor_Offerings/BlackSaltStatuette.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"Resources/Killer_Offerings/CharredWeddingPhotograph.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"Resources/Killer_Offerings/AzarovsKey.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"Resources/Killer_Offerings/BeefTallowMixture.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"Resources/Killer_Offerings/DustyNoose.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"Resources/Killer_Offerings/GrandmasCookbook.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"Resources/Killer_Offerings/HeartLocket.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"Resources/Killer_Offerings/IchorousLoam.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"Resources/Survivor_Offerings/IvoryChalkPouch.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"Resources/Killer_Offerings/JigsawPiece.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"Resources/Killer_Offerings/MacMillansPhalanxBone.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"Resources/Killer_Offerings/MarysLetter.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"Resources/Killer_Offerings/RpdBadge.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"Resources/Killer_Offerings/SacrificialWard.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"Resources/Killer_Offerings/ShatteredGlasses.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"Resources/Killer_Offerings/StrodeRealtyKey.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"Resources/Killer_Offerings/TheLastMask.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"Resources/Killer_Offerings/ThePiedPiper.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"Resources/Killer_Offerings/YamaokaFamilyCrest.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"Resources/Survivor_Offerings/CreamChalkPouch.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"Resources/Killer_Offerings/HazyReagent.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"Resources/Survivor_Offerings/SaltPouch.png", UriKind.Relative);
                    return image;
                case 30:
                    image = new(@"Resources/Survivor_Offerings/ShroudOfUnion.png", UriKind.Relative);
                    return image;
                case 31:
                    image = new(@"Resources/Survivor_Offerings/TarnishedCoin.png", UriKind.Relative);
                    return image;
                case 32:
                    image = new(@"Resources/Survivor_Offerings/VigosShroud.png", UriKind.Relative);
                    return image;
                case 33:
                    image = new(@"Resources/Killer_Offerings/AnnotatedBlueprint.png", UriKind.Relative);
                    return image;
                case 34:
                    image = new(@"Resources/Killer_Offerings/BloodiedBlueprint.png", UriKind.Relative);
                    return image;
                case 35:
                    image = new(@"Resources/Survivor_Offerings/ChalkPouch.png", UriKind.Relative);
                    return image;
                case 36:
                    image = new(@"Resources/Killer_Offerings/ClearReagent.png", UriKind.Relative);
                    return image;
                case 37:
                    image = new(@"Resources/Killer_Offerings/FaintReagent.png", UriKind.Relative);
                    return image;
                case 38:
                    image = new(@"Resources/Killer_Offerings/TornBlueprint.png", UriKind.Relative);
                    return image;
                case 39:
                    image = new(@"Resources/Killer_Offerings/VigosBlueprint.png", UriKind.Relative);
                    return image;
                /*


  
             * 36 = Clear Reagent
             * 37 = Faint Reagent
             * 38 = Torn Blueprint
             * 39 = Vigo's Blueprint
             * 
             * */

                default:
                    image = new(@"Resources/Misc/Offering_Background/Offering_Background_Common.png", UriKind.Relative);
                    return image;
            }
        }

        // returns killer offering portrait
        public Uri Int_To_Killer_Offering(int input)
        {
            /* 
             * 0 = Ebony Memento Mori
             * 1 = Black Ward
             * 2 = CutCoin
             * 3 = Murky Reagent
             * 4 = PutridOak
             * 5 = Azarov's Key
             * 6 = Beef Tallow Mixture 
             * 7 = Charred Wedding Photograph
             * 8 = Crow's Eye
             * 9 = Damaged Photo
             * 10 = Dusty Noose
             * 11 = Grandma's Cookbook
             * 12 = Heart Locket
             * 13 = Ichorous Loam
             * 14 = Ivory Memento Mori
             * 15 = Jigsaw Piece
             * 16 = MacMillansPhalanxBone
             * 17 = MarysLetter
             * 18 = Rotten Oak
             * 19 = RPD Badge
             * 20 = Sacrificial Ward
             * 21 = Shattered Glasses
             * 22 = Strode Realty Key
             * 23 = The Last Mask
             * 24 = The Pied Piper
             * 25 = Yamaoka Family Crest
             * 26 = Cypress Memento Mori
             * 27 = Hazy Reagent
             * 28 = Moldy Oak
             * 29 = Scratched Coin
             * 30 = Shroud of Separation
             * 31 = Annotated Blueprint
             * 32 = Bloodied Blueprint
             * 33 = Clear Reagent
             * 34 = Faint Reagent
             * 35 = Torn Blueprint
             * 36 = Vigo's Blueprint
             * 
             * 
             * 
             * 
            */         


            Uri image;
            switch (input)
            {
                case 0:
                    image = new(@"/Resources/Killer_Offerings/EbonyMementoMori.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Killer_Offerings/BlackWard.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Killer_Offerings/CutCoin.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Killer_Offerings/MurkyReagent.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Killer_Offerings/PutridOak.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Killer_Offerings/AzarovsKey.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Killer_Offerings/BeefTallowMixture.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Killer_Offerings/CharredWeddingPhotograph.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Killer_Offerings/CrowsEye.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Killer_Offerings/DamagedPhoto.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Killer_Offerings/DustyNoose.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"/Resources/Killer_Offerings/GrandmasCookbook.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Killer_Offerings/HeartLocket.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Killer_Offerings/IchorousLoam.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Killer_Offerings/IvoryMementoMori.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Killer_Offerings/JigsawPiece.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Killer_Offerings/MacMillansPhalanxBone.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Killer_Offerings/MarysLetter.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Killer_Offerings/RottenOak.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Killer_Offerings/RpdBadge.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Killer_Offerings/SacrificialWard.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Killer_Offerings/ShatteredGlasses.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Killer_Offerings/StrodeRealtyKey.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Killer_Offerings/TheLastMask.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Killer_Offerings/ThePiedPiper.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Killer_Offerings/YamaokaFamilyCrest.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Killer_Offerings/CypressMementoMori.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Killer_Offerings/HazyReagent.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Killer_Offerings/MoldyOak.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"/Resources/Killer_Offerings/ScratchedCoin.png", UriKind.Relative);
                    return image;
                case 30:
                    image = new(@"/Resources/Killer_Offerings/ShroudOfSeparation.png", UriKind.Relative);
                    return image;
                case 31:
                    image = new(@"/Resources/Killer_Offerings/AnnotatedBlueprint.png", UriKind.Relative);
                    return image;
                case 32:
                    image = new(@"/Resources/Killer_Offerings/BloodiedBlueprint.png", UriKind.Relative);
                    return image;
                case 33:
                    image = new(@"/Resources/Killer_Offerings/ClearReagent.png", UriKind.Relative);
                    return image;
                case 34:
                    image = new(@"/Resources/Killer_Offerings/FaintReagent.png", UriKind.Relative);
                    return image;
                case 35:
                    image = new(@"/Resources/Killer_Offerings/TornBlueprint.png", UriKind.Relative);
                    return image;
                case 36:
                    image = new(@"/Resources/Killer_Offerings/VigosBlueprint.png", UriKind.Relative);
                    return image;


                default:
                    image = new(@"Resources/Misc/Offering_Background/Offering_Background_Common.png", UriKind.Relative);
                    return image;
            }
        }


        // converts an int into the associated killer portrait
        public Uri Int_To_Killer_Perk(int input)
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
             * 11 = Call of Brine             Until this project I legit though it was "Call of the brine"
             * 12 = Claustrophobia
             * 13 = Corrupt Intervention
             * 14 = Coulrophobia
             * 15 = Coup de Grace
             * 16 = Dark Devotion
             * 17 = Darkness Revealed
             * 18 = Dead Man's Switch
             * 19 = Deadlock
             * 20 = Deathbound
             * 21 = Deerstalker
             * 22 = Discordance
             * 23 = Dissolution
             * 24 = Distressing
             * 25 = Dragon's Grip
             * 26 = Dying Light
             * 27 = Enduring
             * 28 = Eruption
             * 29 = Fearmonger
             * 30 = Fire Up
             * 31 = Forced Penance
             * 32 = Franklin's Demise
             * 33 = Furtive Chase
             * 34 = Gearhead
             * 35 = Grim Embrace
             * 36 = Hangman's Trick
             * 37 = Hex: Blood Favor
             * 38 = Hex: Crowd Control
             * 39 = Hex: Devour Hope
             * 40 = Hex: Face the Darkness
             * 41 = Hex: Haunted Ground
             * 42 = Hex: Huntress Lullaby
             * 43 = Hex: No One Escapes Death
             * 44 = Hex: Pentimento
             * 45 = Hex: Plaything
             * 46 = Hex: Retribution
             * 47 = Hex: Ruin
             * 48 = Hex: The Third Seal
             * 49 = Hex: Thrill of the Hunt
             * 50 = Hex: Undying
             * 51 = Hoarder
             * 52 = Hubris
             * 53 = Hysteria
             * 54 = I'm All Ears
             * 55 = Infectious Fright
             * 56 = Insidious
             * 57 = Iron Grasp
             * 58 = Iron Maiden
             * 59 = Jolt
             * 60 = Knock Out
             * 61 = Lethal Pursuer
             * 62 = Lightborn
             * 63 = Mad Grit
             * 64 = Make Your Choice
             * 65 = Merciless Storm
             * 66 = Monitor And Abuse
             * 67 = Nemesis
             * 68 = No Way Out
             * 69 = NowhereToHide
             * 70 = Oppression
             * 71 = Overcharge
             * 72 = OverwhelmingPresence
             * 73 = Play With Your Food
             * 74 = Pop Goes The Weasel
             * 75 = Predator
             * 76 = Rancor
             * 77 = Remember Me
             * 78 = Save The Best For Last
             * 79 = Scourge Hook: Floods Of Rage
             * 80 = Scourge Hook: Gift Of Pain
             * 81 = Scourge Hook: Monstrous Shrine
             * 82 = Scourge Hook: Pain Resonance
             * 83 = Septic Touch
             * 84 = Shadowborn
             * 85 = Shattered Hope
             * 86 = Sloppy Butcher
             * 87 = Spies From The Shadows
             * 88 = Spirit Fury
             * 89 = Starstruck
             * 90 = Stridor
             * 91 = Superior Anatomy
             * 92 = Surveillance
             * 93 = Terminus
             * 94 = Territorial Imperative
             * 95 = Thanataphobia
             * 96 = Thrilling Tremors
             * 97 = Tinkerer
             * 98 = Trail of Torment
             * 99 = Unnerving Presence
             * 100 = Unrelenting
             * 101 = Whispers
             * 102 = Zanshin Tactics
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
                case 11:
                    image = new(@"/Resources/Killer_Perks/IconPerks_CallOfBrine.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Claustrophobia.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Killer_Perks/IconPerks_CorruptIntervention.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Coulrophobia.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Killer_Perks/IconPerks_CoupDeGrace.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Killer_Perks/IconPerks_DarkDevotion.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Killer_Perks/IconPerks_DarknessRevealed.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Killer_Perks/IconPerks_DeadMansSwitch.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Deadlock.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Deathbound.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Deerstalker.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Discordance.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Dissolution.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Distressing.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Killer_Perks/IconPerks_DragonsGrip.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Killer_Perks/IconPerks_DyingLight.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Enduring.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Eruption.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Fearmonger.png", UriKind.Relative);
                    return image;
                case 30:
                    image = new(@"/Resources/Killer_Perks/IconPerks_FireUp.png", UriKind.Relative);
                    return image;
                case 31:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ForcedPenance.png", UriKind.Relative);
                    return image;
                case 32:
                    image = new(@"/Resources/Killer_Perks/IconPerks_FranklinsDemise.png", UriKind.Relative);
                    return image;
                case 33:
                    image = new(@"/Resources/Killer_Perks/IconPerks_FurtiveChase.png", UriKind.Relative);
                    return image;
                case 34:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Gearhead.png", UriKind.Relative);
                    return image;
                case 35:
                    image = new(@"/Resources/Killer_Perks/IconPerks_GrimEmbrace.png", UriKind.Relative);
                    return image;
                case 36:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HangmansTrick.png", UriKind.Relative);
                    return image;
                case 37:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexBloodFavour.png", UriKind.Relative);
                    return image;
                case 38:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexCrowdControl.png", UriKind.Relative);
                    return image;
                case 39:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexDevourHope.png", UriKind.Relative);
                    return image;
                case 40:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexFaceTheDarkness.png", UriKind.Relative);
                    return image;
                case 41:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexHauntedGround.png", UriKind.Relative);
                    return image;
                case 42:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexHuntressLullaby.png", UriKind.Relative);
                    return image;
                case 43:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexNoOneEscapesDeath.png", UriKind.Relative);
                    return image;
                case 44:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexPentimento.png", UriKind.Relative);
                    return image;
                case 45:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexPlaything.png", UriKind.Relative);
                    return image;
                case 46:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexRetribution.png", UriKind.Relative);
                    return image;
                case 47:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexRuin.png", UriKind.Relative);
                    return image;
                case 48:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexTheThirdSeal.png", UriKind.Relative);
                    return image;
                case 49:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexThrillOfTheHunt.png", UriKind.Relative);
                    return image;
                case 50:
                    image = new(@"/Resources/Killer_Perks/IconPerks_HexUndying.png", UriKind.Relative);
                    return image;
                case 51:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Hoarder.png", UriKind.Relative);
                    return image;
                case 52:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Hubris.png", UriKind.Relative);
                    return image;
                case 53:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Hysteria.png", UriKind.Relative);
                    return image;
                case 54:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ImAllEars.png", UriKind.Relative);
                    return image;
                case 55:
                    image = new(@"/Resources/Killer_Perks/IconPerks_InfectiousFright.png", UriKind.Relative);
                    return image;
                case 56:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Insidious.png", UriKind.Relative);
                    return image;
                case 57:
                    image = new(@"/Resources/Killer_Perks/IconPerks_IronGrasp.png", UriKind.Relative);
                    return image;
                case 58:
                    image = new(@"/Resources/Killer_Perks/IconPerks_IronMaiden.png", UriKind.Relative);
                    return image;
                case 59:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Jolt.png", UriKind.Relative);
                    return image;
                case 60:
                    image = new(@"/Resources/Killer_Perks/IconPerks_KnockOut.png", UriKind.Relative);
                    return image;
                case 61:
                    image = new(@"/Resources/Killer_Perks/IconPerks_LethalPursuer.png", UriKind.Relative);
                    return image;
                case 62:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Lightborn.png", UriKind.Relative);
                    return image;
                case 63:
                    image = new(@"/Resources/Killer_Perks/IconPerks_MadGrit.png", UriKind.Relative);
                    return image;
                case 64:
                    image = new(@"/Resources/Killer_Perks/IconPerks_MakeYourChoice.png", UriKind.Relative);
                    return image;
                case 65:
                    image = new(@"/Resources/Killer_Perks/IconPerks_MercilessStorm.png", UriKind.Relative);
                    return image;
                case 66:
                    image = new(@"/Resources/Killer_Perks/IconPerks_MonitorAndAbuse.png", UriKind.Relative);
                    return image;
                case 67:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Nemesis.png", UriKind.Relative);
                    return image;
                case 68:
                    image = new(@"/Resources/Killer_Perks/IconPerks_NoWayOut.png", UriKind.Relative);
                    return image;
                case 69:
                    image = new(@"/Resources/Killer_Perks/IconPerks_NowhereToHide.png", UriKind.Relative);
                    return image;
                case 70:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Oppression.png", UriKind.Relative);
                    return image;
                case 71:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Overcharge.png", UriKind.Relative);
                    return image;
                case 72:
                    image = new(@"/Resources/Killer_Perks/IconPerks_OverwhelmingPresence.png", UriKind.Relative);
                    return image;
                case 73:
                    image = new(@"/Resources/Killer_Perks/IconPerks_PlayWithYourFood.png", UriKind.Relative);
                    return image;
                case 74:
                    image = new(@"/Resources/Killer_Perks/IconPerks_PopGoesTheWeasel.png", UriKind.Relative);
                    return image;
                case 75:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Predator.png", UriKind.Relative);
                    return image;
                case 76:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Rancor.png", UriKind.Relative);
                    return image;
                case 77:
                    image = new(@"/Resources/Killer_Perks/IconPerks_RememberMe.png", UriKind.Relative);
                    return image;
                case 78:
                    image = new(@"/Resources/Killer_Perks/IconPerks_SaveTheBestForLast.png", UriKind.Relative);
                    return image;
                case 79:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ScourgeHookFloodsOfRage.png", UriKind.Relative);
                    return image;
                case 80:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ScourgeHookGiftOfPain.png", UriKind.Relative);
                    return image;
                case 81:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ScourgeHookMonstrousShrine.png", UriKind.Relative);
                    return image;
                case 82:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ScourgeHookPainResonance.png", UriKind.Relative);
                    return image;
                case 83:
                    image = new(@"/Resources/Killer_Perks/IconPerks_SepticTouch.png", UriKind.Relative);
                    return image;
                case 84:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Shadowborn.png", UriKind.Relative);
                    return image;
                case 85:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ShatteredHope.png", UriKind.Relative);
                    return image;
                case 86:
                    image = new(@"/Resources/Killer_Perks/IconPerks_SloppyButcher.png", UriKind.Relative);
                    return image;
                case 87:
                    image = new(@"/Resources/Killer_Perks/IconPerks_SpiesFromTheShadows.png", UriKind.Relative);
                    return image;
                case 88:
                    image = new(@"/Resources/Killer_Perks/IconPerks_SpiritFury.png", UriKind.Relative);
                    return image;
                case 89:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Starstruck.png", UriKind.Relative);
                    return image;
                case 90:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Stridor.png", UriKind.Relative);
                    return image;
                case 91:
                    image = new(@"/Resources/Killer_Perks/IconPerks_SuperiorAnatomy.png", UriKind.Relative);
                    return image;
                case 92:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Surveillance.png", UriKind.Relative);
                    return image;
                case 93:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Terminus.png", UriKind.Relative);
                    return image;
                case 94:
                    image = new(@"/Resources/Killer_Perks/IconPerks_TerritorialImperative.png", UriKind.Relative);
                    return image;
                case 95:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Thanatophobia.png", UriKind.Relative);
                    return image;
                case 96:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ThrillingTremors.png", UriKind.Relative);
                    return image;
                case 97:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Tinkerer.png", UriKind.Relative);
                    return image;
                case 98:
                    image = new(@"/Resources/Killer_Perks/IconPerks_TrailOfTorment.png", UriKind.Relative);
                    return image;
                case 99:
                    image = new(@"/Resources/Killer_Perks/IconPerks_UnnervingPresence.png", UriKind.Relative);
                    return image;
                case 100:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Unrelenting.png", UriKind.Relative);
                    return image;
                case 101:
                    image = new(@"/Resources/Killer_Perks/IconPerks_Whispers.png", UriKind.Relative);
                    return image;
                case 102:
                    image = new(@"/Resources/Killer_Perks/IconPerks_ZanshinTactics.png", UriKind.Relative);
                    return image;

                default:
                    image = new(@"/Resources/Misc/Transparent_Background.png", UriKind.Relative);
                    return image;

            }
        }

        // converts into to a map name
        public string Int_To_Map_Name(int input)
        {
            /*
             * 0 = Coal Tower
             * 1 = Shelter Woods
             * 2 = Ironworks of Misery
             * 3 = Suffocation Pit
             * 4 = Groaning Storehouse
             * 5 = Rotten Fields
             * 6 = Rancid Abattoir
             * 7 = The Thompson House
             * 8 = Torment Creek
             * 9 = Fractured Cowshed
             * 10 = Azarov's Resting Place
             * 11 = Wreckers' Yard
             * 12 = Gas Heaven
             * 13 = Wretched Shop
             * 14 = Blood Lodge
             * 15 = Disturbed Ward
             * 16 = Father Campbell's Chapel
             * 17 = Lampkin Lane
             * 18 = Mother's Dwelling
             * 19 = Treatment Theatre
             * 20 = The Temple of Purgation
             * 21 = The Pale Rose
             * 22 = Grim Pantry
             * 23 = Badham Preschool I
             * 24 = Badham Preschool II
             * 25 = Badham Preschool III
             * 26 = Badham Preschool IV
             * 27 = Badham Preschool V
             * 28 = The Game
             * 29 = Family Residence
             * 30 = Sanctum of Wrath
             * 31 = Mount Ormond Resort
             * 32 = Dead Dawg Saloon
             * 33 = Midwich Elementary School
             * 34 = RPD East
             * 35 = RPD West
             * 36 = Eyrie of Crows
             * 37 = Garden of Joy
             * 38 = The Shattered Square
             * 
             * 
             * 
             */

            switch (input)
            {
                case 0:
                    return "Coal Tower";
                case 1:
                    return "Shelter Woods";
                case 2:
                    return "Ironworks of Misery";
                case 3:
                    return "Suffocation Pit";
                case 4:
                    return "Groaning Storehouse";
                case 5:
                    return "Rotten Fields";
                case 6:
                    return "Rancid Abattoir";
                case 7:
                    return "The Thompson House";
                case 8:
                    return "Torment Creek";
                case 9:
                    return "Fractured Cowshed";
                case 10:
                    return "Azarov's Resting Place";
                case 11:
                    return "Wreckers' Yard";
                case 12:
                    return "Gas Heaven";
                case 13:
                    return "Wretched Shop";
                case 14:
                    return "Blood Lodge";
                case 15:
                    return "Disturbed Ward";
                case 16:
                    return "Father Campbell's Chapel";
                case 17:
                    return "Lampkin Lane";
                case 18:
                    return "Mother's Dwelling";
                case 19:
                    return "Treatment Theatre";
                case 20:
                    return "The Temple of Purgation";
                case 21:
                    return "The Pale Rose";
                case 22:
                    return "Grim Pantry";
                case 23:
                    return "Badham Preschool I";
                case 24:
                    return "Badham Preschool II";
                case 25:
                    return "Badham Preschool III";
                case 26:
                    return "Badham Preschool IV";
                case 27:
                    return "Badham Preschool V";
                case 28:
                    return "The Game";
                case 29:
                    return "Family Residence";
                case 30:
                    return "Sanctum of Wrath";
                case 31:
                    return "Mount Ormond Resort";
                case 32:
                    return "Dead Dawg Saloon";
                case 33:
                    return "Midwich Elementary School";
                case 34:
                    return "Raccoon City Police Station East Wing";
                case 35:
                    return "Raccoon City Police Station West Wing";
                case 36:
                    return "Eyrie of Crows";
                case 37:
                    return "Garden of Joy";
                case 38:
                    return "The Shattered Square";

                default:
                    return "";
            }
        }
        
        // converts int to a survivor item
        public Uri Int_To_Survivor_Item(int input)
        {

            /*
             * 0 = Rainbow Map
             * 1 = Skeleton Key
             * 2 = Alexs Toolbox
             * 3 = Dull Key
             * 4 = Engineers Toolbox
             * 5 = Ranger Medkit
             * 6 = Utility Flashlight
             * 7 = Broken Key
             * 8 = Commodious Toolbox
             * 9 = Emergency Medkit
             * 10 = Map
             * 11 = Mechanics Toolbox
             * 12 = Sport Flashlight
             * 13 = First Aid Kit
             * 14 = Flashlight
             * 15 = Toolbox
             * 16 = Camping Aid Kit
             * 17 = Worn-Out Tools
             * 18 = All Hallow's Eve Lunchbox
             * 19 = Anniversary Flashlight
             * 20 = Anniversary Med-Kit
             * 21 = Anniversary Toolbox
             * 22 = Chinese Firecracker
             * 23 = Festive Toolbox
             * 24 = Masquerade Flashlight
             * 25 = Masquerade Med-kit
             * 26 = Masquerade Toolbox
             * 27 = Third Year Party Streamer
             * 28 = Will O Wisp
             * 29 = Winter Party Streamer
             * */

            Uri image;

            switch (input)
            {
                case 0:
                    image = new(@"/Resources/Survivor_Items/RainbowMap.png", UriKind.Relative);
                    return image;
                case 1:
                    image = new(@"/Resources/Survivor_Items/SkeletonKey.png", UriKind.Relative);
                    return image;
                case 2:
                    image = new(@"/Resources/Survivor_Items/AlexsToolbox.png", UriKind.Relative);
                    return image;
                case 3:
                    image = new(@"/Resources/Survivor_Items/DullKey.png", UriKind.Relative);
                    return image;
                case 4:
                    image = new(@"/Resources/Survivor_Items/EngineersToolbox.png", UriKind.Relative);
                    return image;
                case 5:
                    image = new(@"/Resources/Survivor_Items/RangerMedkit.png", UriKind.Relative);
                    return image;
                case 6:
                    image = new(@"/Resources/Survivor_Items/UtilityFlashlight.png", UriKind.Relative);
                    return image;
                case 7:
                    image = new(@"/Resources/Survivor_Items/BrokenKey.png", UriKind.Relative);
                    return image;
                case 8:
                    image = new(@"/Resources/Survivor_Items/CommodiousToolbox.png", UriKind.Relative);
                    return image;
                case 9:
                    image = new(@"/Resources/Survivor_Items/EmergencyMedkit.png", UriKind.Relative);
                    return image;
                case 10:
                    image = new(@"/Resources/Survivor_Items/Map.png", UriKind.Relative);
                    return image;
                case 11:
                    image = new(@"/Resources/Survivor_Items/MechanicsToolbox.png", UriKind.Relative);
                    return image;
                case 12:
                    image = new(@"/Resources/Survivor_Items/SportFlashlight.png", UriKind.Relative);
                    return image;
                case 13:
                    image = new(@"/Resources/Survivor_Items/FirstAidKit.png", UriKind.Relative);
                    return image;
                case 14:
                    image = new(@"/Resources/Survivor_Items/Flashlight.png", UriKind.Relative);
                    return image;
                case 15:
                    image = new(@"/Resources/Survivor_Items/Toolbox.png", UriKind.Relative);
                    return image;
                case 16:
                    image = new(@"/Resources/Survivor_Items/CampingAidKit.png", UriKind.Relative);
                    return image;
                case 17:
                    image = new(@"/Resources/Survivor_Items/WornOutTools.png", UriKind.Relative);
                    return image;
                case 18:
                    image = new(@"/Resources/Survivor_Items/AllHallowsEveLunchbox.png", UriKind.Relative);
                    return image;
                case 19:
                    image = new(@"/Resources/Survivor_Items/AnniversaryFlashlight.png", UriKind.Relative);
                    return image;
                case 20:
                    image = new(@"/Resources/Survivor_Items/AnniversaryMedKit.png", UriKind.Relative);
                    return image;
                case 21:
                    image = new(@"/Resources/Survivor_Items/AnniversaryToolbox.png", UriKind.Relative);
                    return image;
                case 22:
                    image = new(@"/Resources/Survivor_Items/ChineseFirecracker.png", UriKind.Relative);
                    return image;
                case 23:
                    image = new(@"/Resources/Survivor_Items/FestiveToolbox.png", UriKind.Relative);
                    return image;
                case 24:
                    image = new(@"/Resources/Survivor_Items/MasqueradeFlashlight.png", UriKind.Relative);
                    return image;
                case 25:
                    image = new(@"/Resources/Survivor_Items/MasqueradeMedKit.png", UriKind.Relative);
                    return image;
                case 26:
                    image = new(@"/Resources/Survivor_Items/MasqueradeToolbox.png", UriKind.Relative);
                    return image;
                case 27:
                    image = new(@"/Resources/Survivor_Items/ThirdYearPartyStreamer.png", UriKind.Relative);
                    return image;
                case 28:
                    image = new(@"/Resources/Survivor_Items/WillOWisp.png", UriKind.Relative);
                    return image;
                case 29:
                    image = new(@"/Resources/Survivor_Items/WinterPartyStreamer.png", UriKind.Relative);
                    return image;


                default:
                    image = new(@"/Resources/Misc/Transparent_Background.png", UriKind.Relative);
                    return image;
            }
        }

        // converts into to a respective addon
        public Uri Int_To_Survivor_Addon(int item, int input)
        {


            Uri image;

            switch (item)
            {
                //22
                //27


                // Maps
                case 0:
                case 10:

                    switch(input)
                    {
                        /*
                         * 0 = Crystal Bead
                         * 1 = Black Silk Cord
                         * 2 = Odd Stamp
                         * 3 = Glass Bead
                         * 4 = Red Twine
                         * 5 = Retardant Jelly
                         * 6 = Unusual Stamp
                         * 7 = Yellow Wire
                         * 8 = Map Appendum
                         * 
                         * 
                         * */


                        // Crystal Bead
                        case 0:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/CrystalBead.png", UriKind.Relative);
                            return image;
                       
                        // Black Silk Cord
                        case 1:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/BlackSilkCord.png", UriKind.Relative);
                            return image;
                        
                        // Odd Stmp
                        case 2:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/OddStamp.png", UriKind.Relative);
                            return image;

                        // Glass Bead
                        case 3:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/GlassBead.png", UriKind.Relative);
                            return image;
                        
                        // Red Twine
                        case 4:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/RedTwine.png", UriKind.Relative);
                            return image;
                        
                        // Retardant Jelly
                        case 5:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/RetardantJelly.png", UriKind.Relative);
                            return image;
                        
                        // Unusual Stamp
                        case 6:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/UnusualStamp.png", UriKind.Relative);
                            return image;
                        
                        // Yellow Wire
                        case 7:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/YellowWire.png", UriKind.Relative);
                            return image;
                        
                        // Map Appendum
                        case 8:
                            image = new(@"/Resources/Survivor_Items/Addons/Maps/MapAddendum.png", UriKind.Relative);
                            return image;

                        default:
                            image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                            return image;
                    }

                //keys
                case 1:
                case 3:
                case 7:
                    
                    /*
                     * 0 = blood amber
                     * 1 = milky glass
                     * 2 = unique wedding ring
                     * 3 = weaved ring
                     * 4 = gold token
                     * 5 = eroded token
                     * 6 = prayer beads
                     * 7 = scratched pearl
                     * 8 = prayer rope
                     * 
                     * */

                    switch(input)
                    {
                        //blood amber
                        case 0:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/BloodAmber.png", UriKind.Relative);
                            return image;

                        // milky glass
                        case 1:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/MilkyGlass.png", UriKind.Relative);
                            return image;

                        //unique wedding ring
                        case 2:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/UniqueWeddingRing.png", UriKind.Relative);
                            return image;
                       
                        //weaved ring
                        case 3:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/WeavedRing.png", UriKind.Relative);
                            return image;
                       
                        // gold token
                        case 4:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/GoldToken.png", UriKind.Relative);
                            return image;
                       
                        // eroded token
                        case 5:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/ErodedToken.png", UriKind.Relative);
                            return image;
                       
                        //prayer beads
                        case 6:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/PrayerBeads.png", UriKind.Relative);
                            return image;

                        //scratched pearl
                        case 7:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/ScratchedPearl.png", UriKind.Relative);
                            return image;

                        // prayer rope
                        case 8:
                            image = new(@"/Resources/Survivor_Items/Addons/Keys/PrayerRope.png", UriKind.Relative);
                            return image;


                        default:
                            image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                            return image;
                    }

                // toolboxes
                case 2:
                case 4:
                case 8:
                case 11:
                case 15:
                case 17:
                case 21:
                case 23:
                case 26:
                    switch(input)
                    {
                        /*
                         * 0 = Brand New Part
                         * 1 = Grip Wrench
                         * 2 = Hacksaw
                         * 3 = Cutting Wire
                         * 4 = Protective Gloves
                         * 5 = Socket Swivels
                         * 6 = Spring Clamp
                         * 7 = Wire Spool
                         * 8 = Clean Rag
                         * 9 = Instructions
                         * 10 = Scraps
                         * 
                         * 
                         * */

                        // brand new part
                        case 0:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/BrandNewPart.png", UriKind.Relative);
                            return image;
                        
                        // Grip Wrench
                        case 1:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/GripWrench.png", UriKind.Relative);
                            return image;
                        
                        // hacksaw
                        case 2:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/Hacksaw.png", UriKind.Relative);
                            return image;
                        
                        // cutting wire
                        case 3:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/CuttingWire.png", UriKind.Relative);
                            return image;
                        
                        // protective gloves
                        case 4:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/ProtectiveGloves.png", UriKind.Relative);
                            return image;

                        // socket swivels
                        case 5:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/SocketSwivels.png", UriKind.Relative);
                            return image; 
                            
                        // spring clamp
                        case 6:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/SpringClamp.png", UriKind.Relative);
                            return image; 
                            
                        // Wire Spool
                        case 7:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/WireSpool.png", UriKind.Relative);
                            return image; 
                            
                        // Clean Rag
                        case 8:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/CleanRag.png", UriKind.Relative);
                            return image;

                        // Instructions
                        case 9:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/Instructions.png", UriKind.Relative);
                            return image;
                       
                        // Scraps
                        case 10:
                            image = new(@"/Resources/Survivor_Items/Addons/Toolbox/Scraps.png", UriKind.Relative);
                            return image;

                        default:
                            image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                            return image;
                    }

                // medkits
                case 5:
                case 9:
                case 13:
                case 16:
                case 18:
                case 20:
                case 25:

                    switch(input)
                    {
                        /*
                         * 0 = anti-haemorrhagic syringe
                         * 1 = styptic agent
                         * 2 = abdominal dressing
                         * 3 = gel dressing
                         * 4 = surgical suture
                         * 5 = gauze roll
                         * 6 = medical scissors
                         * 7 = needle & thread
                         * 8 = self adherent wrap
                         * 9 = sponge
                         * 10 = bandages
                         * 11 = butterfly tape
                         * 12 = rubber gloves
                         * 13 = refined serum
                         * 
                         * 
                         * */

                        // anti-haemorrhagic syringe
                        case 0:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/Anti-haemorrhagicSyringe.png", UriKind.Relative);
                            return image;

                        // styptic agent
                        case 1:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/StypticAgent.png", UriKind.Relative);
                            return image;

                        //abdominal dressing
                        case 2:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/AbdominalDressing.png", UriKind.Relative);
                            return image;

                        //Gel dressing
                        case 3:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/GelDressings.png", UriKind.Relative);
                            return image;

                        //surgical suture
                        case 4:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/SurgicalSuture.png", UriKind.Relative);
                            return image;

                        // gauze roll
                        case 5:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/GauzeRoll.png", UriKind.Relative);
                            return image;

                        // medical scissors
                        case 6:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/MedicalScissors.png", UriKind.Relative);
                            return image;

                        // needle and thread
                        case 7:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/NeedleAndThread.png", UriKind.Relative);
                            return image;

                        //self adherent wrap
                        case 8:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/SelfAdherentWrap.png", UriKind.Relative);
                            return image;

                        // sponge
                        case 9:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/Sponge.png", UriKind.Relative);
                            return image;

                        // bandages
                        case 10:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/Bandages.png", UriKind.Relative);
                            return image;

                        //Butterfly tape
                        case 11:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/ButterflyTape.png", UriKind.Relative);
                            return image;

                        // rubber gloves
                        case 12:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/RubberGloves.png", UriKind.Relative);
                            return image;

                        // refined serum
                        case 13:
                            image = new(@"/Resources/Survivor_Items/Addons/Medkit/RefinedSerum.png", UriKind.Relative);
                            return image;


                        default:
                            image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                            return image;

                    }

                // flashlights
                case 6:
                case 12:
                case 14:
                case 19:
                case 24:
                case 28:
                    switch(input)
                    {
                        /* 
                         * 0 = odd bulb
                         * 1 = high end sapphire lens
                         * 2 = intense halogen
                         * 3 = long life battery
                         * 4 = focus lens
                         * 5 = heavy duty battery
                         * 6 = low amp filament
                         * 7 = rubber grip
                         * 8 = tir optic
                         * 9 = battery
                         * 10 = leather grip
                         * 11 = power bulb
                         * 12 = wide lens
                         * 13 = broken bulb
                         */

                        // odd bulb
                        case 0:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/OddBulb.png", UriKind.Relative);
                            return image;

                        // high-end sapphire lens
                        case 1:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/High-EndSapphireLens.png", UriKind.Relative);
                            return image;

                        // intense halogen
                        case 2:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/IntenseHalogen.png", UriKind.Relative);
                            return image;
                        
                        // long life battery
                        case 3:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/LongLifeBattery.png", UriKind.Relative);
                            return image;

                        // focus lens
                        case 4:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/FocusLens.png", UriKind.Relative);
                            return image;

                        // heavy duty battery
                        case 5:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/HeavyDutyBattery.png", UriKind.Relative);
                            return image;

                        // low amp filament
                        case 6:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/LowAmpFilament.png", UriKind.Relative);
                            return image;

                        // rubber grip
                        case 7:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/RubberGrip.png", UriKind.Relative);
                            return image;

                        //tir optic
                        case 8:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/TirOptic.png", UriKind.Relative);
                            return image;

                        // battery
                        case 9:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/Battery.png", UriKind.Relative);
                            return image;

                        //leather grip
                        case 10:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/LeatherGrip.png", UriKind.Relative);
                            return image;

                        // power bulb
                        case 11:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/PowerBulb.png", UriKind.Relative);
                            return image;

                        // wide lens
                        case 12:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/WideLens.png", UriKind.Relative);
                            return image;

                        // broken bulb
                        case 13:
                            image = new(@"/Resources/Survivor_Items/Addons/Flashlight/BrokenBulb.png", UriKind.Relative);
                            return image;

                        default:
                            image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                            return image;
                    }


                default:
                    image = new(@"/Resources/Misc/Addon_Backgrounds/Background_Common.png", UriKind.Relative);
                    return image;
            }
        }
    }
}
