using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public class AppConfig
    {
        private int Efficience { get; set; } = int.Parse(ConfigurationManager.AppSettings["Efficience"]);
        private TimeSpan DaysBeforeEmployeeOperational { get; set; } = new TimeSpan(int.Parse(ConfigurationManager.AppSettings["DaysBeforeEmployeeOperational"]));
        private DateTime StartSimulationDate { get; set; } = DateTime.Parse(ConfigurationManager.AppSettings["StartSimulationDate"]);
        private string SimulationFilesPath { get; set; } = ConfigurationManager.AppSettings["SimulationFilesPath"];
    }
}
