using System;
using System.Collections.Generic;

namespace polymorphism
{
    public class Employ
    {
        public string first = "FN";
        public string last = "LN";

        public virtual void printfull()
        {
            Console.WriteLine(first+"" + last);
        }
    }
    public class partTime : Employ
    {
        public override void printfull()
        {
            Console.WriteLine(first + "" + last + "- Part time");
        }
    }
    public class fullTime : Employ
    {
        public override void printfull()
        {
            Console.WriteLine(first + "" + last + "- full time");
        }
    }
    public class Temporary : Employ
    {
        public override void printfull()
        {
            Console.WriteLine(first + "" + last + "- Temporary");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ[] employ = new Employ[4];

            employ[0] = new Employ();
            employ[1] = new partTime();
            employ[2] = new fullTime();
            employ[3] = new Temporary();

            foreach(Employ e in employ)
            {
                e.printfull();
            }
        }
    }
}
