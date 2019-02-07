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
            bool[,] PickedPlayer = new bool[8, 5];
            
           
        

            
            //Setting up array to hold player objects
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
            int PickCounter = 0;
            bool costEffective = false;

            //Empty list to be used later in select player method
            List<int> RankSelections = new List<int>();
           
        
            

            
            

        
            Console.WriteLine("Welcome to the NFL Draft.  Would you like to begin? (Y/N)");
            KeyCapture(out ConsoleKey start, PickCounter, ref RankSelections, PriceAccum, ref costEffective, AffordablePrice);
            
            //main while loop
            while(start != ConsoleKey.N)
            {
                //Output table method, passing in arrays of data
                OutputTable(NameArray, PositionArray, SalaryArray, SchoolArray);

                //method that selects the player
                Player SelectedPlayer = SelectPlayer(PlayerArray, ref RankSelections);

                //checks to make sure player has not already been selected
                if (SelectedPlayer.PickedPlayer == false)
                {
                    if (SelectedPlayer.DraftCost + PriceAccum > PriceLimit)
                    {
                        Console.WriteLine("Sorry, you don't have money in your budget for this player!");
                    }
                    else
                    {
                        
                        PriceAccum = PriceAccum + SelectedPlayer.DraftCost;
                        SelectedPlayer.PickedPlayer = true;
                        Console.Clear();
                        Console.WriteLine("You have drafted " + SelectedPlayer.PlayerName);
                        Console.WriteLine("You have {0} left in your budget", (PriceLimit - PriceAccum).ToString("c"));
                        PickCounter++;
                    }
                }

                //end of large if-else statement, if player has been selected, gives user a message.
                else
                {
                    Console.WriteLine("Sorry, you already selected that player.");
                }




                KeyCapture(out start, PickCounter, ref RankSelections, PriceAccum, ref costEffective, AffordablePrice);
                Console.Clear();
                
                
                
            }
            EndTable(PlayerArray, ref costEffective, PriceLimit, PriceAccum);
 
        }


        //Do this for column
        static int GetRow(Player [,] PlayerArray)
        {
            
            int row;
            Console.WriteLine("Please enter the row number you would like to draft from.\n ");
            for(int i = 0; i < PlayerArray.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1}) {PlayerArray[i,0].PlayerPosition}");
            }
            row = Convert.ToInt32(Console.ReadLine());
            /*try
            {
                row = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                row = -1;
            }*/
            while ((row < 0) || (row > 7))
            {
                try
                {
                    Console.WriteLine("You entered an incorrect value.  Please enter a number between 1 and 8.");
                    row = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    row = -1;
                }
            }

            return row;
        }

        static int GetColumn(ref List<int>RankSelections)
        {
            int PlayerNumber;
            Console.WriteLine("Please enter the player number you would like to draft");
            try
            {
                PlayerNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                PlayerNumber = -1;
            }
            while((PlayerNumber < 0) ||(PlayerNumber > 5))
            {
                try
                {
                    Console.WriteLine("You entered an incorrect value.  Please enter a number between 1 and 5.");
                    PlayerNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    PlayerNumber = -1;
                }
            }
            
            RankSelections.Add(PlayerNumber);
            return PlayerNumber;



        }


        static void OutputTable(string [,] name, string[,] position, double [,] salary, string[,] school)
        {
            Console.Clear();
            Console.Write("Position".PadRight(20));

            //Writes top line of table, with draft numbers
            for (var x = 0; x < name.GetLength(1); x++)
            {
                Console.Write($"{x+1}".PadRight(20));
            }
            Console.WriteLine("\n"); //Skips new line

            //large for loop that writes specific positions
            for (var i = 0; i < name.GetLength(0); i++)
            {
                var y = 0;
                Console.Write($"{position[i,y]}".PadRight(20));
                //inner for loop writes player names
                for (var x = 0; x < name.GetLength(1); x++)
                {
                    
                    Console.Write("{0,-20}", name[i, x].PadRight(20));
                        
      
                }
                Console.WriteLine();
                Console.Write("".PadRight(20));

                //second inner for loop writes player draft costs
                for(var x = 0; x <salary.GetLength(1); x++)
                {
                    Console.Write("{0,-20}", salary[i, x].ToString("c").PadRight(20));
                }

                Console.WriteLine();
                Console.Write("".PadRight(20));

                //third for loop writes the schools
                for(var x = 0; x < school.GetLength(1); x++)

                {
                    Console.Write("{0,-20}", school[i, x].PadRight(20));
                }
                Console.WriteLine();
                //when this for loop is done, starts writing next position, ex. all quarterback info first, then moves to running backs
            


                Console.WriteLine("");
                
            }
            
            
               


                 Console.WriteLine("");
            
        }

        static Player SelectPlayer(Player[,] PlayerArray,ref List<int>RankSelections)
        {
            return PlayerArray[GetRow(PlayerArray)-1, GetColumn(ref RankSelections)-1];
        }

        static void KeyCapture(out ConsoleKey start, int PickCount, ref List<int>RankSelections, double PriceAccum, ref bool costEffective, double AffordablePrice)
        {
            
            Console.WriteLine("Press any key to continue drafting or press n to escape");
            start = Console.ReadKey().Key;
            if(PickCount == 3)
            {
                //Puts list in numerical order
                RankSelections.Sort();
                RankSelections.Reverse();
                for (int x = 0; x < RankSelections.Count; x++)
                {
                    if (RankSelections[x] > 3)
                    {
                        break;
                    }
                    else
                    {
                        if(PriceAccum < AffordablePrice)
                        {
                            costEffective = true;
                        }
                    }
                }
            }
            else if(PickCount == 5)
            {
                Console.WriteLine("You are out of picks, press any key to exit.");
                Console.ReadKey();
                start = ConsoleKey.N;

            }
          
            
        }

        static void EndTable(Player[,] PlayerArray, ref bool costEffective, double PriceLimit, double PriceAccum)
        {
            Console.WriteLine("You have drafted: ");
            for (var x = 0; x < PlayerArray.GetLength(0); x++)
            {
                for (var y = 0; y < PlayerArray.GetLength(1); y++)
                {
                    if (PlayerArray[x, y].PickedPlayer == true)
                    {
                        Console.WriteLine($"{PlayerArray[x,y].PlayerName} for {PlayerArray[x,y].DraftCost.ToString("c")}");
                    }
                }
            }
            if(costEffective == true)
            {
                Console.WriteLine("You have had a cost effective draft!");
            }
            Console.WriteLine($"You have {(PriceLimit - PriceAccum).ToString("c")} left for signing bonuses.");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
        
    }
}
 