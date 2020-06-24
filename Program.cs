using System;
using System.IO;
using System.Threading.Tasks;

namespace зачет_
{
    class Program
    {
        static async Task Main(string[] args)
        {
             Console.WriteLine("Введите название документа");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
               
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(await sr.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

