using Demo.BusinessLogic.Services.Classes;
using Demo.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService) 
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
