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

        public void AddNewStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void SaveInDB()
        {
            context.SaveChanges();
        }
        public void Delete(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
