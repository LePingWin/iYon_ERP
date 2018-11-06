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
        private string fileUrl = ConfigurationManager.AppSettings["projectsFileUrl"];
        public List<Project> GetAllItems()
        {
            using (StreamReader file = File.OpenText(@"c:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                listProjects = (List<Project>)serializer.Deserialize(file, typeof(Project));
            }
            return listProjects;
        }
    }
}
