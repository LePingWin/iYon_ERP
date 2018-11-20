using iYon_ERP.Models;
using iYon_ERP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP.Controllers
{
    class MainController
    {
        //Hire()
        // call addEmployee() from EmployeeService
        // call updateTimeLineAllProject() from ProjectService
        private TestGameService _TestGameService = new TestGameService();
        private EmployeService _EmployeeService = new EmployeService();
        private ProjectService _ProjectService = new ProjectService();

        private void getTestGame(int testGameId)
        {
            TestGame testGame = _TestGameService.TestGames.Where(tg => tg.Id == testGameId).FirstOrDefault();
            List<Employee> testGameEmployes = new List<Employee>();
            testGame.EmployeesID.ForEach(id => testGameEmployes.Add(_EmployeeService.GetOneById(id)));

            List<Project> testGameProjects = new List<Project>();
            testGame.ProjectsID.ForEach(id => testGameProjects.Add(_ProjectService.GetOneById(id)));
        }
    }
}
