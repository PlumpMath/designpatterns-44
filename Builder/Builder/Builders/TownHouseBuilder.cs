namespace Builder.Builders
{
    public class TownHouseBuilder : HouseBuilder
    {
        public TownHouseBuilder() : base("Town")
        {
        }

        public override void ConstructInsideWalls()
        {
            house.InsideWall = InsideWall.Plaster;
        }

        public override void ConstructOutsideWalls()
        {
            house.OutsideWall = OutsideWall.Wood;
        }

        public override void LayFoundation()
        {
            house.Foundation = Foundation.Concreate;
        }

        public override void PutOnRoof()
        {
            house.Roof = Roof.Iron;
        }

        public override void SetSize()
        {
            house.Size = Size.Large;
        }

        public override void SetupFrame()
        {
            house.Frame = Frame.Wood;
        }
    }
}
