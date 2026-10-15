using Day02Task.Models;
using Day02Task.Models.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Day02Task.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
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
    }
}
