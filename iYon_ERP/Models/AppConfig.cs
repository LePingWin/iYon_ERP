using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class AppConfig
    {
        private int Efficience { get; set; }
        private DateTime OperationalDelai { get; set; }
        private DateTime StartSimulationDate { get; set; }
        private bool IsAlerteActivate { get; set; }
    }
}
