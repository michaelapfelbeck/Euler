using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem4:EulerProblem
    {
        private static string format = "The largest palindrome that is the product of two 3 digit numbers is {0}.";
        protected override void SetProblemText()
        {
            problemText="Problem 4:\nA palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\nFind the largest palindrome made from the product of two 3-digit numbers.";
        }

        public override void Run()
        {
            int largest = -1;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int product = i * j;
                    if (product > largest && IsPalindrome(product))
                    {
                        //Console.WriteLine("{0} X {1} = {2}", i, j, product);
                        largest = product;
                    }
                }
            }

            result = largest;
            stringResult = String.Format(format, result);
        }

        private bool IsPalindrome(int test)
        {
            int reversed = 0;
            int num = test;
            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num = num / 10;
            }
            return (test==reversed);
        }
    }
}
