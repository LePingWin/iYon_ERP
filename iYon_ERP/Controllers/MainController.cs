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

        public MainViewModel GetTestGame(int testGameId)
        {
            TestGame testGame = _TestGameService.TestGames.Where(tg => tg.Id == testGameId).FirstOrDefault();
            MainViewModel mainVM = new MainViewModel();

            mainVM.listEmployee = new List<Employee>();
            testGame.EmployeesID.ForEach(id => mainVM.listEmployee.Add(_EmployeeService.GetEmployeeByID(id)));

            mainVM.listProject = new List<Project>();
            testGame.ProjectsID.ForEach(id => mainVM.listProject.Add(_ProjectService.GetProjectByID(id)));

            return mainVM;
        }

        //Méthode : On affecte tout le monde au même projet, on vérifie la date de fin de chaque tâche (ici dev et pilotage). 
        //La date la plus tardive représente la fin du projet. 
        //L'autre date indique qu'on peut affecter un développeur à un projet à une certaine date
        //On affecte le prochain
        //TODO : Fonction qui affecte un projet à
        //TODO : Fonction d'ordonancement de projets
    }
}
