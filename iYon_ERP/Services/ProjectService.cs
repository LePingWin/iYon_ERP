using iYon_ERP.Models;
using iYon_ERP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Services
{
    public class ProjectService
    {
        private static ProjectRepository ProjectRepo = new ProjectRepository();
        public List<Project> Projects { get { return ProjectRepo.GetAllItems(); } }
    }
}
