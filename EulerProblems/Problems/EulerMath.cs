using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class EulerMath
    {
        public static Dictionary<int, int> PrimeFactors(long test)
        {
            List<long> primes = SieveOfEratosthenesCached(test);
            Dictionary<int, int> factors = new Dictionary<int, int>();
            long maxTest = (long)Math.Sqrt(test);

            long result = test;
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

                if (0 == result || prime>maxTest)
                { 
                    break;
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



        private static long maxSieve = 128000000;
        private static List<long> _primes = null;
        public static List<long> SieveOfEratosthenesCached(long max)
        {
            if (max <= maxSieve && null != _primes)
            {
                return _primes;
            }
            else
            {
                //maxSieve = Math.Max(maxSieve * 2, max);
                maxSieve = Math.Max(maxSieve, max);
                //Console.WriteLine("creating new sieve");
            }

            if (null != _primes)
            {
                _primes.Clear();
            }
            _primes = new List<long>((int)maxSieve);
            bool[] isPrime = new bool[maxSieve + 1];
            for (int i = 0; i <= maxSieve; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < Math.Sqrt(maxSieve); i++)
            {
                if (isPrime[i])
                {
                    for (int j = 2; i * j <= maxSieve; j++)
                    {
                        isPrime[i * j] = false;
                    }
                }
            }

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    _primes.Add(i);
                }
            }

            return _primes;
        }

        public static List<long> TriangularNumbers(int count)
        {
            List<long> result = new List<long>(count);

            result.Add(1);
            for (int i = 1; i < count; i++)
            {
                //result[i] = result[i - 1] + (i + 1);
                result.Add(result.Last() + (i + 1));
            }

            return result;
        }
    }
}
