using Grepolib.Objects;
using Grepolib.Objects.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace Grepolib
{
    public class Data
    {
        #region Game Data

        public static List<Player> GetPlayers(World world)
        {
            List<Player> RetVal = new List<Player>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
                var stream = httpClient.GetStreamAsync(world.UriPlayers).Result;

                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split(',');

                        string name = string.Empty;

                        if (split.Length >= 1)
                            name = split[1];

                        int id = int.TryParse(split[0], out id) ? id : 0;
                        int allianceid = int.TryParse(split[2], out allianceid) ? allianceid : 0;
                        int points = int.TryParse(split[3], out points) ? points : 0;
                        int rank = int.TryParse(split[4], out rank) ? rank : 0;
                        int towns = int.TryParse(split[5], out towns) ? towns : 0;

                        RetVal.Add(new Player(id, name, allianceid, points, rank, towns));
                    }
                }
            }

            return RetVal;
        }

        public static List<Alliance> GetAlliances(World world)
        {
            List<Alliance> RetVal = new List<Alliance>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
                var stream = httpClient.GetStreamAsync(world.UriAlliances).Result;

                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split(',');

                        string name = string.Empty;

                        if (split.Length >= 1)
                            name = split[1];

                        int id = int.TryParse(split[0], out id) ? id : 0;
                        int points = int.TryParse(split[2], out points) ? points : 0;
                        int towns = int.TryParse(split[3], out towns) ? towns : 0;
                        int members = int.TryParse(split[4], out members) ? members : 0;
                        int rank = int.TryParse(split[5], out rank) ? rank : 0;

                        RetVal.Add(new Alliance(id, name, points, towns, members, rank));
                    }
                }
            }

            return RetVal;
        }

        public static List<Town> GetTowns(World world)
        {
            List<Town> RetVal = new List<Town>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
                var stream = httpClient.GetStreamAsync(world.UriTowns).Result;

                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split(',');

                        string name = string.Empty;

                        if (split.Length >= 1)
                            name = split[2];

                        int id = int.TryParse(split[0], out id) ? id : 0;
                        int playerID = int.TryParse(split[1], out playerID) ? playerID : 0;
                        int islandX = int.TryParse(split[2], out islandX) ? islandX : 0;
                        int islandY = int.TryParse(split[3], out islandY) ? islandY : 0;
                        int number = int.TryParse(split[4], out number) ? number : 0;
                        int points = int.TryParse(split[5], out points) ? points : 0;

                        RetVal.Add(new Town(id, playerID, name, islandX, islandY, number, points));
                    }
                }
            }

            return RetVal;
        }

        public static List<Island> GetIslands(World world)
        {
            List<Island> RetVal = new List<Island>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);
                var stream = httpClient.GetStreamAsync(world.UriIslands).Result;

                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split(',');

                        int id = int.TryParse(split[0], out id) ? id : 0;
                        int x = int.TryParse(split[1], out x) ? x : 0;
                        int y = int.TryParse(split[2], out y) ? y : 0;
                        int type = int.TryParse(split[3], out type) ? type : 0;
                        int availableTowns = int.TryParse(split[4], out availableTowns) ? availableTowns : 0;

                        RetVal.Add(new Island(id, x, y, type, availableTowns, ParseResource(split[5]), ParseResource(split[6])));
                    }
                }
            }

            return RetVal;
        }

        #endregion

        public static Resource ParseResource(string resourceString)
        {
            switch (resourceString.ToUpper())
            {
                case "WOOD":
                    return Resource.WOOD;

                case "IRON":
                    return Resource.IRON;

                case "STONE":
                    return Resource.STONE;

                default: return Resource.UNKNOWN;
            }
        }
    }
}
