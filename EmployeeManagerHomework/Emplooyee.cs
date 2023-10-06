using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerHomework
{
    internal class Emplooyee
    {
        private string name;
        private string dateOfStart;
        private string referance;
        private int salary;
        

        public Emplooyee(string name, string dateOfStart, string referance, int salary)
        {
            this.Name = name;
            this.DateOfStart = dateOfStart;
            this.Referance = referance;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string DateOfStart { get => dateOfStart; set => dateOfStart = value; }
        public string Referance { get => referance; set => referance = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
