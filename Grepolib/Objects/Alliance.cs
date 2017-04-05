namespace Grepolib.Objects
{
    public class Alliance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public int Towns { get; set; }
        public int Members { get; set; }
        public int Rank { get; set; }

        public Alliance(int id, string name, int points, int towns, int members, int rank)
        {
            Id = id;
            Name = name;
            Points = points;
            Towns = towns;
            Members = members;
            Rank = rank;
        }
    }
}
