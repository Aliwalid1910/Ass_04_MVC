using Demo.BusinessLogic.DTOS;
using Demo.BusinessLogic.Services.Classes;
using Demo.BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace Demo.Presentation.Controllers
{
    public class DepartmentController(IDepartmentService _departmentService
        , IWebHostEnvironment _env, ILogger<DepartmentController> _logger) : Controller
    {
        #region Index
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreatedepartmentDto departmentDto)
        {
            if (ModelState.IsValid) // Server Side Validation
            {
                try
                {
                    int result = _departmentService.AddDepartment(departmentDto);
                    if (result > 0)
                    {
                       return RedirectToAction(nameof(Index));    
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Department Can not be Created !!");

                    }
                }
                catch (Exception ex)
                {
                    if (_env.IsDevelopment())
                    {
                        _logger.LogError($"Department Con not be created becouse : {ex.Message}");

                    }
                    else
                    {
                        _logger.LogError($"Department Con not be created becouse : {ex.Message}");
                        //return View(departmentDto);
                        return View("Error view");
                    }
                }
            }
            return View(departmentDto);

        }
        #endregion

        #region Details
        [HttpGet]
        public IActionResult Details(int? id)
        { 
            if(!id.HasValue) return BadRequest();
            var department = _departmentService.GetDepartmentById(id.Value);
            if (department is null) return NotFound();
            return View(department);
        }
        #endregion
    }
}

