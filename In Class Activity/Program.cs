using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");

            try
            {
                string input = Console.ReadLine();

                Console.WriteLine(input);
                Console.ReadKey(true);

            }
            catch
            {
                Console.WriteLine("There was an error");
                Console.ReadKey(true);
            }
        }
    }
}
