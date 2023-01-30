using System;

namespace Boolean_Logic_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Approval program for car insurance");



            //Applicant's Age
            
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());



            //Bool Applicant's DUI
            Console.WriteLine("Have you ever had a DUI?");
            bool applicantWithDui = false;
            Console.ReadLine();



            //Applicant's Speeding ticket
            
            Console.WriteLine("How many speeding tickets do you have?");
            int applicantTicket = Convert.ToInt32(Console.ReadLine());


            //Bool Qualified
            Console.WriteLine("Qualified?:");
            bool qualificationResult = (age >= 15 && applicantWithDui != true && applicantTicket <= 3);
            Console.WriteLine(qualificationResult);
            Console.ReadLine();
        }
    }
}
