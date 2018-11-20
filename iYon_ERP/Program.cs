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
            MainViewModel mainVM = _MainController.GetTestGame(3);

            Console.WriteLine("------ INIT -----");
            Console.WriteLine("DaysBeforeEmployeeOperational : " + AppConfig.DaysBeforeEmployeeOperational.ToString());
            Console.WriteLine("Efficience : " + AppConfig.Efficience.ToString());
            Console.WriteLine("SimulationFilesPath : " + AppConfig.SimulationFilesPath.ToString());
            Console.WriteLine("StartSimulationDate : " + AppConfig.StartSimulationDate.ToString());
            Console.WriteLine("------ Employees -----");
            mainVM.listEmployee.ForEach(e => Console.WriteLine(e.ToString()));
            Console.WriteLine("------ Projects -----");
            mainVM.listProject.ForEach(p => Console.WriteLine(p.ToString()));
            Console.ReadLine();
        }
    }
}
