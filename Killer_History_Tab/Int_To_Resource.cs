using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace DBD_Match_History
{
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
             * 
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

                default:
                    image = new(@"/Resources/Misc/Missing_Person.png", UriKind.Relative);
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

    }
}
