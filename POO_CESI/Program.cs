using System;
using System.Linq;
using Microsoft.Data.SqlClient;
using POO_CESI;

class Program
{
    static void Main(string[] args)
    { 
        List<Animal> rareté = new List<Animal>()
         {
             new Chien("Bob", 1),
             new Bird("Titi", 2),
             new Eagle("Deagle", 3),
             new Griffin("Charle", 4),
             new Dragon("Robert", 5)
         };

         var method = rareté.Where(a => a.Rareté == "Common");
         foreach (Animal animal in method)
         {
             Console.WriteLine($"ID: {animal.Id}, Nom: {animal.Name}");
         }
    }
}