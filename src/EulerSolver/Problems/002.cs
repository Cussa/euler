using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver.Problems
{
    class _002 : EulerProblem
    {
        public override void Execute()
        {
            var f1 = 1;
            var f2 = 2;
            var f3 = f2 + f1; ;
            var r = f2;
            while (f3 < 4000000)
            {
                if (f3 % 2 == 0)
                {
                    r += f3;
                }

                f1 = f2;
                f2 = f3;
                f3 = f2 + f1;
            }

            Result = r;
        }
    }
}
