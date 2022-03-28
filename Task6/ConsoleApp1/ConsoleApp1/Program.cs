using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("book", 2.5, "book", 20);           
            Book book2 = new Book("book", 2.5, "book", 20);       
            Console.WriteLine(book.ToString());
            book.sell();
            book.Showinfo();
            Console.WriteLine("\n----------------\n");
            Console.WriteLine(book2.ToString());
            book2.sell();
            book2.Showinfo();
            Library library = new Library();
            
        }
    }
}
