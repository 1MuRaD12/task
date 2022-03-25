using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student
    {
        public static string Fullname;
        public static string Groupno;
        //private string _groupno;
        public byte Age;

        public Student(string groupeno, byte age, string fullname)
        {
            Fullname = fullname;
            Groupno = groupeno;
            Age = age;
        }

       

        //public virtual string ToString()
        //{
        //    return $"Group:{_groupno}\nAge:{Age}\nFullname:{Fullname}";
        //}
        //public string Groupno
        //{
        //    get
        //    {
        //        return _groupno;
        //    }
        //    set
        //    {
        //        if (value.Length == 4 && value.Contains("P"))
        //        {
        //            _groupno = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Group duzgun daxil edin");
        //        }
        //    }
        //}


        public static string CheckGroupNo()
        {
            for (int i = 0; i < Groupno.Length; i++)
            {
                if (Groupno.Length==4 && Groupno.Contains("P"))
                {
                    Console.WriteLine(Groupno);
                }
                else
                {
                    Console.WriteLine("Group duzgun daxil edin");
                }
            }
            return Groupno;
        }
        public static string CheckFullname(string fullname)
        {
            return $"name:{Fullname}\nSurname:{Fullname}";
        }
    }
}
