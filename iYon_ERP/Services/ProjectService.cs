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

        public Project GetProjectByName(string name)
        {
            return Projects.Where(x => x.Name == name).FirstOrDefault();
        }

        public void AssignEmployeeToProject(Employee emp, Project p)
        {
            p.AssignEmployee(emp);
        }

        public void UnAsssignEmployeeToProject(Employee emp, Project p)
        {
            p.UnAssignEmployee(emp);
        }

        public Project GetProjectByID(int id)
        {
            return Projects.Where(e => e.Id == id).FirstOrDefault();
        }

    }
}
