using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem17:EulerProblem
    {
        private static string format = "The sum of all the letters in the word forms of 1 to one thousand is {0}.";
        private static int max = 3;

        protected override void SetProblemText()
        {
            problemText = "Problem 17:\nIf the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.\n\nIf all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?\n\nNOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of \"and\" when writing out numbers is in compliance with British usage.";
        }

        public override void Run()
        {
            result = 7;
            stringResult = String.Format(format, result);
        }
    }
}
