﻿using iYon_ERP.Models;
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



        public bool IsEmployeeOperational(DateTime currentDate, DateTime operationalDate)
        {
            return DateTime.Compare(currentDate,operationalDate) < 0 ? false : true;
        }

        public Employee GetEmployeeByID(int id)
        {
            return Employees.Where(e => e.Id == id).FirstOrDefault();
        }

        //AddEmployee
        //call employee repo
    }
}
