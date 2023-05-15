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
    public class ConditionOfCarriageController : Controller
    {
        private readonly AppDbContext _context;

        public ConditionOfCarriageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var conditionOfCarriages =_context.ConditionOfCarriages.ToList();
            return View(conditionOfCarriages);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var conditionOfCarriage = _context.ConditionOfCarriages.FirstOrDefault(x => x.Id == id);

            if (conditionOfCarriage == null)
                return NotFound();

            return View(conditionOfCarriage);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ConditionOfCarriage conditionOfCarriage)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(conditionOfCarriage);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var conditionOfCarriage = _context.ConditionOfCarriages.FirstOrDefault(x => x.Id == id);
            return View(conditionOfCarriage);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ConditionOfCarriage conditionOfCarriage)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != conditionOfCarriage.Id)
                return BadRequest();

            var dbConditionOfCarriage = await _context.ConditionOfCarriages
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbConditionOfCarriage == null)
                return NotFound();



            dbConditionOfCarriage.Name = conditionOfCarriage.Name;
            dbConditionOfCarriage.Date = conditionOfCarriage.Date;
            dbConditionOfCarriage.Description = conditionOfCarriage.Description;

            _context.UpdateRange(dbConditionOfCarriage);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var conditionOfCarriage = await _context.ConditionOfCarriages.FindAsync(id);


            if (conditionOfCarriage == null) return NotFound();

            _context.ConditionOfCarriages.Remove(conditionOfCarriage);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
