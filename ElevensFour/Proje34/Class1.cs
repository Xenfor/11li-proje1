using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje34
{
    class Class1
    {
        public int ek(int a, int b, int c)
        {
            if (b <= a && b <= c)
            {
                return b;
            }
            else if (a <= b && a <= c)
            {
                return a;
            }
            else if (c <= a && c <= b)
            {
                return c;
            }
            return 0;
        }
        public int eb(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else if (c >= b && c >= a)
            {
                return c;
            }
            return 0;

        }
        public int orta(int a, int b, int c)
        {
            if ((a > b && a < c) || (a < b && a > c))
            {
                return a;
            }
            else if ((b > a && b < c) || (b < a && b > c))
            {
                return b;
            }
            else if ((c > b && c < a) || (c < b && c > a))
            {
                return c;
            }
            return 0;
        }
    }
}
