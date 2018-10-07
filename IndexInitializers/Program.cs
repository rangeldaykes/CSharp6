using System;
using System.Collections.Generic;

namespace IndexInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IndexInitializers");

            var msgResult = new Dictionary<int, string>();
            msgResult[1] = "database error";
            msgResult[2] = "cache error";

            var msgResultNew = new Dictionary<int, string>
            {
                [1] = "database error",
                [2] = "cache error"
            };

            Console.ReadLine();
        }
    }
}
