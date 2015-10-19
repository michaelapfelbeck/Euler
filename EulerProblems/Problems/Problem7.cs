using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem7 : EulerProblem
    {
        private static string format = "Prime #{0} is {1}.";
        private static int end = 10001;

        protected override void SetProblemText()
        {
            problemText = "Problem 7:\nBy listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\nWhat is the 10,001st prime number?";
        }

        public override void Run()
        {
            result = 7;

            List<long> primes = Primes.SieveOfEratosthenes(200000);
            result = primes[end-1];
            stringResult = String.Format(format, end, result);
        }
    }
}
