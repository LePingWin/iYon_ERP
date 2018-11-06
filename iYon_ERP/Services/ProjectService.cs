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
        public List<Project> Projects { get; } = new ProjectRepository().GetAllItems();
    }
}
