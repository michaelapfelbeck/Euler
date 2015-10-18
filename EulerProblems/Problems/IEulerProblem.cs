using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public interface IEulerProblem
    {
        string ProblemText { get; }

        void Run();

        int NumberResult { get; }

        string StringResult { get; }
    }
}
