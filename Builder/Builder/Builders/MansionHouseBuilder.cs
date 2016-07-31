namespace Builder.Builders
{
    public class MansionHouseBuilder : HouseBuilder
    {
        public MansionHouseBuilder() : base("Mansion")
        {
        }

        public override void ConstructInsideWalls()
        {
            house.InsideWall = InsideWall.Plaster;
        }

        public override void ConstructOutsideWalls()
        {
            house.OutsideWall = OutsideWall.Brick;
        }

        public override void LayFoundation()
        {
            house.Foundation = Foundation.Concreate;
        }

        public override void PutOnRoof()
        {
            house.Roof = Roof.Tiles;
        }

        public override void SetSize()
        {
            house.Size = Size.VeryLarge;
        }

        public override void SetupFrame()
        {
            house.Frame = Frame.Steel;
        }
    }
}
