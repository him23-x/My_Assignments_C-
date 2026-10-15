using Day02Task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Day02Task.Models.BusinessLogic
{
    public class DepartmentBL
    {
        SystemDbContext context = new SystemDbContext();

        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }


        public Department GetDepartmentById(int id)
        {
            return context.Departments?.Include(d=>d.Students).FirstOrDefault(d => d.Id == id);
        }

        public void AddDept(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }
    }
}
