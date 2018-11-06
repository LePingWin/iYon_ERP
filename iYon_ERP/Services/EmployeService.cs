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

        public List<Employee> Employees { get; } = new EmployeRepository().GetAllItems();
        //AddEmployee
        //call employee repo
    }
}
