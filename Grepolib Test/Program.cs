using Grepolib.Objects;
using System;
using System.Collections.Generic;

namespace Grepolib_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fetching Player List..");
            List<Player> players = new World(96, Region.EN).Players;
            Console.Write(" Done! [{0}]\n", players.Count);

            Console.WriteLine("Fetching Alliance List..");
            List<Alliance> alliances = new World(96, Region.EN).Alliances;
            Console.Write(" Done! [{0}]\n", alliances.Count);

            Console.WriteLine("Fetching Town List..");
            List<Town> towns = new World(96, Region.EN).Towns;
            Console.Write(" Done! [{0}]\n", towns.Count);

            Console.WriteLine("Fetching Island List..");
            List<Island> islands = new World(96, Region.EN).Islands;
            Console.Write(" Done! [{0}]\n", islands.Count);
            
            Console.ReadLine();
        }
    }
}