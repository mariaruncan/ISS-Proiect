using EmployeesMonitoringSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeesMonitoringSystem.Persistence.Database
{
    public class TasksDbRepository : ITasksRepository
    {
        public void Add(Task elem)
        {
            throw new NotImplementedException();
        }

        public List<Task> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Task> FindTasksByEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Task elem, int id)
        {
            throw new NotImplementedException();
        }
    }
}
