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
    public class PaymentStatusController : Controller
    {
        private readonly AppDbContext _context;

        public PaymentStatusController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var paymentStatuses=_context.PaymentStatuses.ToList();
            return View(paymentStatuses);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var paymentStatus = _context.PaymentStatuses.FirstOrDefault(x => x.Id == id);

            if (paymentStatus == null)
                return NotFound();

            return View(paymentStatus);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentStatus paymentStatus)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(paymentStatus);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var paymentStatus = _context.PaymentStatuses.FirstOrDefault(x => x.Id == id);
            return View(paymentStatus);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, PaymentStatus paymentStatus)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != paymentStatus.Id)
                return BadRequest();

            var dbPaymentStatus =await  _context.PaymentStatuses
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbPaymentStatus == null)
                return NotFound();


            
            dbPaymentStatus.Name = paymentStatus.Name;
            dbPaymentStatus.Date = paymentStatus.Date;
            dbPaymentStatus.Description = paymentStatus.Description;

            _context.UpdateRange(dbPaymentStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var paymentStatus = await _context.PaymentStatuses.FindAsync(id);


            if (paymentStatus == null) return NotFound();

            _context.PaymentStatuses.Remove(paymentStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
