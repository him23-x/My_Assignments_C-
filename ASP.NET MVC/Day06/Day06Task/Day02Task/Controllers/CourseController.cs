using Day02Task.Models;
using Day02Task.Models.BusinessLogic;
using Day02Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day02Task.Controllers
{
    public class CourseController : Controller
    {
        CourseBL courseBL = new CourseBL();
        DepartmentBL departmentBL = new DepartmentBL();

        // 1. Read: Show All Courses
        public IActionResult ShowAll()
        {
            List<Course> courses = courseBL.GetAllCourses();
            return View("ShowAll", courses);
        }

        // 2. Read: Show Course Details
        public IActionResult ShowDetails(int id)
        {
            Course course = courseBL.GetCourseById(id);
            if (course == null || course.Id == 0)
            {
                return NotFound();
            }
            return View("ShowDetails", course);
        }

        // 3. Create: Show Add Form
        public IActionResult Add()
        {
            CourseDeptViewModel CDVM = new CourseDeptViewModel()
            {
                DepartmentList = GetDepartmentSelectList()
            };

            return View("Add", CDVM);
        }

        // 3. Create: Handle Form Submission (Server-side validation)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveAdd(CourseDeptViewModel model)
        {
            if (model.MinDegree.HasValue && model.MinDegree >= model.Degree)
            {
                ModelState.AddModelError(nameof(model.MinDegree), "Minimum degree must be less than the total degree.");
            }

            if (ModelState.IsValid)
            {
                Course course = new Course()
                {
                    Name = model.Name,
                    Degree = model.Degree,
                    MinDegree = model.MinDegree,
                    DepartmentId = model.DepartmentId
                };
                courseBL.AddCourse(course);
                return RedirectToAction(nameof(ShowAll));
            }

            // Re-populate dropdown if validation fails
            model.DepartmentList = GetDepartmentSelectList();
            return View("Add", model);
        }

        // 4. Update: Show Edit Form
        public IActionResult Edit(int id)
        {
            Course course = courseBL.GetCourseById(id);
            if (course == null || course.Id == 0)
            {
                return NotFound();
            }

            CourseDeptViewModel CDVM = new CourseDeptViewModel()
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                DepartmentId = course.DepartmentId,
                DepartmentList = GetDepartmentSelectList()
            };
            return View("Edit", CDVM);
        }

        // 4. Update: Handle Edit Submission (Server-side validation)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEdit(CourseDeptViewModel model, int id)
        {
            if (model.MinDegree.HasValue && model.MinDegree >= model.Degree)
            {
                ModelState.AddModelError(nameof(model.MinDegree), "Minimum degree must be less than the total degree.");
            }

            if (ModelState.IsValid)
            {
                Course oldCourse = courseBL.GetCourseById(id);
                if (oldCourse != null && oldCourse.Id != 0)
                {
                    oldCourse.Name = model.Name;
                    oldCourse.Degree = model.Degree;
                    oldCourse.MinDegree = model.MinDegree;
                    oldCourse.DepartmentId = model.DepartmentId;
                    courseBL.SaveInDB();
                    return RedirectToAction(nameof(ShowAll));
                }
                return NotFound();
            }

            // Re-populate dropdown if validation fails
            model.DepartmentList = GetDepartmentSelectList();
            return View("Edit", model);
        }

        // 5. Delete: Show Confirmation View
        public IActionResult Delete(int id)
        {
            Course course = courseBL.GetCourseById(id);
            if (course == null || course.Id == 0)
            {
                return NotFound();
            }
            return View("Delete", course);
        }

        // 5. Delete: Confirm and execute deletion
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            Course course = courseBL.GetCourseById(id);
            if (course != null && course.Id != 0)
            {
                courseBL.Delete(course);
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
