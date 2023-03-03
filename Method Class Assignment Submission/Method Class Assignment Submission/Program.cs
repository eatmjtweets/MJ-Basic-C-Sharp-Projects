using System;

namespace Method_Class_Assignment_Submission
{
    public class Program
    {
         static void Main(string[] args)
        {
            //instantiating class
            MathOps Math = new MathOps();


            Math.num1 = 5;
            Math.num2 = 10;
            Math.result = Math.num1 * Math.num2;

            Console.WriteLine("The result is " + Math.result);
        }

        
    }
}
