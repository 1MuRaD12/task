using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Bu, bir, methoddur";
            Name(word);

        }
        public static void Name(string word)
        {
            string[] Word = word.Split(',');
            foreach (var item in Word)
            {
                Console.WriteLine(item);
            }
            
            string word1 = string.Join(" ", word);
            Console.WriteLine(word1);
        }
    }
}
