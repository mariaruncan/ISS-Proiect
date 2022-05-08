using EmployeesMonitoringSystem.Model;
using EmployeesMonitoringSystem.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesMonitoringSystem.Ui.Controllers
{
    public class AdminController
    {
        public IService Service { get; set; }
        public Employee CrtEmployee { get; set; }

        public AdminController(IService service, Employee crtEmployee)
        {
            Service = service;
            CrtEmployee = crtEmployee;
        }

        public List<Employee> FindAllEmployees()
        {
            return Service.FindAllEmployees();
        }

        public void AddEmployee(string firstname, string lastname, string username, string password, string jobTitle)
        {
            Service.AddEmployee(firstname, lastname, username, password, jobTitle);
        }

        public void RemoveEmployee(string employeeId)
        {
            Service.RemoveEmployee(Int32.Parse(employeeId));
        }

        internal void UpdateEmployee(string id, string newFirstname, string newLastname, string newJobTitle, string newUsername, string newPassword)
        {
            Service.UpdateEmployee(Int32.Parse(id), newFirstname, newLastname, newJobTitle, newUsername, newPassword);
        }
    }
}
