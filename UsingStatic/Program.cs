using System;
using static System.Math;

namespace UsingStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UsingStatic");

            double price = 3.67;
            double percentDiscount = 11.0;

            // with the "using static" you do not need write the class name 
            double discontValue = Round(price * percentDiscount / 100, 2);;

            Console.ReadLine();
        }
    }
}
