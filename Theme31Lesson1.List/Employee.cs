using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme31Lesson1.List
{
    internal class Employee
    {
        private string? firstName;
        private string? lastName;
        private string? position;

        public Employee(string? firstName, string? lastName, string? position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
        public string? getFirstName() => firstName;
        public string? getLastName() => lastName;
        public string? getPosition() => position;
    }
}
