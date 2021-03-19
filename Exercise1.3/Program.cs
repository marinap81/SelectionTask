using System;

namespace Exercise1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string value1;
            string value2;

            int number1;
            int number2;

            Console.WriteLine("Please enter a number between 0 and 10:");
            value1 = Console.ReadLine();

            Console.WriteLine("Please enter another number between 0 and 10:");
            value2 = Console.ReadLine();

            number1 = int.Parse(value1);
            number2 = int.Parse(value2);

            int total = number1 + number2;
//Console.WriteLine("The total is: "+total);
            if ( total > 10 )
            {
                Console.WriteLine("Sum of numbers is greater than 10");
            }
            else 
            {
                if(total < 10)
                {
                    Console.WriteLine("Sum of numbers is less than 10");
                }
                else
                {
                    Console.WriteLine("Sum of numbers is equal to 10");
                }
            }
        }
    }
}
