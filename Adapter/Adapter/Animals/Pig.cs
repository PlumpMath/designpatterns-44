namespace Adapter
{
    public class Pig : Animal, IFlyable
    {
        public Pig(string name) : base(name) { }

        public string Fly() => $"{Name} the {nameof(Pig)} is flying!";
    }
}
