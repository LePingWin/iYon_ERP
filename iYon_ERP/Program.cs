using iYon_ERP.Controllers;
using iYon_ERP.Models;
using iYon_ERP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iYon_ERP
{
    class Program
    {

        static void Main(string[] args)
        {
            MainController _MainController = new MainController();
            var testGameList = _MainController.GetAllTestGame();
            Console.WriteLine("------ I'm going for an adventuuuuuuure -----");
            Console.WriteLine("Push a key to begin your trip.");
            Console.ReadLine();
            Console.Clear();

            testGameList.ForEach(testGame =>
            {
                MainViewModel mainVM = _MainController.GetTestGame(testGame.Id);

                Console.WriteLine("------ INIT -----");
                Console.WriteLine("DaysBeforeEmployeeOperational : " + AppConfig.DaysBeforeEmployeeOperational.ToString());
                Console.WriteLine("SimulationFilesPath : " + AppConfig.SimulationFilesPath.ToString());
                Console.WriteLine("StartSimulationDate : " + AppConfig.StartSimulationDate.ToString());
                Console.WriteLine("Efficiency : " + mainVM.config.ToString());

                Console.WriteLine("\n------ Employees -----");
                mainVM.listEmployee.ForEach(e => Console.WriteLine(e.ToString()));
                Console.WriteLine("\n------ Projects -----");
                mainVM.listProject.ForEach(p => Console.WriteLine(p.project.ToString()));

                Console.WriteLine("\n----- Results TestGame " + testGame.Id + "/" + testGameList.Count + " ------");
                Console.WriteLine(_MainController.GetProjectsEnd(mainVM));
                Console.ReadLine();
                Console.Clear();
            });
            

        }
    }
}
