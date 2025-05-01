using EmpMVC.Models;
using EmpMVC.Repository;
using Microsoft.EntityFrameworkCore;

namespace EmpMVC.Service
{
    public class SqlEmployee : IEmployee
    {
        private readonly Appdbcontext context;

        public SqlEmployee(Appdbcontext context)
        {
            this.context = context;
        }

        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }
        public Employee? GetEmployee(int id)
        {
            Employee e = context.Employees.Include(e => e.Department).FirstOrDefault(b => b.Id == id);

            return e;
        }


        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees.Include<Employee>("Department");
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return context.Departments;
        }
    }
}
