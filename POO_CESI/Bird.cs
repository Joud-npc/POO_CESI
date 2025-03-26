namespace POO_CESI;

class Bird : Animal
{
    public Bird(string name, int id) : base(name, rareté:"Common", id) {}

    public override void Move()
    {
        Console.WriteLine("Le Bird plane majestueusement !");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le Bird dort dans sa caverne !");
    }

    public void Moove()
    {
        Console.WriteLine("Le Bird walk majestueusement !");
    }
}