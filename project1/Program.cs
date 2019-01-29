using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        public static void Main(string[] args)
        { 



            string[,] NameArray = new string[8, 5]
            {
                {
                    "Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"
                },
                {
                    "Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"
                },
                {
                    "D.K. Metcalf","A.J. Brown","N'Keal Harry","Marquise Brown","Kelvin Harmon"
                },
                {
                    "Nick Bosa","","","",""
                },
                {
                    "Greedy Williams","","","",""
                },
                {
                    "Noah Fant","Irv Smith","T.J. Hockenson","Kaden Smith","Josh Oliver"
                },
                {
                    "Josh Allen","Devin White","Montez Sweat","Mack Wilson","Devin Bush"
                },
                {
                    "Jonah Williams","Greg Little","Cody Ford","Jawaan Taylor","Yodny Cajuste"
                }
            };

            Console.WriteLine(NameArray[0, 0]);
        

            //How do you feed data into this array?

            Player[,] PlayerArray = new Player[8, 5];
            for(int x = 0; x < 8; x++)
            {
                for(int y = 0; y < 5; y++)
                {
                   PlayerArray[x, y] = new Player();
                   
                   
                    Console.WriteLine("Made a new player");
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                    
                    
                    
                }
                
            }

            Player DwayneHaskins = new Player();
            DwayneHaskins.PlayerName = "Dwayne Haskins";
            Console.WriteLine(DwayneHaskins.PlayerName);

            
            double PriceAccum = 0;
            const double PriceLimit = 95000000;
            const double AffordablePrice = 65000000;

            //Should this be a list of strings or ints
            List<string> selections = new List<string>();
            ConsoleKey start;
            ConsoleKey exit = ConsoleKey.N;

        
            Console.WriteLine("Welcome to the NFL Draft.  Would you like to begin? (Y/N)");
            start = Console.ReadKey().Key;
            while(start != exit)
            {
                
                start = Console.ReadKey().Key;
                
                
            }


        }
    }
}
 