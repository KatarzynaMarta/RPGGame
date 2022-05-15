// See https://aka.ms/new-console-template for more information

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
        public GameRounds()
        {

        }


        public static void GameRound(ref int health, ref int mHealth)
        {
            Random dice = new Random();

            //klasy przywolane 
            Hero hero = new Hero();
            Monster monster = new Monster();


            int hit = 10;
            int round = 0;

            //rozgrywka
            do
            {
                int roll = dice.Next(1, hit + 1);
                mHealth -= roll;
                round++;
                CYellow();
                Console.WriteLine("Tura:{0}", round);
                CWhite();
                Console.WriteLine("Bohater bije potwora\t {0 } punktow ", roll);
                Console.WriteLine("Potwor posiada teraz\t {0} punktow\n", mHealth);
                if (mHealth <= 0) continue;
                roll = dice.Next(1, hit + 1);
                health -= roll;
                Console.WriteLine($"Potwor bije bohatera\t {roll} punktow ");
                CBlue();
                Console.WriteLine($"Bohater posiada teraz\t {health} punktow\n");
                CWhite();
            } while (mHealth > 0 && health > 0);
            Console.WriteLine($"Koniec walki po\t{round} turach");
            CBlue();
            Console.WriteLine($"Bohater posiada teraz\t {health} punktow");
            CWhite();
            Console.WriteLine($"Potwor posiada teraz\t {mHealth} punktow\n");
            if (health > mHealth)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Wygrales");
                CWhite();
                hero.Image();
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

            int health = hero.Health;
            Random dice = new Random();


            do
            {
                int mHealth = dice.Next(1, monster.Health + 1); //random monster health
                RenderBase.RenderLine(windowWidth);
                CBlue();
                Console.WriteLine("\n1.Bohater posiada:\t{0}\tpunktow zdrowia", health);
                CWhite();
                Console.WriteLine("2.Potwor posiada:\t{0}\tpunktow zdrowia ", mHealth);
                RenderBase.RenderLine(windowWidth);
                
                GameRound(ref health, ref mHealth);
                hero.RoundsWon++;
            }
            while (health > 0);

            Console.WriteLine("Game Over");
            Console.WriteLine("STATYSTYKI:");
            Console.WriteLine($"Zabite potwory :{hero.RoundsWon}");

        }


    }
}