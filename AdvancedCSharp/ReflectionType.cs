using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public static class ReflectionType
    {
        public static void Run()
        {
            Type t = typeof(int);
            Type t2 = "hello".GetType();
            Console.WriteLine(t2.FullName);
        }
    }
}
