using System;
using System.Collections.Generic;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringInterpolation");

            var p = new People { Id = 1, Name = "Jhon" };
            Console.WriteLine(p.GetIdNamePrint());
            Console.WriteLine(p.GetIdNamePrintInterpolation());
            Console.WriteLine(p.GetIdNamePrintInterpolationBodiedMenbers());

            // use with @ - before @
            Console.WriteLine($@" select * 
                                    from people
                                   where id > 10000 ");

            Console.ReadLine();
        }
    }

    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string GetIdNamePrint()
        {
            return string.Format("{0} - {1}", Id, Name);
        }

        public string GetIdNamePrintInterpolation()
        {
            return $"{Id} - {Name}";
        }

        public string GetIdNamePrintInterpolationBodiedMenbers()  =>  $"{Id} - {Name}";        
    }
}
