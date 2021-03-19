using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {


            string word1;
            string word2;
        
            Console.WriteLine("Please enter your user name: ");
            word1 = Console.ReadLine();

            if (word1 =="admin123") 
            {
                Console.WriteLine("Please enter your password: ");

                 word2 =Console.ReadLine();
                if (word2 == "passw123")
                {
                    Console.WriteLine("Login Successful");
                }

                else
                {
                    Console.WriteLine("Login Unsuccessful");
                }

            }
            else
            {
                Console.WriteLine("Login Unsuccessful");
            }
   


        }
    }
}
