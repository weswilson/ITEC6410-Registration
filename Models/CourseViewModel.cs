using Microsoft.AspNetCore.Mvc.Rendering;

namespace Registration.Models
{
    public class CourseViewModel
    {
        public Course? Course { get; set; }
        public List<SelectListItem> Departments { get; set; }
    }
}