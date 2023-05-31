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
    public class StatusOfShipmentController : Controller
    {
        private readonly AppDbContext _context;

        public StatusOfShipmentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var statusOfShipments=_context.StatusOfShipments.ToList();
            return View(statusOfShipments);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var statusOfShipment = _context.StatusOfShipments.FirstOrDefault(x => x.Id == id);

            if (statusOfShipment == null)
                return NotFound();

            return View(statusOfShipment);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StatusOfShipment statusOfShipment)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(statusOfShipment);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var statusOfShipment = _context.StatusOfShipments.FirstOrDefault(x => x.Id == id);
            return View(statusOfShipment);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, StatusOfShipment statusOfShipment)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != statusOfShipment.Id)
                return BadRequest();

            var dbStatusOfShipment = await _context.StatusOfShipments
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbStatusOfShipment == null)
                return NotFound();



            dbStatusOfShipment.Name = statusOfShipment.Name;
            dbStatusOfShipment.Date = statusOfShipment.Date;
            dbStatusOfShipment.Description = statusOfShipment.Description;

            _context.UpdateRange(dbStatusOfShipment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var statusOfShipment = await _context.StatusOfShipments.FindAsync(id);


            if (statusOfShipment == null) return NotFound();

            _context.StatusOfShipments.Remove(statusOfShipment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateList()
        {
            return Json(_context.StatusOfShipments.ToList());
        }
    }
}
