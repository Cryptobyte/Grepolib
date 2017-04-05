namespace Grepolib.Objects
{
    public class Town
    {
        public int Id { get; set; }
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public int IslandX { get; set; }
        public int IslandY { get; set; }
        public int NumberOnIsland { get; set; }
        public int Points { get; set; }

        public Town(int id, int playerID, string name, int islandX, int islandY, int numberOnIsland, int points)
        {
            Id = id;
            PlayerID = playerID;
            Name = name;
            IslandX = islandX;
            IslandY = islandY;
            NumberOnIsland = numberOnIsland;
            Points = points;
        }
    }
}
