using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    public interface EulerProblem
    {
        string ProblemText { get; }

        void Run();

        int NumberResult { get; }

        string StringResult { get; }
    }
}
