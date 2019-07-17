using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Math
    {
        public double SquareRoot(double x)
        {
            return System.Math.Sqrt(x);
        }

        private double QubeRoot(double x)
        {
            return System.Math.Pow(x, (1.0 / 3.0)); ;
        }
    }
}
