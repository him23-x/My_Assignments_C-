using Day02Task.Models;
using Day02Task.Models.BusinessLogic;
using Day02Task.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            Student student = new Student();
            List<Department> departments = departmentBL.GetAllDepartments();
            StuDeptViewModel SDVM = new StuDeptViewModel()
            {
                Name = student.Name,
                Age = student.Age,
                Departments = departments
            };

            return View("Add", SDVM);
        }

        [HttpPost]
        public IActionResult SaveAdd(Student student)
        {
            if (student.Name != null)
            {
                studentBL.AddNewStudent(student);
                return RedirectToAction(nameof(ShowAll));
            }
            return View("Add", student);
        }

        public IActionResult Edit(int id)
        {
            Student student = studentBL.GetStudentById(id);
            List<Department> departments = departmentBL.GetAllDepartments();
            StuDeptViewModel SDVM = new StuDeptViewModel()
            {
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                Departments = departments
            };
            return View("Edit",SDVM);
        }

        public IActionResult SaveEdit(Student student,int id)
        {
            if (student.Name != null)
            {
                Student oldStudent = studentBL.GetStudentById(id);
                oldStudent.Name = student.Name;
                oldStudent.Age = student.Age;
                oldStudent.DepartmentId = student.DepartmentId;
                studentBL.SaveInDB();

                return RedirectToAction(nameof(ShowAll));
            }
            return View("Edit");
        }

        public IActionResult Delete(int id)
        {
            Student student = studentBL.GetStudentById(id);
            return View("Delete", student);
        }

        public IActionResult ConfirmDelete(int id)
        {
            Student student = studentBL.GetStudentById(id);
            if(student != null)
            {
                studentBL.Delete(student);
                return RedirectToAction(nameof(ShowAll));
            }
            return NotFound();
        }

    }
}
