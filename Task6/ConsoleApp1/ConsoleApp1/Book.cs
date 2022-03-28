using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book:Product
    {
        public string Authorname;
        public int Pagecount;
        

        public Book(string name, double price,string authorname,int pagecount):base(name,price)
        {
            
            Authorname = authorname;
            Pagecount = pagecount;
        }
        public override string ToString()
        {
            return $"Name:{Name}\nPrice:{Price}\nId{Id}\nTotallcome:{TOTALLNCOME}";
        }

        public override void sell()
        {
            Count--;
            
            
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Authorname:{Authorname}\nPagecount:{Pagecount}");
        }
    }
}
