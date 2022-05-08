using EmployeesMonitoringSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesMonitoringSystem.Persistence
{
    public interface IEmployeesRepositoy : IRepository<Employee>
    {
        Employee FindByUsername(string username);
        List<Employee> FindLoggedEmployees();
    }
}
