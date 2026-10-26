using Day02Task.Models;
using Day02Task.Models.BusinessLogic;
using Day02Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day02Task.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();

        public IActionResult ShowAll()
        {
            List<Student> students = studentBL.GetAllStudents();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            Student student = studentBL.GetStudentById(id);
            return View("ShowDetails", student);
        }

        public IActionResult Add()
        {
            StuDeptViewModel SDVM = new StuDeptViewModel()
            {
                DepartmentList = GetDepartmentSelectList()
            };

            return View("Add", SDVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveAdd(StuDeptViewModel model)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    Name = model.Name,
                    Age = model.Age,
                    DepartmentId = model.DepartmentId
                };
                studentBL.AddNewStudent(student);
                return RedirectToAction(nameof(ShowAll));
            }

            // Re-populate dropdown if validation fails
            model.DepartmentList = GetDepartmentSelectList();
            return View("Add", model);
        }

        public IActionResult Edit(int id)
        {
            Student student = studentBL.GetStudentById(id);
            StuDeptViewModel SDVM = new StuDeptViewModel()
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                DepartmentList = GetDepartmentSelectList()
            };
            return View("Edit", SDVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(StuDeptViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                Student oldStudent = studentBL.GetStudentById(id);
                oldStudent.Name = model.Name;
                oldStudent.Age = model.Age;
                oldStudent.DepartmentId = model.DepartmentId;
                studentBL.SaveInDB();

                return RedirectToAction(nameof(ShowAll));
            }

            // Re-populate dropdown if validation fails
            model.DepartmentList = GetDepartmentSelectList();
            return View("Edit", model);
        }

        public IActionResult Delete(int id)
        {
            Student student = studentBL.GetStudentById(id);
            return View("Delete", student);
        }

        public IActionResult ConfirmDelete(int id)
        {
            Student student = studentBL.GetStudentById(id);
            if (student != null)
            {
                studentBL.Delete(student);
                return RedirectToAction(nameof(ShowAll));
            }
            return NotFound();
        }

        // Helper method to build SelectListItem list from departments
        private List<SelectListItem> GetDepartmentSelectList()
        {
            List<Department> departments = departmentBL.GetAllDepartments();
            return departments.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Name
            }).ToList();
        }
    }
}
