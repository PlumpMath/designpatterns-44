namespace Builder.Builders
{
    public class BeachHouseBuilder : HouseBuilder
    {
        public BeachHouseBuilder() : base("Beach")
        {
        }

        public override void ConstructInsideWalls()
        {
            house.InsideWall = InsideWall.Plaster;
        }

        public override void ConstructOutsideWalls()
        {
            house.OutsideWall = OutsideWall.Render;
        }

        public override void LayFoundation()
        {
            house.Foundation = Foundation.Stumps;
        }

        public override void PutOnRoof()
        {
            house.Roof = Roof.Iron;
        }

        public override void SetSize()
        {
            house.Size = Size.Small;
        }

        public override void SetupFrame()
        {
            house.Frame = Frame.Wood;
        }
    }
}
