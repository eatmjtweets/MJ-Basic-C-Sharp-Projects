using System;

namespace Branching_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //User's input on package's WEIGHT
            Console.WriteLine("Please enter the package's weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                //The program should end 
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            else
            {
                Console.WriteLine("Proceed.");
            }
            


            //User's input on package's WIDTH
            Console.WriteLine("Please enter the package's width: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            //User's input on package's HEIGHT
            Console.WriteLine("Please enter the package's height: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            //User's input on package's LENGTH
            Console.WriteLine("Please enter the package's length: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());


            //Package's total dimensions
            int packageDimensions = packageWidth + packageHeight + packageLength;

            //Shipping price
            decimal packagePrice = packageHeight * packageWidth * packageLength * packageWeight / 100;
            

            if (packageDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + packagePrice);
                Console.WriteLine("Thank You!");
            }
            





        }
    }
}
