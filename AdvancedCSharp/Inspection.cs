using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public static class Inspection
    {
        public static void Run()
        {
            Type t = typeof(Guid);

            var ctors = t.GetConstructors();

            foreach (var ctor in ctors)
            {
                Console.Write("Guid(");
                var parameters = ctor.GetParameters();
                foreach (var param in parameters) {
                    Console.Write($"{param.ParameterType.Name} {param.Name}");
                }
                Console.WriteLine(")");
            }

            var methods = t.GetMethods();
            foreach (var method in methods)
            {
                Console.Write($"{method.Name}(");
                var parameters = method.GetParameters();
                foreach (var param in parameters)
                {
                    Console.Write($"{param.ParameterType.Name} {param.Name}");
                }
                Console.WriteLine(")");
            }
        }
    }
}
