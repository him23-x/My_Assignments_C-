using Day02Task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Day02Task.Models.BusinessLogic
{
    public class CourseBL
    {
        SystemDbContext context = new SystemDbContext();

        public List<Course> GetAllCourses()
        {
            return context.Courses.Include(c => c.Department).ToList();
        }

        public Course GetCourseById(int id)
        {
            return context.Courses.Include(c => c.Department).FirstOrDefault(c => c.Id == id) ?? new Course();
        }

        public void AddCourse(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void SaveInDB()
        {
            context.SaveChanges();
        }

        public void Delete(Course course)
        {
            context.Courses.Remove(course);
            context.SaveChanges();
        }
    }
}
