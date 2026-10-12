using Day02Task.Models;
using Day02Task.Models.BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace Day02Task.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> students = studentBL.GetAllStudents();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student student = studentBL.GetStudentById(id);
            return View("ShowDetails", student);
        }
    }
}
