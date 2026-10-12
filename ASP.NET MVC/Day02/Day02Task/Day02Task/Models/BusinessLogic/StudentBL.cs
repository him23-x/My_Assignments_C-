using Day02Task.Data.DbContexts;

namespace Day02Task.Models.BusinessLogic
{
    public class StudentBL
    {
        SystemDbContext context = new SystemDbContext();

        public List<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }


        public Student GetStudentById(int id)
        {
            return context.Students.FirstOrDefault(s => s.Id == id) ?? new Student();
        }
    }
}
