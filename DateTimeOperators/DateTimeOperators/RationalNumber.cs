using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeOperators
{
    struct RationalNumber
    {
        int p;
        int q;

        public RationalNumber(int p, int q)
        {
            this.p = p;
            this.q = q;
        }

        public static RationalNumber operator*(RationalNumber one, RationalNumber other)
        {
            return new RationalNumber(one.p * other.p, other.q * one.q);
        }

        public override string ToString()
        {
            return p + "\\" + q;
        }
    }
}
