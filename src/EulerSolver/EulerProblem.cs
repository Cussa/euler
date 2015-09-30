using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver
{
    abstract class EulerProblem : IEulerProblem
    {
        public DateTime Start { get; set; }
        public decimal Result { get; set; }

        public EulerProblem()
        {
            Start = DateTime.Now;
        }

        public abstract void Execute();
    }
}
