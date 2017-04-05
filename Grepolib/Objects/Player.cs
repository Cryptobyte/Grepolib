namespace Grepolib.Objects
{
    public class Player
    {
        public int Id { get; }
        public string Name { get; }
        public int AllianceID { get; }
        public int Points { get; }
        public int Rank { get; }
        public int Towns { get; }

        public Player(int id, string name, int allianceID, int points, int rank, int towns)
        {
            Id = id;
            Name = name;
            AllianceID = allianceID;
            Points = points;
            Rank = rank;
            Towns = towns;
        }
    }
}
