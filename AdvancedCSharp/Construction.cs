using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public static class Construction
    {
        public static void Run()
        {
            var t = typeof(bool);
            var b = Activator.CreateInstance(t);
            var b2 = Activator.CreateInstance<bool>();

            var arrayType = Type.GetType("System.Collections.ArrayList");
            var arrayConstructor = arrayType.GetConstructor(Array.Empty<Type>());
            var array = arrayConstructor.Invoke(Array.Empty<object>());

            var strType = typeof(string);
            var strConstructor = strType.GetConstructor(new[] { typeof(char[]) });
            var str = strConstructor.Invoke(new object[]
            {
                new char[] {'t', 'e', 's', 't'}
            });

            var listType = Type.GetType("System.Collections.Generic.List`1");
            var intListType = listType.MakeGenericType(typeof(int));
            var intListTypeConstructor = intListType.GetConstructor(Array.Empty<Type>());
            var intList = intListTypeConstructor.Invoke(Array.Empty<object>());

            Console.WriteLine($"{b} {b2} {array} {str} {intList}");
        }
    }
}
