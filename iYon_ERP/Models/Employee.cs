using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class Employee
    {
        [JsonProperty("Id")]
        public int Id { get; private set; }
        [JsonProperty("Name")]
        public string Name { get; private set; }
        [JsonProperty("HireDate")]
        public DateTime HireDate { get; private set; }
        public DateTime OperationalDate
        {
            get { return HireDate.Add(AppConfig.DaysBeforeEmployeeOperational); }
        }
        [JsonProperty("Role")]
        public Type Role { get; private set; }
    }

    public enum Type
    {
        Developer,
        ProjectManager
    }
}
