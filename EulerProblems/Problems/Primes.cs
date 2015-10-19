using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class Primes
    {
        public static Dictionary<int, int> PrimeFactors(int test)
        {
            List<long> primes = SieveOfEratosthenes(test);
            Dictionary<int, int> factors = new Dictionary<int, int>();

            int result = test;
            foreach (int prime in primes)
            {
                int accumulator = 0;
                while (0 == result % prime)
                {
                    accumulator++;
                    result = result / prime;
                    if (!factors.ContainsKey(prime))
                    {
                        factors.Add(prime, accumulator);
                    }
                    else
                    {
                        factors[prime] = Math.Max(factors[prime], accumulator);
                    }
                }
            }

            return factors;
        }

        public static List<long> SieveOfEratosthenes(long max)
        {
            List<long> primes = new List<long>();
            bool[] isPrime = new bool[max + 1];
            for (int i = 0; i <= max; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < Math.Sqrt(max); i++)
            {
                if (isPrime[i])
                {
                    for (int j = 2; i * j <= max; j++)
                    {
                        isPrime[i * j] = false;
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
