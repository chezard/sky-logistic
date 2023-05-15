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
    public class CustomerTypeController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerTypeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customerTypes=_context.CustomerTypes.ToList();
            return View(customerTypes);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var customerType = _context.CustomerTypes.FirstOrDefault(x => x.Id == id);

            if (customerType == null)
                return NotFound();

            return View(customerType);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerType customerType)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(customerType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var customerType = _context.CustomerTypes.FirstOrDefault(x => x.Id == id);
            return View(customerType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CustomerType customerType)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != customerType.Id)
                return BadRequest();

            var dbCustomerType = await _context.CustomerTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbCustomerType == null)
                return NotFound();



            dbCustomerType.Type = customerType.Type;
            dbCustomerType.Date = customerType.Date;
            dbCustomerType.Description = customerType.Description;

            _context.UpdateRange(dbCustomerType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var customerType = await _context.CustomerTypes.FindAsync(id);


            if (customerType == null) return NotFound();

            _context.CustomerTypes.Remove(customerType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
