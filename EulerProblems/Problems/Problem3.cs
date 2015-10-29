using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem3:EulerProblem
    {
        private long target = 600851475143;
        private static string format = "The largest prime factor of {0} is {1}.";
        protected override void SetProblemText()
        {
            problemText = "Problem 3:\nThe prime factors of 13195 are 5, 7, 13 and 29.\nWhat is the largest prime factor of the number 600851475143 ?";
        }

        public override void Run()
        {
            List<long> primes = EulerMath.SieveOfEratosthenes((long)Math.Sqrt(target));

            for (int i = primes.Count - 1; i >= 2; i--)
            {
                long testPrime = primes[i];
                if (target % testPrime == 0)
                {
                    result = testPrime;
                    stringResult = String.Format(format, target, result);
                    break;
                }
            }
                //result = primes[primes.Count - 1];
            //stringResult = String.Format(format, target, result);
        }
    }
}
