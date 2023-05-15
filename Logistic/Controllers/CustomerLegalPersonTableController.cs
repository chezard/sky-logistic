using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class CustomerLegalPersonTableController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerLegalPersonTableController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customerLegalPersonTables = _context.CustomerLegalPersonTables.Include(x => x.CustomerLegalPerson).Include(x => x.ContractType).Include(y => y.Valyuta).ToList();
            return View(customerLegalPersonTables);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var customerLegalPersonTable = _context.CustomerLegalPersonTables.Include(x => x.CustomerLegalPerson).Include(x => x.ContractType).Include(y => y.Valyuta).FirstOrDefault(x => x.Id == id);

            if (customerLegalPersonTable == null)
                return NotFound();

            return View(customerLegalPersonTable);
        }

        //[HttpGet("[controller]/[action]/{CustomerLegalPersonId?}")]
        public async Task<IActionResult> Create(int? customerLegalPersonId)
        {
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            var contractTypes = await _context.ContractTypes.ToListAsync();
            ViewBag.ContractTypes = contractTypes;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            ViewBag.cID = customerLegalPersonId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerLegalPersonTable customerLegalPersonTable)
        {
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            var contractTypes = await _context.ContractTypes.ToListAsync();
            ViewBag.ContractTypes = contractTypes;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;

            //if (!ModelState.IsValid)
            //  return View();

            if (customerLegalPersonTable.CustomerLegalPersonId == 0)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Müştərilər Hüquqi Şəxs qeyd edin");
                return View();
            }
            if (customerLegalPersonTable.ContractTypeId == 0)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Müqavilə növü qeyd edin");
                return View();
            }
            if (customerLegalPersonTable.ValyutaId == 0)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Valyuta qeyd edin");
                return View();
            }

            await _context.CustomerLegalPersonTables.AddAsync(customerLegalPersonTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Detail", "CustomerLegalPerson", new { id = customerLegalPersonTable.CustomerLegalPersonId });

        }


        public async Task<IActionResult> Update(int? id)
        {
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            var contractTypes = await _context.ContractTypes.ToListAsync();
            ViewBag.ContractTypes = contractTypes;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;

            if (id == null)
                return NotFound();

            var customerLegalPersonTable = await _context.CustomerLegalPersonTables.FirstOrDefaultAsync(x => x.Id == id);

            if (customerLegalPersonTable == null)
                return NotFound();
            return View(customerLegalPersonTable);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CustomerLegalPersonTable customerLegalPersonTable, int? customerLegalPersonId, int? contractTypeId, int? valyutaId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();
            if (customerLegalPersonId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Müştərilər Hüquqi Şəxs qeyd edin");
                return View();
            }
            if (contractTypeId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Müqavilə növü qeyd edin");
                return View();
            }
            if (valyutaId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Valyuta qeyd edin");
                return View();
            }

            var dbCustomerLegalPersonTable = await _context.CustomerLegalPersonTables.FirstOrDefaultAsync(x => x.Id == id);
            if (dbCustomerLegalPersonTable == null)
                return NotFound();



            dbCustomerLegalPersonTable.Date = customerLegalPersonTable.Date;
            dbCustomerLegalPersonTable.Description = customerLegalPersonTable.Description;

            dbCustomerLegalPersonTable.CustomerLegalPersonId = (int)customerLegalPersonId;
            dbCustomerLegalPersonTable.ContractTypeId = (int)contractTypeId;
            dbCustomerLegalPersonTable.ValyutaId = (int)valyutaId;

            _context.UpdateRange(dbCustomerLegalPersonTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "CustomerLegalPerson", new { id = customerLegalPersonId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var customerLegalPersonTable = await _context.CustomerLegalPersonTables.FindAsync(id);

            if (customerLegalPersonTable == null) return NotFound();
            var cusId = customerLegalPersonTable.CustomerLegalPersonId;

            _context.CustomerLegalPersonTables.Remove(customerLegalPersonTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail","CustomerLegalPerson", new { id = cusId });
        }
    }
}
