using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Library
    {
        public int Booklimit = 0;
        public  Book[] books;
        public void Addbook(Book[] books)
        {
            try
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books.Length > Booklimit)
                    {
                        throw new Exception("limiti asdiz");
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("limit asdiz");
            }
            finally
            {
                Console.WriteLine("limit asdiz");
            }
        }

        
        //public void Getbookbyid(int nullable)
        //{

        //}
    }
}
