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
    public class TypeOfActivityController : Controller
    {
        private readonly AppDbContext _context;

        public TypeOfActivityController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var typeOfActivities=_context.TypeOfActivities.ToList();
            return View(typeOfActivities);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var typeOfActivity = _context.TypeOfActivities.FirstOrDefault(x => x.Id == id);

            if (typeOfActivity == null)
                return NotFound();

            return View(typeOfActivity);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypeOfActivity typeOfActivity)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            await _context.AddRangeAsync(typeOfActivity);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var typeOfActivity = _context.TypeOfActivities.FirstOrDefault(x => x.Id == id);
            return View(typeOfActivity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TypeOfActivity typeOfActivity)
        {

            //if (!ModelState.IsValid)
            //    return View();

            if (id == null)
                return NotFound();

            if (id != typeOfActivity.Id)
                return BadRequest();

            var dbTypeOfActivity = await _context.TypeOfActivities
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbTypeOfActivity == null)
                return NotFound();



            dbTypeOfActivity.Name = typeOfActivity.Name;
            dbTypeOfActivity.Date = typeOfActivity.Date;
            dbTypeOfActivity.Description = typeOfActivity.Description;

            _context.UpdateRange(dbTypeOfActivity);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var typeOfActivity = await _context.TypeOfActivities.FindAsync(id);


            if (typeOfActivity == null) return NotFound();

            _context.TypeOfActivities.Remove(typeOfActivity);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
