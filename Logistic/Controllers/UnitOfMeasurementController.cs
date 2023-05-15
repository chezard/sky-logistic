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
    public class UnitOfMeasurementController : Controller
    {
        private readonly AppDbContext _context;

        public UnitOfMeasurementController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var unitOfMeasurements=_context.UnitOfMeasurements.ToList();
            return View(unitOfMeasurements);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var unitOfMeasurement = _context.UnitOfMeasurements.FirstOrDefault(x => x.Id == id);

            if (unitOfMeasurement == null)
                return NotFound();

            return View(unitOfMeasurement);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UnitOfMeasurement unitOfMeasurement)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(unitOfMeasurement);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var unitOfMeasurement = _context.UnitOfMeasurements.FirstOrDefault(x => x.Id == id);
            return View(unitOfMeasurement);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, UnitOfMeasurement unitOfMeasurement)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != unitOfMeasurement.Id)
                return BadRequest();

            var dbUnitOfMeasurement = await _context.UnitOfMeasurements
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbUnitOfMeasurement == null)
                return NotFound();



            dbUnitOfMeasurement.Name = unitOfMeasurement.Name;
            dbUnitOfMeasurement.Date = unitOfMeasurement.Date;
            dbUnitOfMeasurement.Description = unitOfMeasurement.Description;

            _context.UpdateRange(dbUnitOfMeasurement);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var unitOfMeasurement = await _context.UnitOfMeasurements.FindAsync(id);


            if (unitOfMeasurement == null) return NotFound();

            _context.UnitOfMeasurements.Remove(unitOfMeasurement);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
