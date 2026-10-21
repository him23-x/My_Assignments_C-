using Day02Task.Models;
using Day02Task.Models.BusinessLogic;
using Day02Task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Day02Task.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();
        public IActionResult ShowAllDepts()
        {
            List<Department> departments = departmentBL.GetAllDepartments();
            return View("ShowAllDepts", departments);
        }

        public IActionResult ShowDeptDetials(int id)
        {
            Department department = departmentBL.GetDepartmentById(id);
            return View("ShowDeptDetials", department);
        }


        public IActionResult Add()
        {
            return View("Add");
        }


        public IActionResult SaveAdd(Department department)
        {
            if(department.Name!=null)
            {
                departmentBL.AddDept(department);
                return RedirectToAction(nameof(ShowAllDepts));
            }
            return View("Add");
        }


        public IActionResult ExtraInfoDetails(int id)
        {
            Department dept = departmentBL.GetDepartmentById(id);

            DepartmentWithExtraInfo departmentWithExtraInfo = new DepartmentWithExtraInfo()
            {
                DeptName = dept.Name,
                Experience = 24,
                Students = dept.Students
            };
            return View("ExtraInfoDetails",departmentWithExtraInfo);
        }


    }
}
