using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2
{
    class Person
    {

        public Person(string firstname, string lastname, int age, string phonenumber)
        {
            FirstName = firstname;
            LastName = firstname;
            Age = age;
            PhoneNumber = phonenumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }
}
