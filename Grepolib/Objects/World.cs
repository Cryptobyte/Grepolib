using Grepolib.Objects.Enum;
using System;

namespace Grepolib.Objects
{
    public class World
    {
        public int    ID      { get; }
        public Region Region  { get; }

        public string UriBase
        {
            get
            {
                return String.Format("https://{0}{1}.grepolis.com/data/", Region.ToString().ToLower(), ID);
            }
        }

        public string UriPlayers
        {
            get { return UriBase + DataType.Players; }
        }

        public string UriAlliances
        {
            get { return UriBase + DataType.Alliances; }
        }

        public string UriTowns
        {
            get { return UriBase + DataType.Towns; }
        }

        public string UriIslands
        {
            get { return UriBase + DataType.Islands; }
        }

        public World(int worldID, Region region)
        {
            ID = worldID;
            Region = region;
        }
    }
}
