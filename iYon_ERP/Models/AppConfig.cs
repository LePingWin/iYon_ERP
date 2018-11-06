using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Models
{
    public static class AppConfig
    {
        public static int Efficience { get; } = int.Parse(ConfigurationManager.AppSettings["Efficience"]);
        public static TimeSpan DaysBeforeEmployeeOperational { get; } = new TimeSpan(int.Parse(ConfigurationManager.AppSettings["DaysBeforeEmployeeOperational"]));
        public static DateTime StartSimulationDate { get; } = DateTime.Parse(ConfigurationManager.AppSettings["StartSimulationDate"]);
         public static string SimulationFilesPath { get; } = ConfigurationManager.AppSettings["SimulationFilesPath"];

    }
}
