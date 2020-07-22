using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kommand.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Coomand:");
                var s = Console.ReadLine();
                Console.WriteLine(s);
            }

        }
    }
}
