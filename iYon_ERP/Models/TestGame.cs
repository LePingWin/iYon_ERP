using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class TestGame
    {
        [JsonProperty("Id")]
        public int Id { get; private set; }
        [JsonProperty("Config")]
        public int Name { get; private set; }
        [JsonProperty("Employees")]
        public List<int> EmployeesID { get; private set; }
        [JsonProperty("Projects")]
        public List<int> ProjectsID { get; private set; }

        public List<Employee> listEmployee { get; set; }
        public List<Project> listProject { get; set; }
    }
}
