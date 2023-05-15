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
    public class ExpenseTypeController : Controller
    {
        private readonly AppDbContext _context;

        public ExpenseTypeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var expenseTypes=_context.ExpenseTypes.ToList();   
            return View(expenseTypes);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var expenseType = _context.ExpenseTypes.FirstOrDefault(x => x.Id == id);

            if (expenseType == null)
                return NotFound();

            return View(expenseType);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpenseType expenseType)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(expenseType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var expenseType = _context.ExpenseTypes.FirstOrDefault(x => x.Id == id);
            return View(expenseType);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ExpenseType expenseType)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != expenseType.Id)
                return BadRequest();

            var dbExpenseType = await _context.ExpenseTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbExpenseType == null)
                return NotFound();



            dbExpenseType.Name = expenseType.Name;
            dbExpenseType.Date = expenseType.Date;
            dbExpenseType.Description = expenseType.Description;

            _context.UpdateRange(dbExpenseType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var expenseType = await _context.ExpenseTypes.FindAsync(id);


            if (expenseType == null) return NotFound();

            _context.ExpenseTypes.Remove(expenseType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
