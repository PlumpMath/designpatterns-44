namespace Builder
{
    public class SiteManager
    {
        private readonly HouseBuilder _builder;
        public SiteManager(HouseBuilder builder)
        {
            _builder = builder;
        }

        public void BuildHouse()
        {
            _builder.SetSize();
            _builder.LayFoundation();
            _builder.SetupFrame();
            _builder.ConstructOutsideWalls();
            _builder.ConstructInsideWalls();
            _builder.PutOnRoof();
        }

        public House GetHouse() => _builder.GetHouse();
    }
}
