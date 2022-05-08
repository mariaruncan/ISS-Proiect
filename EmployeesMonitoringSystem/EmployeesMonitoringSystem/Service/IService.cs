using EmployeesMonitoringSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesMonitoringSystem.Service
{
    public interface IService
    {
        // for all employees
        void LogIn(string username, string password);
        void LogOut(string username);
        Employee FindEmployeeByUsername(string username);

        // only for boss
        void AssignTask(string title, string description, int employeeId);
        List<Employee> FindLoggedEmployees();
        List<Task> FindEmployeesTasks(int employeeId);

        // only for worker
        void CompleteTask(int taskId);

        // only for admin
        void AddEmployee(string firstname, string lastname, string jobTitle, string username, string password);
        void UpdateEmployee(int id, string newFirstname, string newLastname, string newJobTitle, string newUsername, string newPassword);
        List<Employee> FindAllEmployees();
        void RemoveEmployee(int employeeId);
    }


    public class ServiceException : Exception
    {
        public ServiceException(string message) : base(message)
        { }
    }
}
