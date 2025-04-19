using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDBLibrary
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EmployeeDB.db");
        }
    }
}
