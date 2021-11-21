using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registration.Models;
using Registration.Data;

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
        public IActionResult Schedule()
        {
            return View();
        }

        //// GET: Schedule
        //public async Task<IActionResult> Schedule()
        //{
        //    return View(await _context.Schedule.ToListAsync());
        //}

        //// GET: Schedule/Details
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var schedule = await _context.Schedule
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (schedule == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(schedule);
        //}

        //// GET: Course/Drop
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var schedule = await _context.Schedule
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (schedule == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(schedule);
        //}

        //// POST: Course/Drop
        //[HttpPost, ActionName("Drop")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var schedule = await _context.Schedule.FindAsync(id);
        //    _context.Schedule.Remove(schedule);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool SceduleExists(int id)
        //{
        //    return _context.Schedule.Any(e => e.Id == id);
        //}

    }
}
