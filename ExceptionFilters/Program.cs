using System;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ExceptionFilters");

            DateTime dt = DateTime.Now;

            try
            {
                dt.AddYears(-9999);
            }
            catch (Exception ex) when (ex.Message.Contains("un-representable"))
            {
                Console.WriteLine("Sorry datetime not suported");
            }

            Console.ReadLine();
        }
    }
}
