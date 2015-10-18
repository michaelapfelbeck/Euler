﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem2:EulerProblem
    {
        private int maxValue = 4000000;

        protected override void SetProblemText()
        {
            problemText = "Problem 2:\nEach new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:\n1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...\nBy considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
        }

        public override void Run()
        {
            List<int> sequence = new List<int>(){1,2};

            bool done = false;
            while (!done)
            {
                int last = sequence[sequence.Count - 1];
                int nextToLast = sequence[sequence.Count - 2];
                int sum = last + nextToLast;

                if (sum < maxValue)
                {
                    sequence.Add(sum);
                }
                else
                {
                    done = true;
                }
            }

            var filtered = sequence.Where(x => x % 2 == 0);
            result = filtered.Aggregate((sum, x) => sum + x);
            stringResult = string.Format("The sum of even Fibonacci numbers less than {0} is {1}.", maxValue, result);
        }
    }
}
