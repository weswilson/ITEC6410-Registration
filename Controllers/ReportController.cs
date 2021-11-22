using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Data;

namespace Registration.Controllers
{
    public class ReportController : Controller
    {
        private readonly RegistrationContext _context;

        public ReportController(RegistrationContext context)
        {
            _context = context;
        }

        [Authorize(Policy = "Staff")]
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Course
                .Include(c => c.Department)
                .Include(c => c.Students)
                .ToListAsync();

            courses = courses.OrderBy(c => c.FullCourseNumber()).ToList();
            
            return View(courses);
        }
    }
}
