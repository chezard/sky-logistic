using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class DirectionOfTransportationController : Controller
    {
        private readonly AppDbContext _context;

        public DirectionOfTransportationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var directionOfTransportations=_context.DirectionOfTransportations.ToList();
            return View(directionOfTransportations);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var directionOfTransportation = _context.DirectionOfTransportations.FirstOrDefault(x => x.Id == id);

            if (directionOfTransportation == null)
                return NotFound();

            return View(directionOfTransportation);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DirectionOfTransportation directionOfTransportation)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(directionOfTransportation);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var directionOfTransportation = _context.DirectionOfTransportations.FirstOrDefault(x => x.Id == id);
            return View(directionOfTransportation);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, DirectionOfTransportation directionOfTransportation)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != directionOfTransportation.Id)
                return BadRequest();

            var dbDirectionOfTransportation = await _context.DirectionOfTransportations
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbDirectionOfTransportation == null)
                return NotFound();

            dbDirectionOfTransportation.Type = directionOfTransportation.Type;
            dbDirectionOfTransportation.Date = directionOfTransportation.Date;
            dbDirectionOfTransportation.Description = directionOfTransportation.Description;

            _context.UpdateRange(dbDirectionOfTransportation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var directionOfTransportation = await _context.DirectionOfTransportations.FindAsync(id);


            if (directionOfTransportation == null) return NotFound();

            _context.DirectionOfTransportations.Remove(directionOfTransportation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateList()
        {
            return Json(_context.DirectionOfTransportations.ToList());
        }
    }
}
