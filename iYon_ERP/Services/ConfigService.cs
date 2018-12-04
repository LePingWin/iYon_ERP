using iYon_ERP.Models;
using iYon_ERP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Services
{
    public class ConfigService
    {
        private static ConfigRepository ConfigRepo = new ConfigRepository();
        public List<Config> Configs { get { return ConfigRepo.GetAllItems(); } }

        public float getEfficiencyRealTime(int workload, int efficiency)
        {
            return workload / efficiency;
        }
    }
}
