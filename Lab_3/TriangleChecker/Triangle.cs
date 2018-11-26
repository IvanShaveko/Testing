using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleChecker
{
    public static class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a < 0  || b < 0 || c < 0)
            {
                throw new ArgumentException(nameof(a));
            }

            return a + b > c && a + c > b && b + c > a;
        }
    }
}
