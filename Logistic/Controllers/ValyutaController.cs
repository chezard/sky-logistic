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
    public class ValyutaController : Controller
    {
        private readonly AppDbContext _context;

        public ValyutaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var valyutas=_context.Valyutas.ToList();
            return View(valyutas);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var valyuta = _context.Valyutas.FirstOrDefault(x => x.Id == id);

            if (valyuta == null)
                return NotFound();

            return View(valyuta);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Valyuta valyuta)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            await _context.AddRangeAsync(valyuta);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var valyuta = _context.Valyutas.FirstOrDefault(x => x.Id == id);
            return View(valyuta);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Valyuta valyuta)
        {

            //if (!ModelState.IsValid)
            //    return View();

            if (id == null)
                return NotFound();

            if (id != valyuta.Id)
                return BadRequest();

            var dbValyuta = await _context.Valyutas
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbValyuta == null)
                return NotFound();



            dbValyuta.Name = valyuta.Name;
            dbValyuta.Date = valyuta.Date;
            dbValyuta.Description = valyuta.Description;

            _context.UpdateRange(dbValyuta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var valyuta = await _context.Valyutas.FindAsync(id);


            if (valyuta == null) return NotFound();

            _context.Valyutas.Remove(valyuta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
