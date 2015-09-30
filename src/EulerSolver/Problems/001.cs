using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver.Problems
{
    class _001 : EulerProblem
    {
        public override void Execute()
        {
            var sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Result = sum;
        }
    }
}
