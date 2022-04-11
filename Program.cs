// See https://aka.ms/new-console-template for more information

//Reguły gry
//Bohater i potwór rozpoczną grę z 10 punktami zdrowia.
//Wszystkie ataki będą mieć wartość z przedziału od 1 do 10.
//Bohater atakuje jako pierwszy.
//Wyświetl liczbę punktów zdrowia utraconą przez potwora oraz liczbę jego pozostałych punktów zdrowia.
//Jeśli liczba punktów zdrowia potwora jest większa niż 0, może on zaatakować bohatera.
//Wyświetl liczbę punktów zdrowia utraconą przez bohatera oraz liczbę jego pozostałych punktów zdrowia.
//Kontynuuj tę sekwencję ataków, dopóki liczba punktów zdrowia bohatera lub potwora nie będzie mniejsza ani równa zero.
//Wyświetl, kto zwyciężył.


int health = 10;
int monster = health;
int hero = health;
int tura = 0;
Random dice = new Random();
Console.WriteLine($"RPG GAME -ZABIJ POTWORA\n");
Console.WriteLine("1.Bohater posiada  {0} punktow zdrowia",hero);
Console.WriteLine("2.Potwor posiada {0} punktow zdrowia\n ",monster);
RenderLine(Console.WindowWidth);
static void RenderLine(int WithCHange)
{
    for (int i = 0; i < Console.WindowWidth; i++) Console.Write("-");
    Console.WriteLine($"\n");
}

do
{
    int roll = dice.Next(1, health + 1);
    monster -= roll;
    tura++;

    Console.WriteLine("Tura:{0}",tura);
    Console.WriteLine("Bohater bije potwora {0 } punktow ",hero);
    Console.WriteLine("Potwor posiada teraz {0} punktow\n",monster);
    if (monster <= 0) continue;
    roll = dice.Next(1, health + 1);
    hero -= roll;
    Console.WriteLine($"Potwor bije bohatera o { roll} punktow ");
    Console.WriteLine($"Bohater posiada teraz { hero} punktow\n");
} while (monster > 0 && hero > 0);
Console.WriteLine($"Bohater posiada teraz {hero} punktow");
Console.WriteLine($"Potwor posiada teraz {monster} punktow\n");
Console.WriteLine(hero > monster ? "Wygrales!" : "Przegrales!");
