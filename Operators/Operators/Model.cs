using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class User
    {
        public Address Address { get; set; }
    }
    class Employee : User
    {
        public DateTime DateOfBirth { get; set; }
        public String JobTitle { get; set; }
        public Sale[] Sales { get; set; }
    }

    class Address
    {
        public String City { get; set; }
        public String Street { get; set; }
    }

    class Sale
    {
        public User Customer { get; set; }
        public Decimal Amount { get; set; }
    }
}
