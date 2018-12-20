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

        public float GetEffectiveWorkTimeOnProject(DateTime projectStartDate,Project project, Models.Type workLoadType, float efficiency)
        {
            float effectiveTime = 0;
            if(project.Employees.Any(emp => !emp.IsOperational(projectStartDate)))
            {

                var dividedSegment = DivideWorkLoad(project.Employees.Where(emp => emp.Role == workLoadType).ToList(), projectStartDate, project.GetWorkLoad(workLoadType));
                dividedSegment.ForEach(seg =>
                {
                    effectiveTime += GetEfficiencyRealTime(seg.nbDays / seg.nbEmployees, efficiency);
                });
            }
            else

                effectiveTime = GetEfficiencyRealTime(project.GetWorkLoad(workLoadType) / project.Employees.Where(emp => emp.Role == workLoadType).Count(), efficiency);

            return effectiveTime;
        }

        private float GetEfficiencyRealTime(int workload, float efficiency)
        {
            return workload / efficiency;
        }

        private List<(int nbDays,int nbEmployees)> DivideWorkLoad(List<Employee> employees, DateTime startProjectDate, int workLoadTotal)
        {
            var startSegmentDays = 0;
            var numberOperationEmployee = employees.Where(emp => emp.IsOperational(startProjectDate)).Count();
            var workLoadSegments = new List<(int nbDays, int nbEmployees)> ();
            int intervalDays = 0;
            employees.OrderBy(emp => emp.OperationalDate).Where(emp => !emp.IsOperational(startProjectDate) && (emp.OperationalDate - startProjectDate).Days < (workLoadTotal / numberOperationEmployee)).ToList().ForEach(emp =>
            {
                intervalDays = (emp.OperationalDate - startProjectDate).Days - startSegmentDays;
                workLoadSegments.Add((intervalDays, numberOperationEmployee));
                numberOperationEmployee++;
                startSegmentDays = intervalDays != 0 ? intervalDays : startSegmentDays;
            });

            intervalDays = workLoadTotal - startSegmentDays;
            workLoadSegments.Add((intervalDays, numberOperationEmployee));

            return workLoadSegments;
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
