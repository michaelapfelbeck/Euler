using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem14:EulerProblem
    {
        private static string format = "The number under one million that produces the longest Collatz sequence is {0}.";
        private static int maxCount = 1000000;

        protected override void SetProblemText()
        {
            problemText = "Problem 14:\nThe following iterative sequence is defined for the set of positive integers:\n\nn -> n/2 (n is even)\nn -> 3n + 1 (n is odd)\n\nUsing the rule above and starting with 13, we generate the following sequence:\n\n13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1\nIt can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.\n\nWhich starting number, under one million, produces the longest chain?";
        }

        public override void Run()
        {
            result = -1;
            int maxCollatz = -1;
            for (int i = 1; i < maxCount; i++)
            {
                int temp = Collatz(i);
                if (temp > maxCollatz)
                {
                    maxCollatz = temp;
                    result = i;
                }
                //Console.WriteLine("The number {0} has a Collatz sequence length {1}.", i, temp);
            }

            stringResult = String.Format(format, result);
        }

        private int Collatz(long i)
        {
            int count = 1;

            while (i != 1)
            {
                count++;
                if (1 == i % 2)
                {
                    i=3*i+1;
                }
                else
                {
                    i = i / 2;
                }
            }
            return count;
        }
    }
}
