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
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var positions = _context.Positions.ToList();
            return View(positions);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var position = _context.Positions.FirstOrDefault(x => x.Id == id);

            if (position == null)
                return NotFound();

            return View(position);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Position position)
        {
            

            await _context.AddRangeAsync(position);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
            

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var position = _context.Positions.FirstOrDefault(x => x.Id == id);
            return View(position);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Position position)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != position.Id)
                return BadRequest();

            var dbPosition = await _context.Positions
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbPosition == null)
                return NotFound();



            dbPosition.Name = position.Name;
            dbPosition.Date = position.Date;
            dbPosition.Description = position.Description;

            _context.UpdateRange(dbPosition);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var position = await _context.Positions.FindAsync(id);


            if (position == null) return NotFound();

            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
