using System;
using System.Collections.Generic;

namespace NullConditionalOperator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("NullConditionalOperator");

            List<People> dates = new List<People>();            

            foreach (var d in dates)
            {
                // before
                if (d != null)
                    Console.WriteLine(d.ToString());

                // with null conditional operator
                Console.WriteLine(d?.ToString());
            }

            var p = new People(1, "Jhon");
            p.alterNameEvent += AlterName;
            p.SetName("Maria");

            Console.ReadLine();
        }

        private static void AlterName(object sender, EventArgs e)
        {
            var name = ((PeopleNameArgs)e).NewName;
            Console.WriteLine(name);
        }
    }

    class People
    {
        public event EventHandler alterNameEvent;

        public int Id { get; }
        public string Name { get; }

        public People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void SetName(string newName)
        {
            OnNameAltered(newName);
        }

        private void OnNameAltered(string newName)
        {
            // before
            if (alterNameEvent != null)
                alterNameEvent.Invoke(this, new PeopleNameArgs { NewName = newName });

            // good to use with invoke events
            alterNameEvent?.Invoke(this, new PeopleNameArgs { NewName = newName });
        }
    }

    public class PeopleNameArgs : EventArgs
    {
        public string NewName { get; set; }
    }
}
