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
    public class BankGroupController : Controller
    {
        private readonly AppDbContext _context;

        public BankGroupController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bankGroups=_context.BankGroups.ToList();
            return View(bankGroups);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var bankGroup = _context.BankGroups.FirstOrDefault(x => x.Id == id);

            if (bankGroup == null)
                return NotFound();

            return View(bankGroup);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BankGroup bankGroup)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();


            await _context.AddRangeAsync(bankGroup);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var bankGroup = _context.BankGroups.FirstOrDefault(x => x.Id == id);
            return View(bankGroup);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, BankGroup bankGroup)
        {

            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            if (id == null)
                return NotFound();

            if (id != bankGroup.Id)
                return BadRequest();

            var dbBankGroup = await _context.BankGroups
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbBankGroup == null)
                return NotFound();



            dbBankGroup.Name = bankGroup.Name;
            dbBankGroup.Date = bankGroup.Date;
            dbBankGroup.Description = bankGroup.Description;

            _context.UpdateRange(dbBankGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var bankGroup = await _context.BankGroups.FindAsync(id);
            var bank=await _context.Banks.Where(x=>x.BankGroupId==id).ToListAsync();

            if (bankGroup == null) return NotFound();

            _context.BankGroups.Remove(bankGroup);
            foreach (var item in bank)
            {
                _context.Banks.Remove(item);

            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult UpdateList()
        {
            var list = _context.BankGroups.ToList();

            return Json(list);
        }
    }
}
