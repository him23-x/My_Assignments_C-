using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day02Task.ViewModels
{
    public class CourseDeptViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Course name must be between 2 and 50 characters.")]
        [Display(Name = "Course Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Degree is required.")]
        [Range(1, 500, ErrorMessage = "Degree must be between 1 and 500.")]
        [Display(Name = "Full Degree")]
        public int Degree { get; set; }

        [Range(0, 500, ErrorMessage = "Minimum degree must be between 0 and 500.")]
        [Display(Name = "Minimum Degree")]
        public int? MinDegree { get; set; }

        [Required(ErrorMessage = "Please select a department.")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public List<SelectListItem>? DepartmentList { get; set; }
    }
}
