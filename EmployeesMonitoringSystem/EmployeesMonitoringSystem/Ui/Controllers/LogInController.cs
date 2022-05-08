using EmployeesMonitoringSystem.Model;
using EmployeesMonitoringSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesMonitoringSystem.Ui.Controllers
{
    public class LogInController
    {
        public IService Service { get; set; }
        public Employee CrtEmployee { get; set; }

        public LogInController(IService service)
        {
            Service = service;
        }

        public void LogIn(string username, string password)
        {
            Service.LogIn(username, password);
            CrtEmployee = Service.FindEmployeeByUsername(username);
        }
    }
}
