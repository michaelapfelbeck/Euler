using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem5 : EulerProblem
    {
        private static string format = "The smallest number evenly divisable by all numbers from {0} to {1} is {2}.";
        private static int start = 1;
        private static int end = 20;

        protected override void SetProblemText()
        {
            problemText = "Problem 5:\n2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\nWhat is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
        }

        public override void Run()
        {
            result = 7;
            stringResult = String.Format(format, start, end, result);

            Dictionary<int, int> allFactors = new Dictionary<int,int>();

            for (int i = start; i <= end; i++)
            {
                Dictionary<int, int> currFactors = Primes.PrimeFactors(i);
                allFactors = CombineFactors(allFactors, currFactors);
            }

            result = 1;
            foreach (int key in allFactors.Keys)
            {
                result *= (int)Math.Pow(key, allFactors[key]);
            }
            stringResult = String.Format(format,start,end, result);
        }

        private Dictionary<int, int> CombineFactors(Dictionary<int, int> factorsA, Dictionary<int, int> factorsB)
        {
            Dictionary<int, int> combined = new Dictionary<int, int>(factorsA);

            foreach (int key in factorsB.Keys)
            {
                if (!factorsA.ContainsKey(key))
                {
                    combined.Add(key, factorsB[key]);
                }
                else
                {
                    combined[key] = Math.Max(factorsA[key], factorsB[key]);
                }
            }

            return combined;
        }
    }
}
