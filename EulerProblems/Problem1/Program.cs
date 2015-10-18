using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem1();
            problem.Run();

            Console.WriteLine("Press a key to exit.");
            var anyInput = Console.ReadKey();
        }
    }
}
