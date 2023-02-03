using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how old do people usually live:");
            int age = Convert.ToInt32(Console.ReadLine());
            bool ageGuessed = age == 69;
            do
            {
                switch (age)
                {
                    case 55:
                        Console.WriteLine("55 is their beyond their mid life, Try Again: ");
                        Console.WriteLine("Guess how old do people usually live:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 60:
                        Console.WriteLine("Your almost there, Try Again: ");
                        Console.WriteLine("Guess how old do people usually live:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You're too early for that, Try Again: ");
                        Console.WriteLine("Guess how old do people usually live:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Why are you too harsh for the kids, Try Again: ");
                        Console.WriteLine("Guess how old do people usually live:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;

                    //True Statement
                    case 69:
                        Console.WriteLine("Congratulations! You guessed the correct number");
                        ageGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Wrong! Try Again");
                        Console.WriteLine("Guess how old do people usually live:");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!ageGuessed);

            Console.ReadLine();
        }
    }
}
