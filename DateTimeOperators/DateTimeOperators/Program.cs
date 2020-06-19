using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.UtcNow;
            DateTime yesterday = now.AddDays(-1);

            // Can you guess the datatype of the result? Point at the "var" to reveal it
            var what = now - yesterday;
            Console.WriteLine(what);

            TimeSpan oneDay = new TimeSpan(1, 0, 0, 0);
            // What about this one?
            var what2 = now - oneDay;
            Console.WriteLine(what2);

            // And this?
            var what3 = oneDay + oneDay;
            Console.WriteLine(what3);

            RationalNumber x = new RationalNumber(1, 2);
            // Go to the definition of RationalNumber to see how we implemented the custom multiplication
            Console.WriteLine( x * x);
        }
    }
}
