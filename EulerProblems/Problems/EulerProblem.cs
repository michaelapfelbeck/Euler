using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public abstract class EulerProblem
    {
        protected int result = -1;
        protected string stringResult = "";
        protected string problemText = "";

        public string ProblemText { get { return problemText; } }
        protected abstract void SetProblemText();

        public EulerProblem()
        {
            SetProblemText();
        }

        abstract public void Run();

        public int NumberResult { get { return result; } }

        public string StringResult { get { return stringResult; } }
    }
}
