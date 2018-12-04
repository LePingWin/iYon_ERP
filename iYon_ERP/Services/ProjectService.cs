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
        private static ConfigRepository ConfigRepo = new ConfigRepository();

        public List<Project> Projects { get { return ProjectRepo.GetAllItems(); } }

        public Project GetProjectByName(string name)
        {
            return Projects.Where(x => x.Name == name).FirstOrDefault();
        }

        public void AssignEmployeeToProject(Employee emp, Project p)
        {
            p.AssignEmployee(emp);
        }

        public void AssignAllEmployeeToProject(List<Employee> listEmp, Project p)
        {
            p.AssignAllEmployee(listEmp);
        }

        public void UnAsssignEmployeeToProject(Employee emp, Project p)
        {
            p.UnAssignEmployee(emp);
        }

        public Project GetProjectByID(int id)
        {
            return Projects.Where(e => e.Id == id).FirstOrDefault();
        }

        public float GetEffectiveWorkTimeOnProject(Project project, Models.Type workLoadType, float efficiency)
        {
            return GetEfficiencyRealTime(project.GetWorkLoad(workLoadType) / project.Employees.Where(emp => emp.Role == workLoadType).Count(), efficiency);    
        }

        private float GetEfficiencyRealTime(int workload, float efficiency)
        {
            return workload / efficiency;
        }


        public DateTime AddWorkTime(float workload, DateTime startProject)
        {

            DateTime currentTime = startProject;
            for (int i = 0; i < workload; i++)
            {
                currentTime = currentTime.AddDays(1);

                if (currentTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    currentTime = currentTime.AddDays(2);
                }
            }

            return currentTime;
        }
    }
}
