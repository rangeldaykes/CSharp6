using System;
using System.Collections.Generic;

namespace AutoPropertyInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AutoPropertyInitializers");

            var p = new People("Kevin")
            {
                Id = 1
            };

            p.SetSkil("Programer");

            Console.ReadLine();
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; } = "People"; // <-- can initialize read only properties
        public List<string> Skils { get; private set; } = new List<string>(); // <-- auto initializer, do not need in constructor

        public People(string newName)
        {
            // here Name equal "People"
            Name = newName;
        }

        public void SetSkil(string skil)
        {
            Skils.Add(skil);
        }
    }
}
