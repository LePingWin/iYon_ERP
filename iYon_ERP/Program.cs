using iYon_ERP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP
{
    class Program
    {
        static void Main(string[] args)
        {
            new EmployeService().Employees.ForEach(x => Console.WriteLine(x.Name));
            new ProjectService().Projects.ForEach(x => Console.WriteLine(x.Name));
            Console.ReadLine();
        }
    }
}
