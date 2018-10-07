using System;
using System.Threading.Tasks;

namespace AwaitCathFinalyblocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AwaitCathFinalyblocks");

            CreateDate();

            Console.ReadLine();
        }

        static async void CreateDate()
        {
            await Log("Init - Create Date");
            DateTime DataHora = DateTime.Now;

            try
            {
                DataHora = DataHora.AddYears(-9999);
            }
            catch (Exception ex)
            {
                await Log(ex.Message);
            }
            finally
            {
                await Log("End - Create Date");
            }
        }

        static async Task Log(string msg)
        {
            await Task.Factory.StartNew(() => Console.WriteLine($"{DateTime.Now} - {msg}"));
        }
    }
}
