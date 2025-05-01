using System.ComponentModel.DataAnnotations;

namespace EmpMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }


        public string Name { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public int DepartmentId { get; set; }

        public Department? Department { get; set; }



    }
}
