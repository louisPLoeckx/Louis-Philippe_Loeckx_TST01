﻿using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = new string('*', 25);
            string passwordLettersString = "abcdefghijklnmopqrstuvwxyzABCDEFGHIJKLNMOPQRSTUVWXYZ!@#$%&_-+.,/0123456789";
            char[] passwordLettersArray = new char[passwordLettersString.Length];
            string password = "";
            int passwordLength = 5;
            Random random = new Random();
            string generatePassword = "false";

            //adds all values from string into a array
            for (int i = 0; i < passwordLettersString.Length; i++)
            {
                passwordLettersArray[i] = passwordLettersString[i];
            }

            do
            {
                for (int i = 0; i < passwordLength; i++)
                {
                    int randomIndex = random.Next(0, passwordLettersString.Length);
                    password += passwordLettersArray[randomIndex];
                }

                Console.WriteLine($"This is your new autogenerated password: {password}");
                
                Console.Write("Do you wish to generate another password?(y/n): ");
                generatePassword = Console.ReadLine();
                Console.WriteLine(line);

            } while (generatePassword.ToLower() == "y" || generatePassword.ToLower() == "yes");

            

        }
    }
}
