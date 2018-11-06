using iYon_ERP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Repositories
{
    public class EmployeRepository
    {
        public Employee GetAllItems()
        {
            using (StreamReader file = File.OpenText(@"c:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Employee employe = (Employee)serializer.Deserialize(file, typeof(Employee));
            }

        }
    }
}
