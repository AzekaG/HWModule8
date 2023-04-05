using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public struct CMYK
    {
        double c, m, y, k;
        public double C { get { return c; } set { c = value; } }
        public double M { get { return m; } set { m = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double K { get { return k; } set { k = value; } }
        public CMYK(double C, double M, double Y, double K)
        {
            this.c = C;
            this.m = M;
            this.y = Y;
            this.k = K;
        }
        public bool Equals(CMYK other)
        { return (this.c == other.c) && (this.m == other.m) && (this.y == other.y) && (this.k == other.k); }
        public void Output()
        {
            Console.WriteLine("C = " + c + " , M = " + m + " , Y = " + y + " , K = " + k);
        }
    }
}
