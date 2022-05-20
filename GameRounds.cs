// See https://aka.ms/new-console-template for more information
using RPGGame.Models;
namespace RPGGame

{
    public class GameRounds
    {

        private static void CBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        private static void CWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void CYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void GameRound(ref int mHealth, Hero hero)
        {
            Random dice = new Random();
            
            //klasy przywolane 
            // Hero hero = new Hero();
            Monster monster = new Monster();


            int hit = 10;
            int round = 0;

            //rozgrywka
            do
            {
                int roll = dice.Next(1, hit+hero.Damage + 1);
                mHealth -= roll;
                round++;
                CYellow();
                Console.WriteLine("Tura:{0}", round);
                CWhite();
                Console.WriteLine("Bohater bije potwora\t {0 } punktow ", roll);
                Console.WriteLine("Potwor posiada teraz\t {0} punktow\n", mHealth);
                if (mHealth <= 0) continue;
                roll = dice.Next(1, hit + 1);
                hero.Health -= roll;
                Console.WriteLine($"Potwor bije bohatera\t {roll} punktow ");
                CBlue();
                Console.WriteLine($"Bohater posiada teraz\t {hero.Health} punktow\n");
                CWhite();
            } while (mHealth > 0 && hero.Health > 0);
            Console.WriteLine($"Koniec walki po\t{round} turach");
            CBlue();
            Console.WriteLine($"Bohater posiada teraz\t {hero.Health} punktow");
            CWhite();
            Console.WriteLine($"Potwor posiada teraz\t {mHealth} punktow\n");
            if (hero.Health > mHealth)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wygrales");
                CWhite();
                // hero.Image();
                hero.Gold += 10;
                hero.RoundsWon++;
               // hero.Health = health;
                hero.Level++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Przegrales");
                CWhite();
                monster.Image();

            }
        }

        public static void GameOn()
        {
            int windowWidth = Console.WindowWidth;

            Hero hero = new Hero();
            Monster monster = new Monster();

      
            Random dice = new Random();


            do
            {
                //int mHealth = 10;
                int mHealth = dice.Next(1, monster.Health + hero.Level); //random monster health
                RenderBase.RenderLine(windowWidth);
                CBlue();
                Console.WriteLine("\n1.Bohater posiada:\t{0}\tpunktow zdrowia", hero.Health);
                CWhite();
                Console.WriteLine("2.Potwor posiada:\t{0}\tpunktow zdrowia ", mHealth);
                RenderBase.RenderLine(windowWidth);
                
                GameRound(ref mHealth, hero);
                
                Statistics.Stats(hero);
                //Sklep
                if (hero.Health > 0)
                {
                   Console.WriteLine("Sklep ? y/n");
                    // var key = Console.ReadKey();
                    bool key =ConfirmKey();
                    Console.WriteLine(key); 
                    if (key == true)
                    {
                        Console.Clear();
                        Store.Buy(hero);
                        
                    }
                    Console.Clear(); ;
                                       
                }
               
            }
            while (hero.Health > 0);
            {
                
                Console.WriteLine("____________________________________________");
            };

            Console.WriteLine("Game Over");
            CYellow();
            Statistics.Stats(hero);
            CWhite();
      

         static bool ConfirmKey()
        {
           
            if (Console.ReadKey(false).Key == ConsoleKey.Y)
            {
                    return true;
            }
                return false;
        }
    }
    }  }
