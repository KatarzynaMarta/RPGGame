namespace RPGGame.Models
{
    public class Store
    {
        public static int ZElixir { get; set; }
        public static int SElixir { get; set; }

        public Store()
        {
            ZElixir = 20;
            SElixir = 40;
        }

        public static void Buy(Hero hero)
        {
            Store store = new Store();

            Console.WriteLine("SKLEP");
            Console.WriteLine($"Z - Eliksir zdrowia:\t\t{ZElixir}\tOdnawia do 10 zdrowia");
            Console.WriteLine($"S - Eliksir sily:\t\t{SElixir}\tDodaje 10 do sily");
            //Console.WriteLine($"Q - Wyjdz");
            RenderBase.RenderLine(Console.WindowWidth);

            Statistics.Stats(hero);
            if (hero.Gold > 0)
            {



                ConsoleKeyInfo key = Console.ReadKey();
                Console.Write("\b");
                string key_lower = key.KeyChar.ToString().ToLower();
                if (key_lower == "z")
                {
                    if (hero.Gold >= ZElixir) {
                        Console.WriteLine("Kupiles eliksir zdrowia\n");

                        if (hero.Health < ZElixir)
                        {
                            hero.Gold -= ZElixir;
                            hero.Health = 10;
                        }
                    }
                    else {
                        Console.WriteLine("Masz za malo pieniedzy.\n");
                        Console.ReadKey();
                    };
                    }
                if (key_lower == "s")
                {
                    if (hero.Gold >= SElixir)
                    {
                        Console.WriteLine("Kupiles eliksir sily\n");

                        
                        { hero.Gold -= SElixir;
                            hero.Damage = hero.Damage + 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Masz za malo pieniedzy.\n");
                        Console.ReadKey();
                    };
                }
            }

            RenderBase.RenderLine(Console.WindowWidth);
            Statistics.Stats(hero);

        }

        static bool ConfirmKey()
        {

            if (Console.ReadKey(false).Key == ConsoleKey.Y)
            {
                return true;
            }
            return false;
        }

    }

}
