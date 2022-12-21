﻿using System;
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


                default:
                    image = new(@"/Resources/Misc/Transparent_Background.png", UriKind.Relative);
                    return image;

            }
        }

    }
}