using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryManagement
{
    public static class InParameters
    {
        struct Point
        {
            public double x, y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"{x}, {y}";
            }
        }

        // this is inmutateable, definately never changed. even if change is made in model.
        static double MeasureDistance(in Point p1, in Point p2)
        {
            var dx = p1.x - p2.x;
            var dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static void Run()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(4, 5);
            Console.WriteLine(MeasureDistance(p1, p2));
        }
    }
}
