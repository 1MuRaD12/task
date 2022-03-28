using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =  { 1, 2, 3, 4, 5, 6 };

           Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = 7;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }          
        }

    }
}
