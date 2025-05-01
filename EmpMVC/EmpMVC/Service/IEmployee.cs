using EmpMVC.Models;

namespace EmpMVC.Service
{
    public interface IEmployee
    {
        Employee? GetEmployee(int id);

        Employee Add(Employee employee);

        IEnumerable<Employee> GetAllEmployee();


        IEnumerable<Department> GetAllDepartment();
    }
}
