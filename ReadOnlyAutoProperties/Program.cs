using System;

namespace ReadOnlyAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadOnlyAutoProperties");

            var p = new People("Kevin")
            {
                Id = 1
            };

            p.Name = "Linda"; // <-- compile error, read only propertie

            Console.ReadLine();
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; }

        public People(string name)
        {
            Name = name; // <-- only set on constructor
        }

        public void SetName(string newName)
        {
            Name = newName;  // <-- compile error, only set on constructor
        }

    }
}
