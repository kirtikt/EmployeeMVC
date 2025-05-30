﻿using System.ComponentModel.DataAnnotations;

namespace EmpMVC.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        public string DeptName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
