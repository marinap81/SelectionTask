using System;

namespace Exercise1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            
            int ageNum = int.Parse(age);

            if (ageNum >=17)
            {
                Console.WriteLine("Legally adult age");
            }
            else
            {
                Console.WriteLine("Legally not adult age");
            }
        }
    }
}
