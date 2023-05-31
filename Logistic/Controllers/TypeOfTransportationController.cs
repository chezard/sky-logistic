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
    public class TypeOfTransportationController : Controller
    {
        private readonly AppDbContext _context;

        public TypeOfTransportationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var typeOfTransportations = _context.TypeOfTransportations.ToList();
            return View(typeOfTransportations);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var typeOfTransportation = _context.TypeOfTransportations.FirstOrDefault(x => x.Id == id);

            if (typeOfTransportation == null)
                return NotFound();

            return View(typeOfTransportation);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypeOfTransportation typeOfTransportation)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(typeOfTransportation);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var typeOfTransportation = _context.TypeOfTransportations.FirstOrDefault(x => x.Id == id);
            return View(typeOfTransportation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TypeOfTransportation typeOfTransportation)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != typeOfTransportation.Id)
                return BadRequest();

            var dbTypeOfTransportations = await _context.TypeOfTransportations
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbTypeOfTransportations == null)
                return NotFound();


            dbTypeOfTransportations.Name = typeOfTransportation.Name;
            dbTypeOfTransportations.Code = typeOfTransportation.Code;
            dbTypeOfTransportations.Date = typeOfTransportation.Date;
            dbTypeOfTransportations.Description = typeOfTransportation.Description;

            _context.UpdateRange(dbTypeOfTransportations);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var typeOfTransportation = await _context.TypeOfTransportations.FindAsync(id);


            if (typeOfTransportation == null) return NotFound();

            _context.TypeOfTransportations.Remove(typeOfTransportation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateList()
        {
            return Json(_context.TypeOfTransportations.ToList());
        }
    }
}