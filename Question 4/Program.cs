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

            
            do
            {
                int eggRowLocation = random.Next(0, 9);
                int eggColumnLocation = random.Next(0, 9);
                //eggFound = false;
                //cheat for testing
                //Console.WriteLine($"{eggColumnLocation}  {eggRowLocation}");

                Console.Clear();
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

                    switch (column == eggRowLocation && row == eggColumnLocation)
                    {
                        case true:
                            eggFound = true;
                            break;
                        case false:
                            switch (column == eggRowLocation)
                            {
                                case true:
                                    switch (row > eggColumnLocation)
                                    {
                                        case true:
                                            Console.WriteLine("Egg is more to the North");
                                            continue;
                                        case false:
                                            Console.WriteLine("Egg is more to the South");
                                            continue;
                                    }
                                    continue;
                                case false:
                                    switch (column > eggRowLocation)
                                    {
                                        case true:
                                            Console.WriteLine("Egg is more to the West");
                                            switch (row > eggColumnLocation)
                                            {
                                                case true:
                                                    Console.WriteLine("Egg is more to the North");
                                                    continue;
                                                case false:
                                                    Console.WriteLine("Egg is more to the South");
                                                    continue;
                                            }
                                            continue;
                                        case false:
                                            Console.WriteLine("Egg is more to the East");
                                            switch (row > eggColumnLocation)
                                            {
                                                case true:
                                                    Console.WriteLine("Egg is more to the North");
                                                    continue;
                                                case false:
                                                    Console.WriteLine("Egg is more to the South");
                                                    continue;
                                            }
                                            continue;
                                    }
                                    continue;
                            }
                            break;
                        default:
                            break;
                    }

                    IfEggFound(eggFound);
                    //victory line prints line when you find the egg
                    //

                } while (eggFound == false);

                Console.WriteLine("Press <enter> to play again");
                Console.WriteLine("Press e to stop playing");

                playAgain = PlayAnotherRound();

            } while (playAgain == true);
        }

        static bool PlayAnotherRound()
        {
            bool playAgain = false;
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
            return playAgain;
        }

        static void IfEggFound(bool eggFound)
        {
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
        }
    }
}
