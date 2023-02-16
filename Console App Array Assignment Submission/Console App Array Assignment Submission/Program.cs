using System;
using System.Collections.Generic;

    class Program
    {
    static void Main(string[] args)
    {
        //Console.WriteLine("Chi always ask help to? Pick a number from 0 - 4: ");

        //string[] names = new string[5];

        //names[0] = "Lyka";
        //names[1] = "Eliza";
        //names[2] = "Kim";
        //names[3] = "MJ";
        //names[4] = "ManPreet";


        //try
        //{
        //    int userInput = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("You've picked " + names[userInput]);
        //}

        //catch (Exception x)
        //{
        //    Console.WriteLine(x.Message);
        //}



        //Console.WriteLine("Choose a number from 0 - 10: ");
        //int[] ints = new int[] { 10, 20, 40, 80, 160, 320, 640, 1280, 1360, 2720, 5420 };

        //try
        //{
        //    int userinput = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("You got " + ints[userinput] + "!");
        //}

        //catch (Exception error)
        //{
        //    Console.WriteLine(error.Message);
        //}



        // STRING LISTS

        try
        {
            Console.WriteLine("Choose a number from 0 - 3 to get a random message: ");
            List<string> stringList = new List<string>();

            stringList.Add("You can’t be late until you show up.");
            stringList.Add("See rejection as redirection.");
            stringList.Add("You were born an original don’t die a copy.");
            stringList.Add("Be the change that you wish to see in the world.");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[userInput]);
        }

        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }


    }
}

