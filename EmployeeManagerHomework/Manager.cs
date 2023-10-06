using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerHomework
{
    internal class Manager : Emplooyee
    {
        private int managerNumber;
        public Manager(string name, string dateOfStart, string referance, int salary, int managerNumber) : base(name, dateOfStart, referance, salary)
        {
            this.ManagerNumber = managerNumber;
        }

        public int ManagerNumber { get => managerNumber; set => managerNumber = value; }
    }
}
