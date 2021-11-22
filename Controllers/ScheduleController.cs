using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Models;
using Registration.Data;
using Microsoft.AspNetCore.Authorization;

namespace Registration.Controllers
{
    public class ScheduleController : Controller
    {

        private readonly RegistrationContext _context;

        public ScheduleController(RegistrationContext context)
        {
            _context = context;
        }

        /// Update to following below
        public async Task<IActionResult> Index()
        {
            var roleId = Int32.Parse(User.FindFirst("RoleId").Value);

            var student = await _context.Student
                .Include(s => s.Courses)
                .ThenInclude(c => c.Department)
                .FirstOrDefaultAsync(s => s.StudentId == roleId);

            if (student == null)
            {
                return NotFound();
            }

            student.Courses = student.Courses.OrderBy(c => c.FullCourseNumber()).ToList();

            return View(student);
        }

        [Authorize(Policy = "Student")]
        public async Task<IActionResult> Add(int? id)
        {
            var roleId = Int32.Parse(User.FindFirst("RoleId").Value);

            var student = await _context.Student
                .Include(s => s.Courses)
                .FirstOrDefaultAsync(s => s.StudentId == roleId);

            if (student == null)
            {
                return NotFound();
            }

            if (!student.Courses.Any(c => c.CourseId == id))
            {
                var course = _context.Course.Find(id);
                student.Courses.Add(course);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Schedule");
        }

        [Authorize(Policy = "Student")]
        public async Task<IActionResult> Drop(int? id)
        {
            var roleId = Int32.Parse(User.FindFirst("RoleId").Value);

            var student = await _context.Student
                .Include(s => s.Courses)
                .FirstOrDefaultAsync(s => s.StudentId == roleId);

            if (student == null)
            {
                return NotFound();
            }

            if (student.Courses.Any(c => c.CourseId == id))
            {
                var course = _context.Course.Find(id);
                student.Courses.Remove(course);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Schedule");
        }
    }
}
