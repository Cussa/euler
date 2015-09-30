using EulerSolver.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            execute();
        }

        static void execute()
        {
            Console.WriteLine("Inform the problem number to be resolved or type 'exit' to close");
            var problemNumber = Console.ReadLine();
            if (problemNumber == "exit")
                return;

            var problem = MagicActivator.MagicallyCreateInstance("_" + problemNumber);
            if (problem != null)
            {
                var result = problem.Execute();
                Console.WriteLine("Problem: " + problemNumber);
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Time: " + DateTime.Now.Subtract(problem.Start));
            }
            else
                Console.WriteLine("Problem not found");

            execute();
        }
    }
}
