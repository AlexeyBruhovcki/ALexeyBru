using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme31Lesson1.List
{
    internal class Employees
    {
        private List<Employee>? employees;

        public Employees()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee) => employees.Add(employee);
        public void RemoveEmployee(string lastName)
        {
            Employee employee = employees.Find(p => p.getLastName() == lastName)!;
            employees?.Remove(employee);
        }
        public Employee findByName(string name) => employees.Find(p => p.getFirstName() == name)!;

        public Employee findByPosition(string position) => employees.Find(p => p.getPosition() == position)!;
        public int getEmployeesCount() => employees.Count();
        public List<Employee> getEmployees() => employees;

    }
}
