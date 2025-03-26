namespace POO_CESI;

abstract class Animal
{
    public string Name {get; set;}
    public string Rareté { get; set; }
    public int Id {get; set;}
    public Animal(string name, string rareté, int id)
    {
        Name = name;
        Rareté = rareté;
        Id = id;
    }

    public abstract void Move();
    public void Sleep()
    {
        Console.WriteLine("L'animal dort.");
    }
}