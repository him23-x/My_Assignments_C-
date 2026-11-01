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
            return View("Add", new Department());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveAdd(Department department)
        {
            if (ModelState.IsValid)
            {
                departmentBL.AddDept(department);
                return RedirectToAction(nameof(ShowAllDepts));
            }
            return View("Add", department);
        }

        public IActionResult Edit(int id)
        {
            Department department = departmentBL.GetDepartmentById(id);
            return View("Edit", department);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(Department department, int id)
        {
            if (ModelState.IsValid)
            {
                Department oldDept = departmentBL.GetDepartmentById(id);
                oldDept.Name = department.Name;
                oldDept.MgrName = department.MgrName;
                departmentBL.SaveInDB();
                return RedirectToAction(nameof(ShowAllDepts));
            }
            return View("Edit", department);
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
            return View("ExtraInfoDetails", departmentWithExtraInfo);
        }
    }
}
