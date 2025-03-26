namespace POO_CESI;

class Dragon : Animal, IPilotage
{
    public Dragon(string name, int id) : base(name, rareté:"Legendary", id) {}
    public override void Move()
    {
        Console.WriteLine("Le Dragon plane majestueusement !");
    }

    public new void Sleep()
    {
        Console.WriteLine("Le Dragon dort dans sa caverne !");
    }

    public void Moove()
    {
        Console.WriteLine("Le Dragon se déplace majestueusement !");
    }
}