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
    public class CountController : Controller
    {
        private readonly AppDbContext _context;

        public CountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var accounts=_context.Accounts.ToList();
            return View(accounts);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var account = _context.Accounts.FirstOrDefault(x => x.Id == id);

            if (account == null)
                return NotFound();

            return View(account);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Account account)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(account);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var account = _context.Accounts.FirstOrDefault(x => x.Id == id);
            return View(account);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Account account)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != account.Id)
                return BadRequest();

            var dbAccount = await _context.Accounts
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbAccount == null)
                return NotFound();



            dbAccount.Name = account.Name;
            dbAccount.TopGroup = account.TopGroup;
            dbAccount.Date = account.Date;
            dbAccount.Description = account.Description;

            _context.UpdateRange(dbAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var account = await _context.Accounts.FindAsync(id);


            if (account == null) return NotFound();

            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
