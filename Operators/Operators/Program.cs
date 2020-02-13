using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();



            // the oldschool version
            if (employee!=null && employee.Sales!=null && employee.Sales.Length>0 && 
                employee.Sales[0]!=null && employee.Sales[0].Customer!=null &&
                employee.Sales[0].Customer.Address!= null )
            {
                String city = employee.Sales[0].Customer.Address.City;
            }

            // the Elvis version
            String eCity = employee?.Sales?[0]?.Customer?.Address?.City;

            // nullable Decimal
            Decimal? amount = employee?.Sales?[0]?.Amount;

            String formattedCity;
            // traditional version
            if (eCity == null)
            {
                formattedCity = "unknown";
            }
            else
            {
                formattedCity = eCity;
            }

            // ternary operator version
            formattedCity = eCity == null ? "unknown" : eCity;
            // null-coalescing operator version
            formattedCity = eCity ?? "unknown";
            // null-coalescing assignment
            //eCity ??= "unknown"; // works only in C# 8.0 and above
        }
    }
}
