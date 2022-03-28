using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "bu bir methoddur";
            word(word1);
        }
        public static void word(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    name = name.Remove(i);
                }
                
            }
            Console.WriteLine(name);
        }
       
    }
}
