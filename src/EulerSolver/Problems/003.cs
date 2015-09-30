using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver.Problems
{
    class _003 : EulerProblem
    {
        private List<long> primes = new List<long>();
        private List<long> primesResult = new List<long>();

        public override void Execute()
        {
            TestPrime(9);
            primes.Add(2);
            long numberToTest = 600851475143;
            for (long i = 3; i <= numberToTest; i += 2)
            {
                var p = TestPrime(i);
                if (p > 0 && numberToTest % p == 0)
                    primesResult.Add(p);
            }
        }

        private long TestPrime(long n)
        {
            var man = Math.Pow(3, n) % n;
            var mn = 3 % n;
            if (man == mn)
            {
                primes.Add(n);
                return n;
            }

            return 0;
        }
    }
}
