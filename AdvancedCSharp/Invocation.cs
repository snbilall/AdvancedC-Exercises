using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public static class Invocation
    {
        public static void Run()
        {
            var s = "heyo    ";
            var t = typeof(string);
            var trimMethod = t.GetMethod("Trim", Array.Empty<Type>());
            var result = trimMethod.Invoke(s, Array.Empty<object>());

            Console.WriteLine(result);

            var str = "123";
            var parseMethod = typeof(int).GetMethod("TryParse", new[] { typeof(string), typeof(int).MakeByRefType() });
            var args = new object[]
            {
                str, null
            };
            var ok = parseMethod.Invoke(null, args);

            Console.WriteLine($"{ok} - {args[1]}");

            var guid1 = new Guid("6508fe94-e3fa-11ec-8fea-0242ac120002");

            var guid2 = Activator.CreateInstance(typeof(Guid), new object[]
            {
                 "6508fe94-e3fa-11ec-8fea-0242ac120002"
            });

            var activatorType = typeof(Activator);
            var creatorMethod = activatorType.GetMethod("CreateInstance", Array.Empty<Type>());
            var genericCreator = creatorMethod.MakeGenericMethod(typeof(Guid));
            var guid3 = genericCreator.Invoke(null, null);
            Console.WriteLine($"{guid1} - {guid2} - {guid3}");
        }
    }
}
