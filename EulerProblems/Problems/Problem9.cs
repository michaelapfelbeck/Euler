using System;

namespace Problems
{
    public class Problem9 : EulerProblem
    {
        private const string format = "The product of {0}x{1}x{2} is {3}.";
        private int tripletSum = 1000;

        protected override void SetProblemText()
        {
            problemText =
                "Problem 9:\nA Pythagorean triplet is a set of three natural numbers, a < b < c, for which:\n\na^2 + b^2 = c^2\nFor example, 3^2 + 4^2 = 9 + 16 = 25 = 52.\n\nThere exists exactly one Pythagorean triplet for which a + b + c = 1000.";
        }

        public override void Run()
        {
            //a = any odd int
            //b = (a^2 -1)/2
            //c = b + 1
            int a = -1;
            int b = -1;
            int c = -1;

            bool found = false;
            for (a = 1; a < tripletSum/2; a++)
            {
                for (b = 1; b < tripletSum/2; b++)
                {
                    c = tripletSum - (a + b);
                    if (a*a + b*b == c*c)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            if (found)
            {
                result = a*b*c;
                stringResult = String.Format(format, a, b, c, result);
            }
            else
            {
                stringResult = String.Format("Could not find a pythagorean triplet where a+b+c = {0}", tripletSum);
            }
        }
    }
}
