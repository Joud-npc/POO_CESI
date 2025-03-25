namespace Animals
{
    abstract class Animal
    {
        public string Name;
        public Animal(string name)
        {
            Name = name;
        }
        public virtual void Move()
        {
            Console.WriteLine("L'animal se déplace.");
        }
        public void Sleep()
        {
            Console.WriteLine("L'animal dort.");
        }
    }

    class Griffin : Animal, IPilotage
    {
        public Griffin(string name) : base(name) {}
        public override void Move()
        {
            Console.WriteLine("Le Griffin vole dans les airs !");
        }

        public void Moove()
        {
            Console.WriteLine("Le Griffin se déplace dans les airs !");
        }
    }

    class Dragon : Animal, IPilotage
    {
        public Dragon(string name) : base(name) {}
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
}