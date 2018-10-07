using System;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExpressionBodiedMembers");

            var p = new People(1, "Kevin");
            p.WriteNormal();
            p.WriteExpressionBodiedMembers();

            Console.ReadLine();
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; }

        public string FullName => $"{Id} - {Name}"; // ExpressionBodiedMembers to properties 

        public People(int id, string newName)
        {
            Id = id;
            Name = newName;
        }

        public string WriteNormal() // <-- normal
        {
            return " Id = " + Id + " - Name = " + Name;
        }
       
        public string WriteExpressionBodiedMembers() => " Id = " + Id + " - Name = " + Name; // <-- ExpressionBodiedMembers
    }
}
