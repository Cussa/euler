using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver.Problems
{
    class _003 : EulerProblem
    {
        private List<int> primes = new List<int>();

        public override void Execute()
        {
            TestPrime(103);
        }

        private void TestPrime(int number)
        {
            if (number == 2 && !primes.Any(x => x == 2))
            {
                primes.Add(number);
                return;
            }

            var sqr = Math.Floor(Math.Sqrt(number));
            var modResult = 0;
            foreach (var item in primes)
            {
                modResult += number % item;
            }
            if (modResult == 0)
                primes.Add(number);
        }
    }
}
