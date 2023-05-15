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
    public class EnterpriseTypeController : Controller
    {
        private readonly AppDbContext _context;

        public EnterpriseTypeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var enterpriseTypes=_context.EnterpriseTypes.ToList();
            return View(enterpriseTypes);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var enterpriseType = _context.EnterpriseTypes.FirstOrDefault(x => x.Id == id);

            if (enterpriseType == null)
                return NotFound();

            return View(enterpriseType);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EnterpriseType enterpriseType)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(enterpriseType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var enterpriseType = _context.EnterpriseTypes.FirstOrDefault(x => x.Id == id);
            return View(enterpriseType);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, EnterpriseType enterpriseType)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != enterpriseType.Id)
                return BadRequest();

            var dbEnterpriseType = await _context.EnterpriseTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbEnterpriseType == null)
                return NotFound();



            dbEnterpriseType.Name = enterpriseType.Name;
            dbEnterpriseType.Date = enterpriseType.Date;
            dbEnterpriseType.Description = enterpriseType.Description;

            _context.UpdateRange(dbEnterpriseType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var enterpriseType = await _context.EnterpriseTypes.FindAsync(id);


            if (enterpriseType == null) return NotFound();

            _context.EnterpriseTypes.Remove(enterpriseType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
