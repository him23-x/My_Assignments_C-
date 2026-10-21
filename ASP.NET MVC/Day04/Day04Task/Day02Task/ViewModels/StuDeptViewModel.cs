using Day02Task.Models;

namespace Day02Task.ViewModels
{
    public class StuDeptViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public List<Department> Departments { get; set; }
    }
}
