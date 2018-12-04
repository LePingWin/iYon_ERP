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
    public class ConfigRepository
    {

        private List<Config> listConfigs { get; set; }
        private string fileUrl = string.Format(@"{0}\{1}", AppConfig.SimulationFilesPath, "Config.json");

        public List<Config> GetAllItems()
        {
            return JsonConvert.DeserializeObject<List<Config>>(File.ReadAllText(fileUrl));
        }
    }
}
