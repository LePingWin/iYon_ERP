using iYon_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Controllers
{
    public class MainViewModel
    {
        public List<Employee> listEmployee { get; set; }
        public List<Project> listProject { get; set; }
    }
}
