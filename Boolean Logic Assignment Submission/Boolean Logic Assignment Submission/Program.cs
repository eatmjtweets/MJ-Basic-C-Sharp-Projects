using System;

namespace Boolean_Logic_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Approval program for car insurance");



            //Applicant's Age
            int applicantAge = 15;
            Console.WriteLine("What is your age?");
            bool ageResult = (applicantAge >= 15);
            Console.ReadLine();



            //Bool Applicant's DUI
            Console.WriteLine("Have you ever had a DUI?");
            bool applicantWithDui = false;
            Console.ReadLine();



            //Applicant's Speeding ticket
            int applicantTicket = 3;
            Console.WriteLine("How many speeding tickets do you have?");
            bool ticketResult = (applicantTicket <= 3);
            Console.ReadLine();


            //Bool Qualified
            Console.WriteLine("Qualified?:");
            bool qualificationResult = (applicantAge >= 15 && applicantWithDui != true && applicantTicket <= 3);
            Console.WriteLine(qualificationResult);
            Console.ReadLine();
        }
    }
}
