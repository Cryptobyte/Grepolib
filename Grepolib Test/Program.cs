using Grepolib.Objects;
using System;
using System.Collections.Generic;

namespace Grepolib_Test
{
    class Program
    {
        static void updateStatus(World world, string status = null)
        {
            if (status == null)
            {
                Console.Title = "Grepolib | " + world.Region.ToString() + world.WorldID.ToString();
                return;
            }

            Console.Title = "Grepolib | " + world.Region.ToString() + world.WorldID.ToString() + " | " + status;
        }

        static void Main(string[] args)
        {
            Console.Title = "Grepolib";

            // Test Value = EN
            Console.Write("Enter Region: ");
            Region region = (Region)Enum.Parse(typeof(Region), Console.ReadLine(), true);

            // Test Value = 96
            Console.Write("Enter World Number: ");
            int wid = int.TryParse(Console.ReadLine(), out wid) ? wid : 0;

            Console.Clear();

            World world = new World(wid, region);

            updateStatus(world, "Fetching Players..");
            Console.Write("Fetching Player List..");
            List<Player> players = world.Players;
            Console.Write(" Done! [{0}]\n", players.Count);

            updateStatus(world, "Fetching Alliances..");
            Console.Write("Fetching Alliance List..");
            List<Alliance> alliances = world.Alliances;
            Console.Write(" Done! [{0}]\n", alliances.Count);

            updateStatus(world, "Fetching Towns..");
            Console.Write("Fetching Town List..");
            List<Town> towns = world.Towns;
            Console.Write(" Done! [{0}]\n", towns.Count);

            updateStatus(world, "Fetching Islands..");
            Console.Write("Fetching Island List..");
            List<Island> islands = world.Islands;
            Console.Write(" Done! [{0}]\n", islands.Count);

            Console.Clear();
            updateStatus(world, "Ready");
            Console.ReadLine();
        }
    }
}