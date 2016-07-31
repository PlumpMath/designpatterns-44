namespace Builder
{
    public class House
    {
        public House(string type)
        {
            Type = type;
        }

        public Foundation Foundation { get; set; }
        public Frame Frame { get; set; }
        public OutsideWall OutsideWall { get; set; }
        public InsideWall InsideWall { get; set; }
        public Roof Roof { get; set; }
        public Size Size { get; set; }

        public string Type { get; private set; }

        public override string ToString() =>
            $"This is a {Size} {OutsideWall} {Type} house. It's laid on a foundation of {Foundation}. The inside walls are {InsideWall}. The roof is made of {Roof}.";
    }

    public enum Foundation { Concreate, Stumps }
    public enum Frame { Wood, Steel }
    public enum OutsideWall { Brick, Wood, Render }
    public enum InsideWall { Plaster, Wood, Bricks }
    public enum Roof { Tiles, Iron }
    public enum Size { Small, Large, VeryLarge }
}
