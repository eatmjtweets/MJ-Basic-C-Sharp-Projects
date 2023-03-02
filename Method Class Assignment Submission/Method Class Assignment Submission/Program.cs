using System;

namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            multiply(6, 9);
        }

        static void multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("The result is " + result);
        }
    }
}
