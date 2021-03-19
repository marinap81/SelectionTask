using System;

namespace Exercise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your gender: ");
            string gender = Console.ReadLine();


            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            
            int ageNum = int.Parse(age);

            if (ageNum >=17)
            {
                //Console.WriteLine(  "Legally adult age");
                Console.WriteLine(gender + " Legally adult age");
            }
            else
            {
                Console.WriteLine(gender + " Legally not adult age");
            }
            
        }
    }
}
