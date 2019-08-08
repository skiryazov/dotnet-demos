using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAndDateFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            var value = 10000000000; // feel free to try with different values, including fractions

            var val2 = 1D / 6F; // this is how you define a constant as a sepecific numerical type
                                // also available: M for decimal, L for long

            // the oldschool
            //String print = String.Format("The value on {0} was {1}", date, value); 

            // the l33t
            String print = $"The value on {date.ToString("yyyy.MMMM.dd hh:mm:ss tt")} was {value:P3}"; 
            // Other number format specifiers: Cx, E, Fx, G, N, Px
            // All the options DateTime: yyyy/yy MMMM/MM dd/d hh/h mm ss tt
            Console.WriteLine(print);
        }
    }
}
