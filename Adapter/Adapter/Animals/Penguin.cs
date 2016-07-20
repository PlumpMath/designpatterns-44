namespace Adapter
{
    public class Penguin : Animal, IFlyable
    {
        public Penguin(string name) : base(name) { }

        public string Fly() => $"{Name} the {nameof(Penguin)} cannot fly.";
    }
}
