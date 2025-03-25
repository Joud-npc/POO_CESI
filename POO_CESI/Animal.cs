namespace Animals;

class Animal
{
    public string Name;

    public Animal(string name)
    {
            Name = name;
    }

    public void Afficher()
    {
        Console.WriteLine($"Name: {Name}");
    }
}