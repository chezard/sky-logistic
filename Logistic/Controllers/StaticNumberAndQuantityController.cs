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
    public class StaticNumberAndQuantityController : Controller
    {
        private readonly AppDbContext _context;

        public StaticNumberAndQuantityController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var staticNumberAndQuantities=_context.StaticNumberAndQuantities.ToList();
            return View(staticNumberAndQuantities);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var staticNumberAndQuantity = _context.StaticNumberAndQuantities.FirstOrDefault(x => x.Id == id);

            if (staticNumberAndQuantity == null)
                return NotFound();

            return View(staticNumberAndQuantity);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StaticNumberAndQuantity staticNumberAndQuantity)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(staticNumberAndQuantity);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var staticNumberAndQuantity = _context.StaticNumberAndQuantities.FirstOrDefault(x => x.Id == id);
            return View(staticNumberAndQuantity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, StaticNumberAndQuantity staticNumberAndQuantity)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != staticNumberAndQuantity.Id)
                return BadRequest();

            var dbStaticNumberAndQuantity = await _context.StaticNumberAndQuantities
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbStaticNumberAndQuantity == null)
                return NotFound();



            dbStaticNumberAndQuantity.Name = staticNumberAndQuantity.Name;
            dbStaticNumberAndQuantity.Date = staticNumberAndQuantity.Date;
            dbStaticNumberAndQuantity.Description = staticNumberAndQuantity.Description;

            _context.UpdateRange(dbStaticNumberAndQuantity);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var staticNumberAndQuantity = await _context.StaticNumberAndQuantities.FindAsync(id);


            if (staticNumberAndQuantity == null) return NotFound();

            _context.StaticNumberAndQuantities.Remove(staticNumberAndQuantity);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
