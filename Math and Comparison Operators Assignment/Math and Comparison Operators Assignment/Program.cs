using System;

namespace Math_and_Comparison_Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            //P1
            Console.WriteLine("Person 1");
            //P1's Rate
            Console.WriteLine("Hourly Rate");
            int p1hourlyRate = Convert.ToInt32(Console.ReadLine());
            //P1's Hours/Week
            Console.WriteLine("Hours per week");
            int p1hoursperWeek = Convert.ToInt32(Console.ReadLine());


            //P2
            Console.WriteLine("Person 2");
            //P2's Rate
            Console.WriteLine("Hourly Rate");
            int p2hourlyRate = Convert.ToInt32(Console.ReadLine());
            //P2's Hours/Week
            Console.WriteLine("Hours per week");
            int p2hoursperWeek = Convert.ToInt32(Console.ReadLine());

            //P1's Annual Salary
            Console.WriteLine("Annual salary of Person 1:");
            int P1annual = p1hourlyRate * p1hoursperWeek * 48;
            Console.WriteLine(P1annual);

            //P2's Annual Salary
            Console.WriteLine("Annual salary of Person 2:");
            int P2annual = p2hourlyRate * p2hoursperWeek * 48;
            Console.WriteLine(P2annual);
            Console.ReadLine();

            

            //TRUE OR FALSE STATEMENT
            
            //P1 & P2 Annual Salary Comparison (BOOLEAN)
            Console.WriteLine("Person 1 makes more money than Person 2");
            bool salaryComparison = P1annual > P2annual;
            Console.WriteLine(salaryComparison.ToString());
            Console.ReadLine();
        }
    }
}
