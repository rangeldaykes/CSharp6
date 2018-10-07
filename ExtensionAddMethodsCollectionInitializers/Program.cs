using System;
using System.Collections.Generic;

namespace ExtensionAddMethodsCollectionInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExtensionAddMethodsCollectionInitializers");

            // old
            List<Eletronic> el = new List<Eletronic>()
            {
                new Eletronic(1, "radio"),
                new Eletronic(2, "tv")
            };

            // new - works because add method was defined to List of Eletronic
            List<Eletronic> el2 = new List<Eletronic>()
            {
                { 1, "radio"  },
                { 2, "tv" }
            };

            Console.ReadLine();
        }
    }

    public class Eletronic
    {
        public int Id { get; }
        public string Desc { get; }

        public Eletronic(int id, string desc)
        {
            Id = id;
            Desc = desc;
        }
    }

    public static class Extensions
    {
        // namo of method must be Add
        public static void Add(this List<Eletronic> eletronics, int id, string name)
        {
            eletronics.Add(new Eletronic(id, name));
        }
    }
}
