using EmployeesMonitoringSystem.Model;
using EmployeesMonitoringSystem.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesMonitoringSystem.Service
{
    public class ServiceImpl : IService
    {
        private IEmployeesRepositoy EmployeesRepo;
        private ITasksRepository TasksRepo;

        public ServiceImpl(IEmployeesRepositoy employeesRepo, ITasksRepository tasksRepo)
        {
            EmployeesRepo = employeesRepo;
            TasksRepo = tasksRepo;
        }

        public void AddEmployee(string firstname, string lastname, string jobTitle, string username, string password)
        {
            string err = "";
            JobTitle j = JobTitle.BOSS;
            switch (jobTitle)
            {
                case "WORKER":
                    j = JobTitle.WORKER;
                    break;
                case "ADMIN":
                    j = JobTitle.ADMIN;
                    break;
                case "BOSS":
                    j = JobTitle.BOSS;
                    break;
                default:
                    err += "Invalid job title!\n";
                    break;
            }
            if (username.Length < 5)
                err += "Invalid username!\n";
            if (password.Length < 5)
                err += "Invalid password!\n";
            if (err != "")
                throw new ServiceException(err);
            EmployeesRepo.Add(new Employee
            {
                FirstName = firstname,
                LastName = lastname,
                Jobtitle = j,
                Username = username,
                Password = password,
                IsLogged = false
            });
        }

        public void AssignTask(string title, string description, int employeeId)
        {
            throw new NotImplementedException();
        }

        public void CompleteTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> FindAllEmployees()
        {
            return EmployeesRepo.FindAll();
        }

        public Employee FindEmployeeByUsername(string username)
        {
            return EmployeesRepo.FindByUsername(username);
        }

        public List<Task> FindEmployeesTasks(int employeeId)
        {
            throw new NotImplementedException();
            // return TasksRepo.FindTasksByEmployee(employeeId);
        }
        
        public List<Employee> FindLoggedEmployees()
        {
            throw new NotImplementedException();
        }

        public void LogIn(string username, string password)
        {
            Employee employee = EmployeesRepo.FindByUsername(username);
            if(employee != null)
            {
                if (password != employee.Password)
                    throw new ServiceException("Authentication failed.");
                employee.IsLogged = true;
                EmployeesRepo.Update(employee, employee.Id);
            }
            else
            {
                throw new ServiceException("Authentication failed.");
            }
        }

        public void LogOut(string username)
        {
            Employee employee = EmployeesRepo.FindByUsername(username);
            employee.IsLogged = false;
            EmployeesRepo.Update(employee, employee.Id);
        }

        public void RemoveEmployee(int employeeId)
        {
            EmployeesRepo.Remove(employeeId);
        }

        public void UpdateEmployee(int id, string newFirstname, string newLastname, string newJobTitle, string newUsername, string newPassword)
        {
            string err = "";
            JobTitle j = JobTitle.BOSS;
            switch (newJobTitle)
            {
                case "WORKER":
                    j = JobTitle.WORKER;
                    break;
                case "ADMIN":
                    j = JobTitle.ADMIN;
                    break;
                case "BOSS":
                    j = JobTitle.BOSS;
                    break;
                default:
                    err += "Invalid job title!\n";
                    break;
            }
            if (newUsername.Length < 5)
                err += "Invalid username!\n";
            if (newPassword.Length < 5)
                err += "Invalid password!\n";
            if (err != "")
                throw new ServiceException(err);
            EmployeesRepo.Update(new Employee 
            {   
                FirstName = newFirstname, 
                LastName = newLastname, 
                Jobtitle = j, 
                Username = newUsername, 
                Password = newPassword 
            }, id);
        }
    }
}
