using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Aalst", "Antwerp", "Brussels", "Dendermonde", "Gent", "Kortrijk", "Oudenaarde", "Turnhout" };
            int[] cityZipcodes = { 9300, 2000, 1000, 9200, 9000, 8500, 9700, 2300 };
            bool zipcodeExistsCheck = true;
            bool inputIsInt = true;
            bool anotherZipcode = false;
            int zipcode;
            
            do
            {
                Console.WriteLine("Please enter a belgian zipcode to get the corresponding city: ");
                string input = Console.ReadLine();
                inputIsInt = int.TryParse(input, out zipcode);
                if (inputIsInt)
                {
                    for (int i = 0; i < cities.Length; i++)
                    {
                        if (zipcode == cityZipcodes[i])
                        {
                            Console.WriteLine($"The corrosponding city for this zipcode is {cities[i]}");
                            zipcodeExistsCheck = true;
                            anotherZipcode = false;
                            break;
                        }
                        else
                        {
                            zipcodeExistsCheck = false;
                            anotherZipcode = false;
                        }
                    }
                } else if(inputIsInt == true && zipcode > 4)
                {
                    Console.WriteLine("This number is too long to be a zipcode, it should be maximum 4 numbers");
                    anotherZipcode = true;
                }
                else 
                {
                    Console.WriteLine("This is not a number please try again");
                    anotherZipcode = true;
                }

                if (zipcodeExistsCheck == false)
                {
                    Console.WriteLine("I'm sorry, this zipcode is not in our database.");
                    anotherZipcode = true;
                }

                
                if (anotherZipcode == false)
                {
                    Console.Write("Do you wish to check for another zipcode?: ");

                    string AnotherZipcodeString = Console.ReadLine();

                    if (AnotherZipcodeString.ToLower() == "y" || AnotherZipcodeString.ToLower() == "yes")
                    {
                        anotherZipcode = true;
                    }
                    else
                    {
                        anotherZipcode = false;
                    }
                }
                

            } while (anotherZipcode == true);
            
        }
    }
}
