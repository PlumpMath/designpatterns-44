namespace Builder
{
    public abstract class HouseBuilder
    {
        protected House house;
        public HouseBuilder(string type)
        {
            house = new House(type);
        }
        public House GetHouse() => house;

        public abstract void SetSize();
        public abstract void LayFoundation();
        public abstract void SetupFrame();
        public abstract void ConstructOutsideWalls();
        public abstract void ConstructInsideWalls();
        public abstract void PutOnRoof();
    }
}
