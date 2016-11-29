using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Program
    {

        

        public static void Main()
        {

            string PlyrClass = "none";
            int PlyrStr = 0;
            int PlyrDef = 0;
            int PlyrSpd = 0;

            WhichClass:
            Console.WriteLine("Which class would you like to play as?");
            Console.WriteLine("1. Fighter");
            Console.WriteLine("2. Mage");
            int ClassSelect = int.Parse(Console.ReadLine());
            if (ClassSelect != 1 && ClassSelect != 2)
            {
                Console.WriteLine("Please press 1 or 2.");
                goto WhichClass;
            }
            else if (ClassSelect == 1)
            {
                SetFighterStats(out PlyrStr, out PlyrDef, out PlyrSpd);
                PlyrClass = "Fighter";                     
            }
            else
            {
                SetMageStats(out PlyrStr, out PlyrDef, out PlyrSpd);
                PlyrClass = "Mage";
            }

            Console.WriteLine("Player class: {0}", PlyrClass);
            Console.WriteLine("Player Strength: {0}", PlyrStr);
            Console.WriteLine("Player Defense: {0}", PlyrDef);
            Console.WriteLine("Player Speed: {0}", PlyrSpd);
            Console.ReadKey();


        }

        public static void PlayerDamage(out int PlyrDmgTkn)
        {
            int EnStr = 0;
            int PlyrDef = 0;

            Random dmg = new Random();
            EnStr = dmg.Next(5, 20);
            PlyrDef = dmg.Next(5, 10);
        
            PlyrDmgTkn = EnStr - PlyrDef;
            if (PlyrDmgTkn < 0) PlyrDmgTkn = 0;
        }

        public static void SetFighterStats(out int PlyrStr, out int PlyrDef, out int PlyrSpd)
        {
            Random stats = new Random();
            PlyrStr = (stats.Next(5,13) + 7);
            PlyrDef = (stats.Next(5, 15) + 5);
            PlyrSpd = (stats.Next(2, 10) + 2);

        }
        public static void SetMageStats(out int PlyrStr, out int PlyrDef, out int PlyrSpd)
        {
            Random stats = new Random();
            PlyrStr = (stats.Next(5, 11) + 0);
            PlyrDef = (stats.Next(2, 10) + 2);
            PlyrSpd = (stats.Next(10, 15) + 2);

        }

    }
}
