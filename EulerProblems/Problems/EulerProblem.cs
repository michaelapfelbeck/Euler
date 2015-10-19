using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public abstract class EulerProblem
    {
        protected long result = -1;
        protected string stringResult = "Eh, I dunno.";
        protected string problemText = "What's the answer this time?";

        public string ProblemText { get { return problemText; } }
        protected abstract void SetProblemText();

        public EulerProblem()
        {
            SetProblemText();
        }

        abstract public void Run();

        public long NumberResult { get { return result; } }

        public string StringResult { get { return stringResult; } }
    }
}
