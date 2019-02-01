using System;
using System.Collections.Generic;


namespace project1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.SetWindowSize(200, 50);
            string PlayerName;
            string PlayerPosition;
            string PlayerSchool;
            double DraftCost;
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
                    "Nick Bosa","Quinnen Williams","Ed Oliver","Jeffrey Simmons","Clelin Farrell"
                },
                {
                    "Greedy Williams","Deandre Baker","Byron Murphy","Deionte Thompson","Amani Oruwariye"
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
            string[,] PositionArray = new string[8, 5]
            {
                {
                    "Quarterback","Quarterback","Quarterback","Quarterback","Quarterback"
                },
                {
                    "Running Back","Running Back","Running Back","Running Back","Running Back"
                },
                {
                    "Wide Reciever","Wide Reciever","Wide Reciever","Wide Reciever","Wide Reciever"
                },
                {
                    "Defensive Lineman","Defensive Lineman","Defensive Lineman","Defensive Lineman","Defensive Lineman"
                },
                {
                    "Defensive Back","Defensive Back","Defensive Back","Defensive Back","Defensive Back"
                },
                {
                    "Tight End","Tight End","Tight End","Tight End","Tight End"
                },
                {
                    "Linebacker","Linebacker","Linebacker","Linebacker","Linebacker"
                },
                {
                    "Offensive Tackle","Offensive Tackle","Offensive Tackle","Offensive Tackle","Offensive Tackle"
                },

            };
            string[,] SchoolArray = new string[8, 5]
            {
                {
                    "Ohio St.","Oklahoma","Missouri","Duke","West Virginia"
                },
                {
                    "Alabama","Alabama","Iowa St.","Oklahoma St.","FAU"
                },
                {
                    "Ole Miss","Ole Miss","Arizona St.","Oklahoma","NC State"
                },
                {
                    "Ohio St.","Alabama","Houston","Miss. State","Clemson"
                },
                {
                    "LSU","Georgia","Washington","Alabama","Penn State"
                },
                {
                    "Iowa","Alabama","Iowa","Stanford","San Jose St."
                },
                {
                    "Kentucky","LSU","Miss. State","Alabama","Michigan"
                },
                {
                    "Alabama","Ole Miss","Oklahoma","Florida","West Virginia"
                },

            };
            double[,] SalaryArray = new double[8, 5]
            {
                {
                    26400100.00,20300100.00,17420300.00,13100145.00,10300000.00
                },
                {
                    24500100.00,19890200.00,18700800.00,15000000.00,11600400.00
                },
                {
                    23400000.00,27900300.00,19300230.00,13400230.00,10000000.00
                },
                {
                    26200300.00,22000000.00,16000000.00,18000000.00,13000000.00
                },
                {
                    24000000.00,22500249.00,20000100.00,16000200.00,11899999.00
                },
                {
                    27800900.00,21000800.00,17499233.00,27900200.00,14900333.00
                },
                {
                    22900300.00,19000590.00,18000222.00,12999999.00,10000100.00
                },
                {
                    23000000.00,20000000.00,19400000.00,16200700.00,15900000.00
                },

            };

           
        

            

            Player[,] PlayerArray = new Player[8, 5];

            //loop that creates player objects
            for(int x = 0; x < 8; x++)
            {
                for(int y = 0; y < 5; y++)
                {

                    PlayerName = NameArray[x, y];
                    PlayerPosition = PositionArray[x, y];
                    PlayerSchool = SchoolArray[x, y];
                    DraftCost = SalaryArray[x, y];

                    PlayerArray[x, y] = new Player(){ PlayerName = PlayerName, PlayerPosition = PlayerPosition, PlayerSchool = PlayerSchool, DraftCost = DraftCost };
                    


                    //Console.WriteLine("Made a new player");
                    //Console.Write(Convert.ToString(x)+" ,"+Convert.ToString(y));
                    //Console.WriteLine();
                    
                    //Console.WriteLine(PlayerName);
                    //Console.WriteLine(PlayerPosition);
                    //Console.WriteLine(PlayerSchool);
                    //Console.WriteLine("$"+DraftCost);
                    
                    //Console.WriteLine();

                    
                    
                    
                }
                
            }


            
            

            
            double PriceAccum = 0;
            const double PriceLimit = 95000000;
            const double AffordablePrice = 65000000;

            //Should this be a list of strings or ints
            List<string> selections = new List<string>();
            ConsoleKey start;
        
            ConsoleKey exit = ConsoleKey.N;

            
            ConsoleKey PlayerSelectionNumber;

        
            Console.WriteLine("Welcome to the NFL Draft.  Would you like to begin? (Y/N)");
            start = Console.ReadKey().Key;
            

            while(start != exit)
            {
                
                start = Console.ReadKey().Key;
                OutputTable(NameArray, PositionArray, SalaryArray, SchoolArray);
                GetRow(out int row);
                GetPlayer(out int PlayerNumber);

                
                
                
            }


        }

        static int GetRow(out int row)
        {
            Console.WriteLine("Please enter the row number you would like to draft from");
            return row = Convert.ToInt32(Console.ReadLine());
        }

        static int GetPlayer(out int PlayerNumber)
        {
            Console.WriteLine("Please enter the player number you would like to draft");
            return PlayerNumber = Convert.ToInt32(Console.ReadLine());

        }


        static void OutputTable(string [,] name, string[,] position, double [,] salary, string[,] school)
        {
            Console.WriteLine($"\t 1 \t\t\t 2 \t\t\t 3 \t\t\t 4 \t\t\t 5");
            for (var i = 0; i < name.GetLength(0); i++)
            {
                Console.Write($"{i + 1} \t");
                for (var x = 0; x < name.GetLength(1); x++)
                {
                    Console.Write("{0,-20}", name[i, x]);
                    

                }
                Console.WriteLine("\n");
            }
            
            
               


                 Console.WriteLine("");
            
        }
    }
}
 