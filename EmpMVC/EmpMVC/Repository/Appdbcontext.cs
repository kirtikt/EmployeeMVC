using EmpMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpMVC.Repository
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
                 : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
