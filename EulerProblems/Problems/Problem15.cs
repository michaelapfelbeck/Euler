using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Problem15:EulerProblem
    {
        private static string format = "The number of lattice paths through a 20x20 matrix is {0}.";
        private static int gridSize = 20;

        protected override void SetProblemText()
        {
            problemText = "Problem 15:\nStarting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.\n\nHow many such routes are there through a 20×20 grid?";
        }

        public override void Run()
        {
            long paths = 1;

            for (int i = 0; i < gridSize; i++)
            {
                paths *= (2 * gridSize) - i;
                paths /= i + 1;
            }

            result = paths;
            stringResult = String.Format(format, result);
        }
    }
}
