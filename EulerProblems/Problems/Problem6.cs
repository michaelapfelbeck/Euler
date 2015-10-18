using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem6:EulerProblem
    {

        private static string format = "The difference between the sum of the squares of the natural numbers from {0} to {1} and the square of the sum is {2}.";
        private static int start = 1;
        private static int end = 100;

        protected override void SetProblemText()
        {
            problemText = "Problem 6:\nThe sum of the squares of the first ten natural numbers is:\n1^2 + 2^2 + ... + 10^2 = 385\nThe square of the sum of the first ten natural numbers is:\n(1 + 2 + ... + 10)^2 = 55^2 = 3025\nHence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.\nFind the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";
        }

        public override void Run()
        {
            result = 7;
            int sum = 0;
            int sumOfSquares = 0;
            int squareOfSum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
                sumOfSquares += i * i;
            }
            squareOfSum = sum * sum;
            result = squareOfSum - sumOfSquares;
            stringResult = String.Format(format, start, end, result);
        }
    }
}
