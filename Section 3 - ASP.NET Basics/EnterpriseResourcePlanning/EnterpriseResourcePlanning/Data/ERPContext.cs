using EnterpriseResourcePlanning.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseResourcePlanning.Data
{
    public class ERPContext: DbContext
    {
        public ERPContext(DbContextOptions<ERPContext> options) : base(options) { }
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set;  }
        public DbSet<JobTitle> JobTitles { get; set; }  
    }
}
