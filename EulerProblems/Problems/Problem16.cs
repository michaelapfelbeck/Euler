using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem16 : EulerProblem
    {
        private static string format = "The sum of the digits of number 2^1000? is {0}.";
        private static int exponent = 1000;

        protected override void SetProblemText()
        {
            problemText = "Problem 16:\n2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.\n\nWhat is the sum of the digits of the number 2^1000?";
        }

        public override void Run()
        {
            result = 0;
            BigInteger start = BigInteger.Parse("2");
            BigInteger foo = start;
            for (int i = 1; i < exponent; i++)
            {
                foo = foo * start;
            }
            string numberString = foo.ToString();

            for (int i = 0; i < numberString.Length; i++)
            {
                //Console.WriteLine("{0}: {1}", i, Convert.ToInt32(numberString[i]) - 48);
                result += Convert.ToInt32(numberString[i]) - 48;
            }

            stringResult = String.Format(format, result);
        }
    }
}
