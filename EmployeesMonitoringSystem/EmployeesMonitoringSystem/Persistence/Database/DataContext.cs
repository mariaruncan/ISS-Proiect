using EmployeesMonitoringSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeesMonitoringSystem.Persistence.Database
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public string DbPath;

        public DataContext()
        {
            DbPath = "D:\\Facultate\\Semestrul 4\\ISS\\Lab\\ISS-Proiect\\EmployeesMonitoringSystem\\company.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
