using System.Collections.Generic;
using SaleStoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaleStoreMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {            
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "Eletro"});
            departments.Add(new Department { Id = 2, Name = "Fashion" });

            return View(departments);
        }
    }
}
