using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    struct Student
    {
        public Student(string lastname, string street, int housenumber, int apartment)
        {
            LastName = lastname;
            Street = street;
            HouseNumber = housenumber;
            Apartment = apartment;

        }
        public string LastName { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int Apartment { get; set; }
    }
}
