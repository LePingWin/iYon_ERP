using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
     public class Project
    {
        [JsonProperty("Id")]
        public int Id { get; private set; }
        [JsonProperty("Name")]
        public string Name { get; private set; }
        [JsonProperty("Deadline")]
        public DateTime Deadline { get; private set; }
        [JsonProperty("DevWorkLoadInDays")]
        public int DevWorkLoadInDays { get; private set; }
        [JsonProperty("ProjectManagementWorkLoadInDays")]
        public int ProjectManagementWorkLoadInDays { get; private set; }

        public List<Employee> Employees { get; private set; }

        
        public void AssignEmployee(Employee emp)
        {
            this.Employees.Add(emp);
        }

        public void UnAssignEmployee(Employee emp)
        {
            this.Employees.Remove(emp);
        }

        public override string ToString()
        {
            return "Name: " + Name + "| Deadline:" + Deadline + "| TotalWorkLoad: " + (DevWorkLoadInDays + ProjectManagementWorkLoadInDays).ToString() + " days";
        }
    }
}
