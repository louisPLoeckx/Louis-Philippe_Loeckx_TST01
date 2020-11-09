using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test Question 1";

            Console.Write("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            decimal discount = (userInput /100)*5;

            if (userInput > 5000)
            {
                Console.WriteLine($"Congratulations you get a 5% discount, the amount you have to pay now is {userInput - discount}.");
            }
            else
            {
                Console.WriteLine($"No discount for you, you owe {userInput}.");
            }
        }
    }
}
