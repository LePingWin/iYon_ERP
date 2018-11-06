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
        public Dictionary<Employee,int> EmployeeWorkloadDictionnary { get; private set; }
    }
}
