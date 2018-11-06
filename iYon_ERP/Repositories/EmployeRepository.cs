using iYon_ERP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Repositories
{
    public class EmployeRepository
    {

        private List<Employee> listEmployees { get; set; }
        private string fileUrl = string.Format(@"{0}\{1}",AppConfig.SimulationFilesPath,"Employees.json");

        public List<Employee> GetAllItems()
        {
            return JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(fileUrl));
        }
    }
}
