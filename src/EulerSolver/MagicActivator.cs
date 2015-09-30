using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EulerSolver
{
    static class MagicActivator
    {
        public static EulerProblem MagicallyCreateInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(t => t.Name == className);
            if (type == null)
                return null;

            return (EulerProblem)Activator.CreateInstance(type);
        }
    }
}
