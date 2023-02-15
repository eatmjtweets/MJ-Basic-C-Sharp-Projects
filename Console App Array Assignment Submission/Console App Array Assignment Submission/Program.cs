using System;
using System.Collections.Generic;

    class Program
    {
    static void Main()
    {
        Console.WriteLine("Chi would ask help again to? Choices are: \n Choose a number between 0 - 5.");

        string[] nameArray = new string[5];

        nameArray[0] = "Lyka";
        nameArray[1] = "Eliza";
        nameArray[2] = "Kim";
        nameArray[3] = "MJ";
        nameArray[4] = "ManPreet";
        nameArray[5] = "Tej";

        int numArray = Convert.ToInt32(Console.ReadLine());
        bool nameGuessed = numArray == nameArray[0];
        do
        {
            switch (name)
                {
                    // True Statement
                    case 0:
                    Console.WriteLine("Yup! sure it's always gonna be " + nameArray[0]);
                    nameGuessed = true;
                    break;

                    case 1:
                    Console.WriteLine("Nope! " + nameArray[1] + " is like 3rd to her options.");
                    break;

                    case 2:
                    Console.WriteLine("Nope! " + nameArray[2] + " is like 2rd to her options.");
                    break;

                    case 3:





                }
        }

        int userInput = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();




    }
}

