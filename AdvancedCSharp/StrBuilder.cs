using System;
using System.Collections.Generic;
using System.Text;

namespace Builders
{
    public static class StrBuilder
    {
        public static void Build()
        {
            var hello = "Hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);
        }
    }
}
