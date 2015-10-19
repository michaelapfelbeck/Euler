using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Problems
{
    public class Problem10:EulerProblem
    {
        private const string format = "The answer is {0}";
        private const long largestPrime = 2000000;

        protected override void SetProblemText()
        {
            problemText = "Problem 10:\nThe sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\n\nFind the sum of all the primes below two million.";;
        }

        public override void Run()
        {
            List<long> primes = Primes.SieveOfEratosthenes(largestPrime);

            result = primes.Aggregate((sum, x) => sum + x);

            stringResult = string.Format(format, result);
        }
    }
}
