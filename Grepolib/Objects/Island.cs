namespace Grepolib.Objects
{
    public class Island
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int IslandType { get; set; }
        public int AvailableTowns { get; set; }
        public Resource Plus { get; set; }
        public Resource Minus { get; set; }

        public Island(int id, int x, int y, int islandType, int availableTowns, Resource plus, Resource minus)
        {
            Id = id;
            X = x;
            Y = y;
            IslandType = islandType;
            AvailableTowns = availableTowns;
            Plus = plus;
            Minus = minus;
        }
    }
}
