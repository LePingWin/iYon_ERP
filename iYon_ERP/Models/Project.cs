using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
     public class Project
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime Deadline { get; set; }
        private int DevWorkLoadInDays { get; set; }
        private int ProjectManagementWorkLoadInDays { get; set; }
        private Dictionary<Employee,int> EmployeeWorkloadDictionnary { get; set; }
    }
}
