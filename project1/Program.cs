using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            Player[,] PlayerArray = new Player[5, 7];
            for(int x = 0; x < PlayerArray.Length ; x++)
            {
                for(int y = 0; y < PlayerArray.Length; y++)
                {
                    PlayerArray[x, y] = new Player();
                }
                
            }

            Player DwayneHaskins = new Player
            {
                PlayerName = "Dwayne Haskins",
                PlayerSchool = "Ohio St.",
                DraftCost = 26400100.00,
                PlayerPosition = "Quarterback"
            };

            Console.WriteLine(DwayneHaskins.DraftCost);
            Console.Read();
        }
    }
}
