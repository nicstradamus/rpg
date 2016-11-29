using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace RPG
{
    class Program
    {

        public static void Main()
        {
            //Inits
            string P1Class = string.Empty;
            string P1Name = string.Empty;

            int P1Xp = 0;

          
            int P1Str = 0;
            int P1Dex = 0;
            int P1Con = 0;
            int P1Int = 0;
            int P1Wis = 0;
            int P1Cha = 0;

            //Function Calls
            AssignAbilities(ref P1Str, ref P1Dex, ref P1Con, ref P1Int, ref P1Wis, ref P1Cha);


        }

        
        public static void ChooseClass(out string P1Class)
        {
            P1Class = "none";

            WhichClass:
            Console.Clear();
            Console.WriteLine("Choose a class.");
            Console.WriteLine("1. Fighter");
            Console.WriteLine("2. Mage");
            string ClassSelect = Console.ReadLine();
            if (ClassSelect != "1" && ClassSelect != "2")
            {
                Console.Clear();
                Console.WriteLine("Please choose 1 or 2.");
                Console.ReadKey();
                Console.Clear();
                goto WhichClass;
            }
            else if (ClassSelect == "1")
            {
                P1Class = "Fighter";
            }
            else
            {
                P1Class = "Mage";
            }


        }
        public static void ChooseName(out string P1Name)
        {
            ChooseName:
            Console.Clear();
            Console.WriteLine("Choose a name.");
            string P1NameLow = Console.ReadLine();
            P1Name = P1NameLow.ToUpper();
            if (P1Name.Length < 1)
            {
                Console.Clear();
                Console.WriteLine("Your name must be at least 1 character long.");
                Console.ReadKey();
                goto ChooseName;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hello " + P1Name);
                Console.ReadKey();
            }
        }
        public static void ChooseRace(ref string P1Race)
        {
            string raceChoice = string.Empty;

            WhichRace:
            Console.WriteLine("Choose a race.");
            Console.WriteLine("______________");
            Console.WriteLine("");

            Console.WriteLine("1. Dwarf: Con +1, Cha -1");
            Console.WriteLine("2. Elf: Dex +1, Con -1");
            Console.WriteLine("3. Gnome: Int +1, Wis -1");
            Console.WriteLine("4. Half-elf: no adjustments");
            Console.WriteLine("5. Halfling: Dex +1, Str -1");
            Console.WriteLine("6. Human: no adjustments");


            raceChoice = Console.ReadLine();
            if (raceChoice != "1" && raceChoice != "2" && raceChoice != "3" && raceChoice != "4" && raceChoice != "5" && raceChoice != "6")
            {
                Console.Clear();
                Console.WriteLine("Please select the number next to the race you'd like to play.");
                Console.ReadKey();
                Console.Clear();
                goto WhichRace;
            }else
                switch (raceChoice)
                {
                    case "1":
                        P1Race = "Dwarf";
                        break;
                    case "2":
                        P1Race = "Elf";
                        break;
                    case "3":
                        P1Race = "Gnome";
                        break;
                    case "4":
                        P1Race = "Half-elf";
                        break;
                    case "5":
                        P1Race = "Halfling";
                        break;
                    case "6":
                        P1Race = "Human";
                        break;
                }
        }


        public static void LoadAnim()
        {

            int LoadCount = 0;

            LoadCheck:

            if (LoadCount < 2)
            {
                Console.Clear();
                Console.WriteLine("Generating player stats");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Generating player stats.");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Generating player stats..");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Generating player stats...");
                System.Threading.Thread.Sleep(500);
                Console.Clear();

                LoadCount = LoadCount + 1;
                goto LoadCheck;
            }


        }
        public static void BattleAnim()
        {


            Console.WriteLine("-===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("--===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("E---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("LE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("TLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("TTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("ATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("-BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("--BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("---BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("=---BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("==---BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("<===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("<<===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(25);
            Console.Clear();
            Console.WriteLine("<<<===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("<<<===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("<<<===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("<<<===---BATTLE---===>>>");
            System.Threading.Thread.Sleep(750);

            Console.Clear();

        }
        public static void AbilityRoll(ref int stat1, ref int stat2, ref int stat3, ref int stat4, ref int stat5, ref int stat6)
        {


            Random sr = new Random();
            int statroll1A = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll2A = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll3A = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll4A = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll5A = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll6A = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);


            int statroll1B = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll2B = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll3B = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll4B = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll5B = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);
            int statroll6B = sr.Next(1, 7) + sr.Next(1, 7) + sr.Next(1, 7);


            stat1 = (statroll1A > statroll1B) ? statroll1A : statroll1B;
            stat2 = (statroll2A > statroll2B) ? statroll2A : statroll2B;
            stat3 = (statroll3A > statroll3B) ? statroll3A : statroll3B;
            stat4 = (statroll4A > statroll4B) ? statroll4A : statroll4B;
            stat5 = (statroll5A > statroll5B) ? statroll5A : statroll5B;
            stat6 = (statroll6A > statroll6B) ? statroll6A : statroll6B;

            Console.WriteLine("ABILITY SCORES:");
            Console.WriteLine("Each number represents the higher of two rolls (3d6).");
            Console.WriteLine("Think about which scores you'd like to assign to each ");
            Console.WriteLine("of your six character abilities.  ");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(" ");

            Console.WriteLine("a: " + stat1);
            Console.WriteLine("b. " + stat2);
            Console.WriteLine("c. " + stat3);
            Console.WriteLine("d. " + stat4);
            Console.WriteLine("e. " + stat5);
            Console.WriteLine("f. " + stat6);
            Console.ReadKey();


        }
        public static void AssignAbilities(ref int P1Str, ref int P1Dex, ref int P1Con, ref int P1Int, ref int P1Wis, ref int P1Cha)
        {
            P1Str = 0; P1Dex = 0; P1Con = 0; P1Int = 0; P1Wis = 0; P1Cha = 0;
            int stat1 = 0; int stat2 = 0; int stat3 = 0; int stat4 = 0; int stat5 = 0; int stat6 = 0;
           

            string na = "--";
            string ability = "Strength";
            string used = "Please choose a score that has not already been selected.";
                

            AbilityRoll(ref stat1, ref stat2, ref stat3, ref stat4, ref stat5, ref stat6);
            String PHstat1 = stat1.ToString();
            String PHstat2 = stat2.ToString();
            String PHstat3 = stat3.ToString();
            String PHstat4 = stat4.ToString();
            String PHstat5 = stat5.ToString();
            String PHstat6 = stat6.ToString();

            Start:
            //if (ability == "done")
            //{
            //    Console.WriteLine("All scores assigned.");
            //    Console.ReadKey();
            //}
            //else
            //{

                Console.Clear();
                Console.WriteLine("ASSIGN ABILITY SCORES:");
                Console.WriteLine("______________________");
                Console.WriteLine("");
                Console.WriteLine("Which score would you like to assign your {0} ability?", ability);
                Console.WriteLine("");
                Console.WriteLine("SCORES:");
                Console.WriteLine("");
                Console.WriteLine("a: {0}  b: {1}  c: {2}  d: {3}  e: {4}  f: {5}", PHstat1, PHstat2, PHstat3, PHstat4, PHstat5, PHstat6);
                Console.WriteLine("");
                Console.WriteLine("ABILITIES:");
                Console.WriteLine("");
                Console.WriteLine("Strength:     {0}", P1Str);
                Console.WriteLine("Dexterity:    {0}", P1Dex);
                Console.WriteLine("Constitution: {0}", P1Con);
                Console.WriteLine("Intelligence: {0}", P1Int);
                Console.WriteLine("Wisdom:       {0}", P1Wis);
                Console.WriteLine("Charisma:     {0}", P1Cha);
                
                
                string lowerChoice = Console.ReadLine();
                string choice = lowerChoice.ToUpper();




                if (choice != "A" && choice != "B" && choice != "C" && choice != "D" && choice != "E" && choice != "F")
                {
                    Console.WriteLine("Please type the letter next to the score you want to assign (A-F).");
                    Console.ReadKey();
                    goto Start;
                }
                else if (choice == "A" && PHstat1 == "--")
                {
                    Console.WriteLine(used);
                    System.Threading.Thread.Sleep(3000);
                    goto Start;

                }
                else if (choice == "B" && PHstat2 == "--")
                {
                    Console.WriteLine(used);
                    System.Threading.Thread.Sleep(3000);
                    goto Start;
                }
                else if (choice == "C" && PHstat3 == "--")
                {
                    Console.WriteLine(used);
                    System.Threading.Thread.Sleep(3000);
                    goto Start;
                }
                else if (choice == "D" && PHstat4 == "--")

                {
                    Console.WriteLine(used);
                    System.Threading.Thread.Sleep(3000);
                    goto Start;
                }
                else if (choice == "E" && PHstat5 == "--")
                {
                    Console.WriteLine(used);
                    System.Threading.Thread.Sleep(3000);
                    goto Start;
                }

                else if (choice == "F" && PHstat6 == "--")
                {
                    Console.WriteLine(used);
                    System.Threading.Thread.Sleep(3000);
                    goto Start;
                }
                else if



               (ability == "Strength")
                {
                    switch (choice)
                    {
                        case "A":
                            P1Str = stat1;
                            PHstat1 = "--";
                            ability = "Dexterity";
                            goto Start;
                        case "B":
                            P1Str = stat2;
                            PHstat2 = "--";
                            ability = "Dexterity";
                            goto Start;
                        case "C":
                            P1Str = stat3;
                            PHstat3 = "--";
                            ability = "Dexterity";
                            goto Start;
                        case "D":
                            P1Str = stat4;
                            PHstat4 = "--";
                            ability = "Dexterity";
                            goto Start;
                        case "E":
                            P1Str = stat5;
                            PHstat5 = "--";
                            ability = "Dexterity";
                            goto Start;
                        case "F":
                            P1Str = stat6;
                            PHstat6 = "--";
                            ability = "Dexterity";
                            goto Start;
                    }

                }
                else if (ability == "Dexterity")
                {
                    switch (choice)
                    {
                        case "A":
                            P1Dex = stat1;
                            PHstat1 = "--";
                            ability = "Constitution";
                            goto Start;
                        case "B":
                            P1Dex = stat2;
                            PHstat2 = "--";
                            ability = "Constitution";
                            goto Start;
                        case "C":
                            P1Dex = stat3;
                            PHstat3 = "--";
                            ability = "Constitution";
                            goto Start;
                        case "D":
                            P1Dex = stat4;
                            PHstat4 = "--";
                            ability = "Constitution";
                            goto Start;
                        case "E":
                            P1Dex = stat5;
                            PHstat5 = "--";
                            ability = "Constitution";
                            goto Start;
                        case "F":
                            P1Dex = stat6;
                            PHstat6 = "--";
                            ability = "Constitution";
                            goto Start;

                    }
                }
                else if (ability == "Constitution")
                {
                    switch (choice)
                    {
                        case "A":
                            P1Con = stat1;
                            PHstat1 = "--";
                            ability = "Intelligence";
                            goto Start;
                        case "B":
                            P1Con = stat2;
                            PHstat2 = "--";
                            ability = "Intelligence";
                            goto Start;
                        case "C":
                            P1Con = stat3;
                            PHstat3 = "--";
                            ability = "Intelligence";
                            goto Start;
                        case "D":
                            P1Con = stat4;
                            PHstat4 = "--";
                            ability = "Intelligence";
                            goto Start;
                        case "E":
                            P1Con = stat5;
                            PHstat5 = "--";
                            ability = "Intelligence";
                            goto Start;
                        case "F":
                            P1Con = stat6;
                            PHstat6 = "--";
                            ability = "Intelligence";
                            goto Start;

                    }
                }
                else if (ability == "Intelligence")
                {
                    switch (choice)
                    {
                        case "A":
                            P1Int = stat1;
                            PHstat1 = "--";
                            ability = "Wisdom";
                            goto Start;
                        case "B":
                            P1Int = stat2;
                            PHstat2 = "--";
                            ability = "Wisdom";
                            goto Start;
                        case "C":
                            P1Int = stat3;
                            PHstat3 = "--";
                            ability = "Wisdom";
                            goto Start;
                        case "D":
                            P1Int = stat4;
                            PHstat4 = "--";
                            ability = "Wisdom";
                            goto Start;
                        case "E":
                            P1Int = stat5;
                            PHstat5 = "--";
                            ability = "Wisdom";
                            goto Start;
                        case "F":
                            P1Int = stat6;
                            PHstat6 = "--";
                            ability = "Wisdom";
                            goto Start;

                    }
                }
                else if (ability == "Wisdom")
                {
                    switch (choice)
                    {
                        case "A":
                            P1Wis = stat1;
                            PHstat1 = "--";
                            ability = "Charisma";
                            goto Start;
                        case "B":
                            P1Wis = stat2;
                            PHstat2 = "--";
                            ability = "Charisma";
                            goto Start;
                        case "C":
                            P1Wis = stat3;
                            PHstat3 = "--";
                            ability = "Charisma";
                            goto Start;
                        case "D":
                            P1Wis = stat4;
                            PHstat4 = "--";
                            ability = "Charisma";
                            goto Start;
                        case "E":
                            P1Wis = stat5;
                            PHstat5 = "--";
                            ability = "Charisma";
                            goto Start;
                        case "F":
                            P1Wis = stat6;
                            PHstat6 = "--";
                            ability = "Charisma";
                            goto Start;

                    }
                }
                else if (ability == "Charisma")
                {
                    switch (choice)
                    {
                        case "A":
                            P1Cha = stat1;
                            PHstat6 = "--";
                            ability = "done";
                        Console.Clear();
                        Console.WriteLine("ALL SCORES ASSIGNED!");
                        Console.WriteLine("");
                      
                        Console.WriteLine("ABILITIES:");
                        Console.WriteLine("");
                        Console.WriteLine("Strength:     {0}", P1Str);
                        Console.WriteLine("Dexterity:    {0}", P1Dex);
                        Console.WriteLine("Constitution: {0}", P1Con);
                        Console.WriteLine("Intelligence: {0}", P1Int);
                        Console.WriteLine("Wisdom:       {0}", P1Wis);
                        Console.WriteLine("Charisma:     {0}", P1Cha);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;

                        case "B":
                            P1Cha = stat2;
                            PHstat6 = "--";
                            ability = "done";
                        Console.Clear();
                        Console.WriteLine("ALL SCORES ASSIGNED!");
                        Console.WriteLine("");

                        Console.WriteLine("ABILITIES:");
                        Console.WriteLine("");
                        Console.WriteLine("Strength:     {0}", P1Str);
                        Console.WriteLine("Dexterity:    {0}", P1Dex);
                        Console.WriteLine("Constitution: {0}", P1Con);
                        Console.WriteLine("Intelligence: {0}", P1Int);
                        Console.WriteLine("Wisdom:       {0}", P1Wis);
                        Console.WriteLine("Charisma:     {0}", P1Cha);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;

                        case "C":
                            P1Cha = stat3;
                            PHstat6 = "--";
                            ability = "done";
                        Console.Clear();
                        Console.WriteLine("ALL SCORES ASSIGNED!");
                        Console.WriteLine("");

                        Console.WriteLine("ABILITIES:");
                        Console.WriteLine("");
                        Console.WriteLine("Strength:     {0}", P1Str);
                        Console.WriteLine("Dexterity:    {0}", P1Dex);
                        Console.WriteLine("Constitution: {0}", P1Con);
                        Console.WriteLine("Intelligence: {0}", P1Int);
                        Console.WriteLine("Wisdom:       {0}", P1Wis);
                        Console.WriteLine("Charisma:     {0}", P1Cha);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;
                        case "D":
                            P1Cha = stat4;
                            PHstat6 = "--";
                            ability = "done";
                        Console.Clear();
                        Console.WriteLine("ALL SCORES ASSIGNED!");
                        Console.WriteLine("");

                        Console.WriteLine("ABILITIES:");
                        Console.WriteLine("");
                        Console.WriteLine("Strength:     {0}", P1Str);
                        Console.WriteLine("Dexterity:    {0}", P1Dex);
                        Console.WriteLine("Constitution: {0}", P1Con);
                        Console.WriteLine("Intelligence: {0}", P1Int);
                        Console.WriteLine("Wisdom:       {0}", P1Wis);
                        Console.WriteLine("Charisma:     {0}", P1Cha);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;
                        case "E":
                            P1Cha = stat5;
                            PHstat5 = "--";
                            ability = "done";
                        Console.Clear();
                        Console.WriteLine("ALL SCORES ASSIGNED!");
                        Console.WriteLine("");

                        Console.WriteLine("ABILITIES:");
                        Console.WriteLine("");
                        Console.WriteLine("Strength:     {0}", P1Str);
                        Console.WriteLine("Dexterity:    {0}", P1Dex);
                        Console.WriteLine("Constitution: {0}", P1Con);
                        Console.WriteLine("Intelligence: {0}", P1Int);
                        Console.WriteLine("Wisdom:       {0}", P1Wis);
                        Console.WriteLine("Charisma:     {0}", P1Cha);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break; 
                        case "F":
                            P1Cha = stat6;
                            PHstat6 = "--";
                            ability = "done";
                        Console.Clear();
                        Console.WriteLine("ALL SCORES ASSIGNED!");
                        Console.WriteLine("");

                        Console.WriteLine("ABILITIES:");
                        Console.WriteLine("");
                        Console.WriteLine("Strength:     {0}", P1Str);
                        Console.WriteLine("Dexterity:    {0}", P1Dex);
                        Console.WriteLine("Constitution: {0}", P1Con);
                        Console.WriteLine("Intelligence: {0}", P1Int);
                        Console.WriteLine("Wisdom:       {0}", P1Wis);
                        Console.WriteLine("Charisma:     {0}", P1Cha);
                        Console.WriteLine("");
                        Console.ReadKey();
                        break;
                        
                    }

                







                }





            

        }

        public static void HelpText()
        {
            string Help0 = "";

            string Help_AbilityScores = null;
            

        }





    }
}

