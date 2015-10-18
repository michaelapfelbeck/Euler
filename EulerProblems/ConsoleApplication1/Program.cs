using Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem3();

            Console.WriteLine(problem.ProblemText+"\n");

            problem.Run();

            Console.WriteLine(problem.StringResult + "\n");

            Console.WriteLine("Press a key to exit.");
            var anyInput = Console.ReadKey();
        }
    }
}
