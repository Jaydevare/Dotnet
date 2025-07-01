using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private List<Employee> _employees;

        public EmployeeController ()
        {
            _employees = new List<Employee> ()
            {
                new(){EmployeeId = 1, EmployeeName="Sumedh", EmployeeAge = 23, EmployeeCity ="Pune", PhoneNumber = 1234567890},
                new(){EmployeeId = 2, EmployeeName="Jay", EmployeeAge=22, EmployeeCity = "Mumbai", PhoneNumber = 9876543210 },
                new(){EmployeeId = 3, EmployeeName="Mayur", EmployeeAge=22, EmployeeCity = "Nashik", PhoneNumber = 6548732109},
                new(){EmployeeId = 4, EmployeeName="Sanket", EmployeeAge=23, EmployeeCity = "Beed", PhoneNumber = 3214569870}
            };
        }
        public IActionResult Index()
        {
            return Content("<h1>HELLOOOOO</h1><hr><h4>Welcome........</h4>","text/html");
        }

        public IActionResult Data()
        {
            return Json(_employees);
        }
    }
}
