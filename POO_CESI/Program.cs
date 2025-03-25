using System;
using Animals;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Que fait votre animal ?\n" +
                      "MOOVE ou SLEEP : ");
        string input = Console.ReadLine();
        Console.WriteLine();
        
        Animal chat = new Animal("Maurice");
                
        if (input.ToLower() == "moove")
        {
            chat.Afficher();
            Console.WriteLine($"MOOVE");
        }
        else if (input.ToLower() == "sleep")
        {
            chat.Afficher();
            Console.WriteLine("SLEEP");
        }
    }
}