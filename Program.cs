using RPGGame;


//Reguły gry
//Bohater i potwór rozpoczną grę z 10 punktami zdrowia.
//Wszystkie ataki będą mieć wartość z przedziału od 1 do 10.
//Bohater atakuje jako pierwszy.
//Wyświetl liczbę punktów zdrowia utraconą przez potwora oraz liczbę jego pozostałych punktów zdrowia.
//Jeśli liczba punktów zdrowia potwora jest większa niż 0, może on zaatakować bohatera.
//Wyświetl liczbę punktów zdrowia utraconą przez bohatera oraz liczbę jego pozostałych punktów zdrowia.
//Kontynuuj tę sekwencję ataków, dopóki liczba punktów zdrowia bohatera lub potwora nie będzie mniejsza ani równa zero.
//Wyświetl, kto zwyciężył.

Hero hero = new Hero();
int health = hero.Health;
int monster = 10;
int hit = 10;
int tura = 0;
Random dice = new Random();
Console.WriteLine($"RPG GAME -ZABIJ POTWORA\n");
Console.WriteLine("1.Bohater posiada  {0} punktow zdrowia", health);
Console.WriteLine("2.Potwor posiada {0} punktow zdrowia\n ", monster);
RenderLine(Console.WindowWidth);

static void RenderLine(int WithCHange)
{
    for (int i = 0; i < Console.WindowWidth; i++) Console.Write("-");
    Console.WriteLine($"\n");
}

do
{
    int roll = dice.Next(1, hit + 1);
    monster -= roll;
    tura++;

    Console.WriteLine("Tura:{0}", tura);
    Console.WriteLine("Bohater bije potwora\t {0 } punktow ", health);
    Console.WriteLine("Potwor posiada teraz\t {0} punktow\n", monster);
    if (monster <= 0) continue;
    roll = dice.Next(1, hit + 1);
    health -= roll;
    Console.WriteLine($"Potwor bije bohatera\t {roll} punktow ");
    Console.WriteLine($"Bohater posiada teraz\t {health} punktow\n");
} while (monster > 0 && health > 0);
Console.WriteLine($"Bohater posiada teraz\t {health} punktow");
Console.WriteLine($"Potwor posiada teraz\t {monster} punktow\n");
if (health > monster)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Wygrales");
    Console.ForegroundColor = ConsoleColor.White;
    hero.HeroImage()
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Przegrales");
    Console.ForegroundColor = ConsoleColor.White;
    
}

