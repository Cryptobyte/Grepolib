using Grepolib.Objects;
using System;

namespace Grepolib_Test
{
    class Program
    {
        static bool isRunning = true;
        static World world = null;

        static void updateStatus(World world, string status = null)
        {
            if (status == null)
            {
                Console.Title = "Grepolib | " + world.Region.ToString() + world.ID.ToString();
                return;
            }

            Console.Title = "Grepolib | " + world.Region.ToString() + world.ID.ToString() + " | " + status;
        }

        static void Main(string[] args)
        {
            Console.Title = "Grepolib";
            
            while (isRunning)
            {
                string input = Console.ReadLine().ToLower();

                if (input.Equals("exit"))
                {
                    isRunning = false;
                    continue;
                }

                if (input.Equals("clear"))
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}