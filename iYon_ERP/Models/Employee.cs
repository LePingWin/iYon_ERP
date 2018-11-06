using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime HireDate { get; set; }
        private DateTime OperationalDate { get; set; }
        private int DevCharge { get; set; }
        private Type Role { get; set; }
    }

    public enum Type
    {
        Dev,
        ProjectManagement
    }
}
