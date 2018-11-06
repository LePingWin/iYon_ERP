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
    public class ProjectRepository
    {
        private List<Project> listProjects { get; set; }
        private string fileUrl = string.Format(@"{0}\{1}", AppConfig.SimulationFilesPath, "Projects.json");
        public List<Project> GetAllItems()
        {
            using (StreamReader file = File.OpenText(fileUrl)
            {
                JsonSerializer serializer = new JsonSerializer();
                listProjects = (List<Project>)serializer.Deserialize(file, typeof(Project));
            }
            return listProjects;
        }
    }
}
