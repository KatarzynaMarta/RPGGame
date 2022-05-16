using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Statistics
    {
        public static void Stats(Hero hero)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("STATYSTYKI:");
            Console.WriteLine($"Zdrowie:\t{ hero.Health}");
            Console.WriteLine($"Zabite potwory:\t{ hero.RoundsWon}");
            Console.WriteLine($"Zloto:\t\t{ hero.Gold}");
            Console.WriteLine($"Level:\t\t{ hero.Level}");
            
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
