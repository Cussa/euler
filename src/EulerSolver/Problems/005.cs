using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver.Problems
{
    class _005 : EulerProblem
    {
        public override void Execute()
        {
            var ret = string.Empty;
            var searching = true;
            var numberTest = 20;
            var modResult = 0;

            //232792560
            while (searching)
            {
                for (int i = 1; i <= 20; i++)
                {
                    modResult += numberTest % i;
                    if (modResult > 0)
                        break;
                }

                if (modResult > 0)
                {
                    numberTest += 20;
                    modResult = 0;
                    continue;
                }

                searching = false;
            }

            Result = numberTest;
        }
    }
}
