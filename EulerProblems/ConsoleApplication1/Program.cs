using Problems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem10();

            Console.WriteLine(problem.ProblemText+"\n");

            TimeSpan start = Process.GetCurrentProcess().TotalProcessorTime;
            problem.Run();
            TimeSpan end = Process.GetCurrentProcess().TotalProcessorTime;

            Console.WriteLine(problem.StringResult + "\n");

            Console.WriteLine("Execution time: {0} ms.\n", (end - start).TotalMilliseconds);

            Console.WriteLine("Press a key to exit.");
            var anyInput = Console.ReadKey();
        }
    }
}
