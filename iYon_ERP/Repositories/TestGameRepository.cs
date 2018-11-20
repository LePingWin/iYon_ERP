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
    class TestGameRepository
    {
        private string fileUrl = string.Format(@"{0}\{1}", AppConfig.SimulationFilesPath, "JeuSetEtMatch.json");
        public List<TestGame> GetAllItems()
        {
            return JsonConvert.DeserializeObject<List<TestGame>>(File.ReadAllText(fileUrl));
        }
    }
}
