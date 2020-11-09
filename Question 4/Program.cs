using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] field = new string[10, 10];
            string empty = "_";
            bool eggFound = false;
            bool playAgain = false;
            Random random = new Random();

            Console.WriteLine("Find the egg");
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    field[i, y] = empty;
                    Console.Write($"{field[i, y]}\t");
                }
                Console.WriteLine();
            }
            do
            {
                int eggRowLocation = random.Next(0, 9);
                int eggColumnLocation = random.Next(0, 9);

                //cheat for testing
                //Console.WriteLine($"{eggColumnLocation}  {eggRowLocation}");

                do
                {
                    
                    //Asks row to input
                    Console.Write("Choose a Row: ");
                    int row = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Choose a Column: ");
                    int column = Convert.ToInt32(Console.ReadLine());

                    //changes the selected value to x
                    field[row, column] = "x";

                    Console.Clear();
                    Console.WriteLine("Find the egg");

                    //Writes the current game field
                    for (int i = 0; i < 10; i++)
                    {
                        for (int y = 0; y < 10; y++)
                        {
                            Console.Write($"{field[i, y]}\t");
                        }
                        Console.WriteLine();
                    }

                    if (column == eggRowLocation && row == eggColumnLocation )
                    {
                        eggFound = true;
                    }
                    else
                    {
                        if (column == eggRowLocation)
                        {
                            if (row > eggColumnLocation)
                            {
                                Console.WriteLine("Egg is more to the North");
                            }
                            else
                            {
                                Console.WriteLine("Egg is more to the South");

                            }
                            continue;
                        }
                        else if (row == eggColumnLocation)
                        {
                            if (column > eggRowLocation)
                            {
                                Console.WriteLine("Egg is more to the West");
                            }
                            else
                            {
                                Console.WriteLine("Egg is more to the East");
                            }
                            continue;
                        }
                        else if (column > eggRowLocation)
                        {
                            Console.WriteLine("Egg is more to the West");
                            if (row > eggColumnLocation)
                            {
                                Console.WriteLine("Egg is more to the North");
                            }
                            else
                            {
                                Console.WriteLine("Egg is more to the South");

                            }
                            continue;
                        } else if (column < eggRowLocation)
                        {
                            Console.WriteLine("Egg is more to the East");
                            if (row > eggColumnLocation)
                            {
                                Console.WriteLine("Egg is more to the North");
                            }
                            else
                            {
                                Console.WriteLine("Egg is more to the South");

                            }
                            continue;
                        }
                    }

                    //victory line prints line when you find the egg
                    if (eggFound == true)
                    {
                        //Console.Clear();
                        string winnerLine = "\n\n\n\n\n\t\t\t\t\t Congratulations you have found the egg \n\n\n\n\n";
                        string line = new String('*', (Console.WindowWidth));
                        Console.WriteLine(line);
                        Console.WriteLine("\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t   ***********************************************");
                        Console.WriteLine("\t\t\t\t   ***********************************************");
                        Console.WriteLine("\t\t\t\t   **  Congratulations you have found the egg!  **");
                        Console.WriteLine("\t\t\t\t   ***********************************************");
                        Console.WriteLine("\t\t\t\t   ***********************************************");
                        Console.WriteLine("\n\n\n\n\n\n");

                        Console.WriteLine(line);
                    }

                } while (eggFound == false);

                Console.WriteLine("Press <enter> to play again");
                Console.WriteLine("Press e to stop playing");

                var playAgainInput = Console.ReadKey();
                if (playAgainInput.Key == ConsoleKey.Enter)
                {
                    playAgain = true;
                }
                else if (playAgainInput.Key == (ConsoleKey.E))
                {
                    playAgain = false;
                    Console.WriteLine();
                }

            } while (playAgain == true);
        }
    }
}
