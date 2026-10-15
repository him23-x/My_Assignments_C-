using Day02Task.Models;

namespace Day02Task.ViewModels
{
    public class DepartmentWithExtraInfo
    {
        public string DeptName { get; set; }
        public int Experience { get; set; }
        public List<Student> Students { get; set; }
    }
}
