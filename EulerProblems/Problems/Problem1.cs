using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem1:EulerProblem
    {
        private static string format = "The sum of all the multiples of 3 or 5 below {0} is {1}.";
        private static int start = 0;
        private static int end = 1000;

        protected override void SetProblemText(){
            problemText = "Problem 1:\nIf we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.";
        }

        public override void Run()
        {
            //Generate a list of all integers in the start to end range
            var all = Enumerable.Range(start, end);

            //Filter the list of all integers into a list of ints that are
            //multiples of 3 and 5
            var filtered = all.Where(x => x % 3 == 0 || x % 5 == 0);

            //Reduce the list to a sum.
            result = filtered.Aggregate((sum, x) => sum + x);
            stringResult = String.Format(format, end, result);
        }
    }
}
