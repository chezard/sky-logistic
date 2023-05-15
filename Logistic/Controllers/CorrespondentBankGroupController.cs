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
    public class CorrespondentBankGroupController : Controller
    {
        private readonly AppDbContext _context;

        public CorrespondentBankGroupController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var correspondentBankGroups = _context.CorrespondentBankGroups.ToList();
            return View(correspondentBankGroups);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var correspondentBankGroup = _context.CorrespondentBankGroups.FirstOrDefault(x => x.Id == id);

            if (correspondentBankGroup == null)
                return NotFound();

            return View(correspondentBankGroup);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CorrespondentBankGroup correspondentBankGroup)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();


            await _context.AddRangeAsync(correspondentBankGroup);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var correspondentBankGroup = _context.CorrespondentBankGroups.FirstOrDefault(x => x.Id == id);
            return View(correspondentBankGroup);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CorrespondentBankGroup correspondentBankGroup)
        {

            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            if (id == null)
                return NotFound();

            if (id != correspondentBankGroup.Id)
                return BadRequest();

            var dbCorrespondentBankGroup = await _context.CorrespondentBankGroups
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbCorrespondentBankGroup == null)
                return NotFound();



            dbCorrespondentBankGroup.Name = correspondentBankGroup.Name;
            dbCorrespondentBankGroup.Date = correspondentBankGroup.Date;
            dbCorrespondentBankGroup.Description = correspondentBankGroup.Description;

            _context.UpdateRange(dbCorrespondentBankGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var correspondentBankGroup = await _context.CorrespondentBankGroups.FindAsync(id);
            var correspondentBank = await _context.CorrespondentBanks.Where(x => x.CorrespondentBankGroupId == id).ToListAsync();

            if (correspondentBankGroup == null) return NotFound();

            _context.CorrespondentBankGroups.Remove(correspondentBankGroup);
            foreach (var item in correspondentBank)
            {
                _context.CorrespondentBanks.Remove(item);

            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
