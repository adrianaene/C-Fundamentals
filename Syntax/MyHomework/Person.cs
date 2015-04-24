using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Person
    {
        protected string lastName;
        protected string firstName;
        protected string dateOfBirth;

        public Person(string lastName, string firstName, string dateOfBirth)
        {
            this.lastName = lastName;
            this.firstName = lastName;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
