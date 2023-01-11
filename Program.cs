using System;

namespace Daily_Report_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
           
            //Your Name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.ReadLine();
            //Your Course
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            Console.ReadLine();

            //Page Number (Int to String)
            Console.WriteLine("What page number?");
            int numberPage = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            //(Boolean)
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //Your Experience
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();

            //Your Feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            //Hours of study (Int to String)
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());

            //Final Message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.ReadLine();







        }
    }
}
