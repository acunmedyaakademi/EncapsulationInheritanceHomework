using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emplooyee emplooye1 = new Emplooyee("Efe Yakar","06.10.2023","Hakan Hakyemez",15000);
            Manager manager1 = new Manager("Hakan Hakyemez", "06.10.2004", "Ege Üniversitesi rektörü", 75000,100);

            Console.WriteLine(manager1.ManagerNumber);
            Console.WriteLine(emplooye1.Referance);

            Console.ReadKey();
        }
    }
}
