namespace Adapter
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public Animal(string name)
        {
            Name = name;
        }
    }
}
