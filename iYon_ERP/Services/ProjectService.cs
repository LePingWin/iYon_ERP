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

        public Project GetProjectByID(int id)
        {
            return Projects.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Project> GetEmployeeProjects(Employee emp)
        {
            return Projects.Where(x => x.Employees.Contains(emp)).ToList();
        }

        public void AssignEmployeeToProject(Employee emp, Project p)
        {
            p.AssignEmployee(emp);
        }

        public void UnAsssignEmployeeToProject(Employee emp, Project p)
        {
            p.UnAssignEmployee(emp);
        }

        //TODO : Fonction qui calcul si un projet dispose de toutes les ressources nécessaires
    }
}
