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
            List<int> primes= SieveOfEratosthenes((long)Math.Sqrt(target));

            for (int i = primes.Count - 1; i >= 2; i--)
            {
                int testPrime = primes[i];
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

        private List<int> SieveOfEratosthenes(long max)
        {
            List<int> primes = new List<int>();
            bool[] isPrime = new bool[max+1];
            for (int i = 0; i <= max;i++ )
            {
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < Math.Sqrt(max);i++ )
            {
                if (isPrime[i])
                {
                    for (int j = 2; i*j <= max; j++)
                    {
                        isPrime[i*j] = false;
                    }
                }
            }

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
