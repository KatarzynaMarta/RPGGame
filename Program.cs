﻿// See https://aka.ms/new-console-template for more information

//Reguły gry
//Bohater i potwór rozpoczną grę z 10 punktami zdrowia.
//Wszystkie ataki będą mieć wartość z przedziału od 1 do 10.
//Bohater atakuje jako pierwszy.
//Wyświetl liczbę punktów zdrowia utraconą przez potwora oraz liczbę jego pozostałych punktów zdrowia.
//Jeśli liczba punktów zdrowia potwora jest większa niż 0, może on zaatakować bohatera.
//Wyświetl liczbę punktów zdrowia utraconą przez bohatera oraz liczbę jego pozostałych punktów zdrowia.
//Kontynuuj tę sekwencję ataków, dopóki liczba punktów zdrowia bohatera lub potwora nie będzie mniejsza ani równa zero.
//Wyświetl, kto zwyciężył.
// Set the WindowHeight
using RPGGame;
static GameRounds()
{
    Game_Name();
    int health = 10;
    int monster = health;
    int hero = health;
    int tura = 0;
    Random dice = new Random();
    
    Console.Write("Bohater posiada  {0} punktow zdrowia\t", hero);
    Console.WriteLine("Potwor posiada {0} punktow zdrowia ", monster);
   

    {
        int roll = dice.Next(1, health + 1);
        monster -= roll;
        tura++;

        Console.WriteLine("Tura:{0}", tura);
        Console.WriteLine("Bohater bije potwora {0 } punktow ", roll);
        Console.WriteLine("Potwor posiada teraz {0} punktow\n", monster);
        if (monster > 0)
        {
            roll = dice.Next(1, health + 1);
            hero -= roll;
            Console.WriteLine("Potwor bije bohatera o {0} punktow ", roll);
            Console.WriteLine("Bohater posiada teraz {0} punktow\n", hero);
        }
    } while (monster > 0 && hero > 0) ;
    Console.WriteLine($"Bohater posiada teraz {hero} punktow");
    Console.WriteLine($"Potwor posiada teraz {monster} punktow\n");

    if (hero > monster)
    {
        Console.WriteLine("Wygrales!");
        Console.WriteLine(new Hero());
    }

    else
    {
        Console.WriteLine("Przegrales.Potwor zwycieza!");
        Console.WriteLine(new Dragon());
    }
} 

static void Game_Name()
{
    Console.WriteLine($" \t\t\t\t" + "RPG GAME -ZABIJ POTWORA\n");
    Console.WriteLine(@"Zmienna roll przyjmuje wartosci Random od 1 do 10.
    Jest odejmowana od zdrowia bohatera i potwora.
    Jak zycie sie skonczy, gra sie konczy.");
    Console.WriteLine($"______________");
}

   
Console.ReadLine();