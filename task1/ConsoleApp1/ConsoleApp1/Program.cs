using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isOdd());

            Console.WriteLine(isEven());
            
        }
        private static bool isOdd()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                return true;

            }
            else
            {
                return false;
            }

           
        }
        private static bool isEven()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
