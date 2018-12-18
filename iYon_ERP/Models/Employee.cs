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

        public override string ToString()
        {
            return "Name: " + Name + "| HireDate:" + HireDate + "| Role: " + Role.ToString();
        }

        public bool IsOperational(DateTime currentDate)
        {
            return DateTime.Compare(currentDate, this.OperationalDate) < 0 ? false : true;
        }
    }




    public enum Type
    {
        Developer,
        ProjectManager
    }
}
