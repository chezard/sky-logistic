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
    public class PersonnelTypeController : Controller
    {
        private readonly AppDbContext _context;

        public PersonnelTypeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var personnelTypes=_context.PersonnelTypes.ToList();
            return View(personnelTypes);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var personnelType = _context.PersonnelTypes.FirstOrDefault(x => x.Id == id);

            if (personnelType == null)
                return NotFound();

            return View(personnelType);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PersonnelType personnelType)
        {
            

            await _context.AddRangeAsync(personnelType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var personnelType = _context.PersonnelTypes.FirstOrDefault(x => x.Id == id);
            return View(personnelType);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, PersonnelType personnelType)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != personnelType.Id)
                return BadRequest();

            var dbPersonnelType = await _context.PersonnelTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbPersonnelType == null)
                return NotFound();



            dbPersonnelType.Name = personnelType.Name;
            dbPersonnelType.Code = personnelType.Code;
            dbPersonnelType.Date = personnelType.Date;
            dbPersonnelType.Description = personnelType.Description;

            _context.UpdateRange(dbPersonnelType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var personnelType = await _context.PersonnelTypes.FindAsync(id);


            if (personnelType == null) return NotFound();

            _context.PersonnelTypes.Remove(personnelType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
