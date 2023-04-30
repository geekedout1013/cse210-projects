using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What is your grade?");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number < 90)
        {
            if (number < 90 && number > 79)

            {
                Console.WriteLine("You have a B in this clas.");
            }
            else if (number < 80 && number > 69)
            {
                Console.WriteLine("You have a C in this class.");
            }
            else if (number < 70 && number > 59)
            {
                Console.WriteLine("You have a D in this class.");
            }
            else
            {
                Console.WriteLine("You have an F in this class.");

            }
        }
        else
        {
            Console.WriteLine("You have an A in this class.");
        }
    }


    
    
        
}
