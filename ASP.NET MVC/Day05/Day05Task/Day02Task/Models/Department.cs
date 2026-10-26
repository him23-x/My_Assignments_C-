using System.ComponentModel.DataAnnotations;

namespace Day02Task.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Department name must be between 2 and 100 characters.")]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        [Display(Name = "Manager Name")]
        [StringLength(100, ErrorMessage = "Manager name cannot exceed 100 characters.")]
        public string? MgrName { get; set; }

        public List<Student>? Students { get; set; }
        public List<Course>? Courses { get; set; }
        public List<Teacher>? Teachers { get; set; }
    }
}
