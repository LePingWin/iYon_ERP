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
        private ConfigService _ConfigService = new ConfigService();

        public MainViewModel GetTestGame(int testGameId)
        {
            TestGame testGame = _TestGameService.TestGames.Where(tg => tg.Id == testGameId).FirstOrDefault();
            MainViewModel mainVM = new MainViewModel();

            mainVM.listEmployee = new List<Employee>();
            testGame.EmployeesID.ForEach(id => mainVM.listEmployee.Add(_EmployeeService.GetEmployeeByID(id)));

            mainVM.listProject = new List<ProjectWrapper>();
            testGame.ProjectsID.ForEach(id => mainVM.listProject.Add(new ProjectWrapper(_ProjectService.GetProjectByID(id))));
            mainVM.config = _ConfigService.Configs.Where(config => config.Id == testGame.ConfigID).FirstOrDefault();
            mainVM.listProject.ForEach(projectW =>
            {
                _ProjectService.AssignAllEmployeeToProject(mainVM.listEmployee, projectW.project);
            });


            return mainVM;
        }

        public List<TestGame> GetAllTestGame()
        {
            return _TestGameService.TestGames;
        }

        public float CalculateProjectWorkDaysForDevs(DateTime projectStartDate,MainViewModel model, Project project)
        {
                return _ProjectService.GetEffectiveWorkTimeOnProject(projectStartDate,project, Models.Type.Developer, model.config.Efficience);
        }

        public float CalculateProjectWorkDaysForProjectManagement(DateTime projectStartDate,MainViewModel model, Project project)
        {
            return _ProjectService.GetEffectiveWorkTimeOnProject(projectStartDate, project, Models.Type.ProjectManager, model.config.Efficience);
        }

        //Gerer les week ends
        public void SetCurrentDevTime(MainViewModel model, float time)
        {
            model.CurrentDevDay = _ProjectService.AddWorkTime(time, model.CurrentDevDay);
        }

        public void SetCurrentProjectManagementTime(MainViewModel model, float time)
        {
            model.CurrentProjectManagementDay = _ProjectService.AddWorkTime(time, model.CurrentProjectManagementDay);
        }

        public string GetProjectsEnd(MainViewModel model)
        {
            var endResult = "OK !";
            int i = 1;
            DateTime nextProjectStartDate = AppConfig.StartSimulationDate;
            GetProjectListOrderByDeadline(model).ForEach(projectW =>
            {
                CalculateProjectEnd(nextProjectStartDate,model, projectW, i);
                nextProjectStartDate = projectW.GetProjectEndDate;
                i = 0;
                if (projectW.GetProjectEndDate < projectW.project.Deadline)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    endResult = "NOK !";
                }

                Console.WriteLine(projectW.ToString());

            });
            Console.ResetColor();
            return endResult;
        }

        private void CalculateProjectEnd(DateTime projectStartDate,MainViewModel model, ProjectWrapper projectW, int i)
        {
            SetCurrentDevTime(model, CalculateProjectWorkDaysForDevs(projectStartDate,model, projectW.project) - i);
            SetCurrentProjectManagementTime(model, CalculateProjectWorkDaysForProjectManagement(projectStartDate,model, projectW.project) - i);
            projectW.DevsEndDate = model.CurrentDevDay;
            projectW.ProjectManagementEndDate = model.CurrentProjectManagementDay;
        }

        private static List<ProjectWrapper> GetProjectListOrderByDeadline(MainViewModel model)
        {
            return model.listProject.OrderBy(projectW => projectW.project.Deadline).ToList();
        }


        //Méthode : On affecte tout le monde au même projet, on vérifie la date de fin de chaque tâche (ici dev et pilotage). 
        //La date la plus tardive représente la fin du projet. 
        //L'autre date indique qu'on peut affecter un développeur à un projet à une certaine date
        //On affecte le prochain
        //TODO : Fonction qui affecte un projet à
        //TODO : Fonction d'ordonancement de projets
    }
}
