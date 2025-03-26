namespace POO_CESI;

class Chien : Animal
{
    public Chien(string name, int id) : base(name, rareté:"Common", id) { }

    public override void Move()
    {
        Console.WriteLine("Le Chien plane majestueusement !");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le chien dort dans sa caverne !");
    }

    public void Moove()
    {
        Console.WriteLine("Le Chien walk majestueusement !");
    }
}