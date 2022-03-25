using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string groupno;
            do
            {
                Console.WriteLine("Enter your Group");
                groupno = Console.ReadLine();
            } while (Student.CheckGroupNo(groupno));

            do
            {
                Console.WriteLine("Enter your Fullname");
                fullname = Console.ReadLine();
            } while (Student.CheckFullname(fullname));

            Console.WriteLine("Enter your Age");
            byte age = byte.Parse(Console.ReadLine());


            Student student = new Student(groupno, age, fullname);
            
        }
       
    }
}
