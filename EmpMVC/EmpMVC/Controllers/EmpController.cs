using EmpMVC.Models;
using EmpMVC.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmpMVC.Controllers
{
    public class EmpController : Controller
    {


        private IEmployee _emp;
        private readonly ILogger<EmpController> _logger;

        public EmpController(IEmployee emp, ILogger<EmpController> logger)
        {
            _emp = emp;
            _logger = logger;
        }





        // GET: EmpController
        public ActionResult Index()
        {
            var model = _emp.GetAllEmployee();
            return View(model);
        }

        
        // GET: EmpController/Create
        public ActionResult Create()
        {
            IEnumerable<Department> DepartmentName = _emp.GetAllDepartment();
            if (ModelState.IsValid)
            
            ViewData["xyz"] = new SelectList(DepartmentName, "DeptId", "DeptName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Employee employee)
        {
            IEnumerable<Department> DepartmentName = _emp.GetAllDepartment();
            if (ModelState.IsValid)
            {
                var model = _emp.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            ViewData["xyz"] = new SelectList(DepartmentName, "DeptId", "DeptName");
            return View();
        }

       
      
    }
}
