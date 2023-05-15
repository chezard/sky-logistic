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
    public class PaymentTypeController : Controller
    {
        private readonly AppDbContext _context;

        public PaymentTypeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var paymentTypes=_context.PaymentTypes.ToList();
            return View(paymentTypes);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var paymentType = _context.PaymentTypes.FirstOrDefault(x => x.Id == id);

            if (paymentType == null)
                return NotFound();

            return View(paymentType);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentType paymentType)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(paymentType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var paymentType = _context.PaymentTypes.FirstOrDefault(x => x.Id == id);
            return View(paymentType);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, PaymentType paymentType)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != paymentType.Id)
                return BadRequest();

            var dbPaymentType = await _context.PaymentTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbPaymentType == null)
                return NotFound();



            dbPaymentType.Name = paymentType.Name;
            dbPaymentType.Date = paymentType.Date;
            dbPaymentType.Description = paymentType.Description;

            _context.UpdateRange(dbPaymentType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var paymentType = await _context.PaymentTypes.FindAsync(id);


            if (paymentType == null) return NotFound();

            _context.PaymentTypes.Remove(paymentType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
