using System;

namespace NameofExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NameofExpressions");

            Console.WriteLine(nameof(People));

            var p = new People();
            p.Id = 1;
            p.Name = "Jhon";

            Console.WriteLine(nameof(p.Name));

            Console.ReadLine();
        }
    }

    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
