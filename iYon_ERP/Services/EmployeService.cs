using iYon_ERP.Models;
using iYon_ERP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Services
{
    public class EmployeService
    {
        private static EmployeRepository EmployeeRepo = new EmployeRepository();
        public List<Employee> Employees { get { return EmployeeRepo.GetAllItems(); } }


        //AddEmployee
        //call employee repo
    }
}
