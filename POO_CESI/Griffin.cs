namespace POO_CESI;

class Griffin : Animal, IPilotage
{
    public Griffin(string name, int id) : base(name, rareté:"Epic", id) {}
    public override void Move()
    {
        Console.WriteLine("Le Griffin vole dans les airs !");
    }

    public void Moove()
    {
        Console.WriteLine("Le Griffin se déplace dans les airs !");
    }
}