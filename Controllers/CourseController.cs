using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Models;
using Registration.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Registration.Controllers
{
    public class CourseController : Controller
    {
        private readonly RegistrationContext _context;

        public CourseController(RegistrationContext context)
        {
            _context = context;
        }

        // GET: Course
        public async Task<IActionResult> Index()
        {
            return View(await _context.Course.Include(course => course.Department).ToListAsync());
        }

        // GET: Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            var courseViewModel = new CourseViewModel()
            {
                Departments = DepartmentsToSelectListItems()
            };

            return View(courseViewModel);
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[Bind("CourseId,Name,Description,")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Course course)
        {
            if (course.DepartmentId != 0)
            {
                var department = _context.Department.Find(course.DepartmentId);
                
                if (department != null)
                {
                    course.Department = department;
                    ModelState.ClearValidationState(nameof(course));
                    TryValidateModel(course, nameof(course));
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(course);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var courseViewModel = new CourseViewModel()
            {
                Course = course,
                Departments = DepartmentsToSelectListItems()
            };
            
            return View(courseViewModel);
        }

        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);

            _context.Entry(course)
                .Reference(c => c.Department)
                .Load();

            if (course == null)
            {
                return NotFound();
            }
            var courseViewModel = new CourseViewModel()
            {
                Course = course,
                Departments = DepartmentsToSelectListItems()
            };

            return View(courseViewModel);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            if (course.DepartmentId != 0)
            {
                var department = _context.Department.Find(course.DepartmentId);

                if (department != null)
                {
                    course.Department = department;
                    ModelState.ClearValidationState(nameof(course));
                    TryValidateModel(course, nameof(course));
                }
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            var courseViewModel = new CourseViewModel()
            {
                Course = course,
                Departments = DepartmentsToSelectListItems()
            };

            return View(courseViewModel);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Course.FindAsync(id);
            _context.Course.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.CourseId == id);
        }

        private List<SelectListItem> DepartmentsToSelectListItems()
        {
            var departments = _context.Department.ToList();

            return departments.Select(x => new SelectListItem(x.Name, x.DepartmentId.ToString())).ToList();
        }
    }
}
