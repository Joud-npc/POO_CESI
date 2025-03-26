namespace POO_CESI;

class Eagle : Animal
{
    public Eagle(string name, int id) : base(name, rareté:"Uncommon", id) {}

    public override void Move()
    {
        Console.WriteLine("Le Eagle plane majestueusement !");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le Eagle dort dans sa caverne !");
    }

    public void Moove()
    {
        Console.WriteLine("Le Eagle fly majestueusement !");
    }
}