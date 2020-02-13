using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastVsAs
{
    class Lambda
    {
        delegate bool Test(DateTime day);
        delegate void TestVoid();

        public static void TestMethod()
        {
            var now = DateTime.UtcNow;

            Test method1 = 
                delegate (DateTime day) { return day.DayOfWeek == DayOfWeek.Friday; };
            method1.Invoke(now);

            Test method2 = 
                (DateTime day) => { return day.DayOfWeek == DayOfWeek.Friday; };

            Test method3 = day => day.DayOfWeek == DayOfWeek.Friday;
            method3.Invoke(now);

            Run(day => day.DayOfWeek == DayOfWeek.Friday);
            Run(() => Console.WriteLine("Parameterless lambda"));
        }

        static void Run(Test method)
        {
            method.Invoke(DateTime.UtcNow);
        }
        static void Run(TestVoid method)
        {
            method.Invoke();
        }

    }
}
