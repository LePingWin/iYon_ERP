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
        private DateTime StartDate { get; set; }
        private DateTime LimiteDate { get; set; }
        private int DevWorkLoad { get; set; }
        private int ProjectManagementWorkLoad { get; set; }

        private Dictionary<Employee,int> EmployeeWorkloadDictionnary { get; set; }

        
    }
}
