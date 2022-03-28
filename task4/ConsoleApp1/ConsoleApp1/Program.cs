using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "ss bir methods";
            word(word1);
            
        }
        public static bool word(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 2 && name[i] > 64 && name[i] <= 90)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("duzgun daxil edin");
                }

            }
            return false;
        }
    }
}
