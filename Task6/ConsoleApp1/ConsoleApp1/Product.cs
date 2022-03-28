using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Product
    {
        private int _id;
        public string Name;
        public double Price;
        public static int Count = 0;
        private int _totallncome;

        public Product(string name, double price)
        {
            Count++;
            _id = Count;

            _totallncome = Count;
            Name = name;
            Price = price;

        }


        public int Id
        {
            get => _id;
        }

        public int TOTALLNCOME
        {
            get => _totallncome;

            set
            {
                for (int i = 0; i < _totallncome; i++)
                {
                    if (_totallncome < i)
                    {
                        _totallncome--;
                    }
                    else
                    {
                        _totallncome++;
                    }
                }
                _totallncome = value;
            }
        }
        public abstract void sell();
        public abstract void Showinfo();

    }
}
