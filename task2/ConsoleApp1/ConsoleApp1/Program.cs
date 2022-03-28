using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(word(name));
           
        }
        public static bool word(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] > 65 && name[i] <= 90)
                {
                    return true;
                }
                else if (name[i] > 47 && name[i] <= 57)
                {
                    return true;
                }
                else if (name[i] > 96 && name[i] <= 122)
                {
                    return true;
                }
                                             
            }
            return false;
        }
    }
}
