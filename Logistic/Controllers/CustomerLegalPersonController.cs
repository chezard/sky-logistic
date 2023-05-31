using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Logistic.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Principal;

namespace Logistic.Controllers
{
    [Authorize]
    public class CustomerLegalPersonController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CustomerLegalPersonController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var customerLegalPeople = _context.CustomerLegalPeople.Include(x => x.CustomerType)
                .OrderByDescending(x => x.Id).ToList();
            return View(customerLegalPeople);
        }


        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var customerLegalPerson = _context.CustomerLegalPeople.Include(x => x.Bank).Include(x => x.CustomerType)
                .FirstOrDefault(x => x.Id == id);

            var customerLegalPersonTable = _context.CustomerLegalPersonTables.Where(x => x.CustomerLegalPersonId == id)
                .Include(x => x.CustomerLegalPerson).Include(x => x.ContractType)
                .Include(y => y.Valyuta).ToList();

            if (customerLegalPerson == null)
                return NotFound();

            var customerVM = new CustomerVM
            {
                CustomerLegalPerson = customerLegalPerson,
                CustomerLegalPersonTables = customerLegalPersonTable
            };

            return View(customerVM);
        }

        public async Task<IActionResult> Create()
        {
            var customerTypes = await _context.CustomerTypes.ToListAsync();
            ViewBag.CustomerTypes = customerTypes;
            var banks = await _context.Banks.ToListAsync();
            ViewBag.Banks = banks;


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerLegalPerson customerLegalPerson, int? customerTypeId,
            int? bankId)
        {
            var customerTypes = await _context.CustomerTypes.ToListAsync();
            ViewBag.CustomerTypes = customerTypes;
            var banks = await _context.Banks.ToListAsync();
            ViewBag.Banks = banks;


            //if (!ModelState.IsValid)
            //  return View();


            //if (customerLegalPerson.File == null)
            //{
            //    ModelState.AddModelError("File", "Select pdf.");
            //    return View();
            //}
            if (bankId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Bank qeyd edin");
                return View();
            }

            if (customerTypeId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Muteri növünü qeyd edin");
                return View();
            }

            if (customerLegalPerson.File != null)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + customerLegalPerson.File.FileName;
                customerLegalPerson.FileName = fileName;
                var filePath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                customerLegalPerson.BankId = (int)bankId;
                customerLegalPerson.CustomerTypeId = (int)customerTypeId;
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    customerLegalPerson.File.CopyTo(stream);
                }
            }

            await _context.CustomerLegalPeople.AddAsync(customerLegalPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int? id)
        {
            var customerTypes = await _context.CustomerTypes.ToListAsync();
            ViewBag.CustomerTypes = customerTypes;
            var banks = await _context.Banks.ToListAsync();
            ViewBag.Banks = banks;

            var correspondetnBanks = await _context.CorrespondentBanks.ToListAsync();
            ViewBag.CorrespondentBanks = correspondetnBanks;


            if (id == null)
                return NotFound();

            var customerLegalPerson = await _context.CustomerLegalPeople.FirstOrDefaultAsync(x => x.Id == id);

            if (customerLegalPerson == null)
                return NotFound();
            return View(customerLegalPerson);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CustomerLegalPerson customerLegalPerson, int? customerTypeId,
            int? bankId, int? correspondentBankId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

            if (bankId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Bank qeyd edin");
                return View();
            }

            if (customerTypeId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Musteri növünü qeyd edin");
                return View();
            }

            var dbCustomerLegalPerson = await _context.CustomerLegalPeople.FirstOrDefaultAsync(x => x.Id == id);
            if (dbCustomerLegalPerson == null)
                return NotFound();

            if (customerLegalPerson.File != null)
            {
                if (dbCustomerLegalPerson.File != null)
                {
                    var path = Path.Combine(_env.WebRootPath, "files", dbCustomerLegalPerson.FileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }

                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + customerLegalPerson.File.FileName;
                var iconSPath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                using (FileStream stream = new FileStream(iconSPath, FileMode.Create))
                {
                    customerLegalPerson.File.CopyTo(stream);
                }

                dbCustomerLegalPerson.FileName = fileName;
            }

            dbCustomerLegalPerson.Name = customerLegalPerson.Name;
            dbCustomerLegalPerson.Manager = customerLegalPerson.Manager;
            dbCustomerLegalPerson.Voen = customerLegalPerson.Voen;
            dbCustomerLegalPerson.Phone = customerLegalPerson.Phone;
            dbCustomerLegalPerson.Mail = customerLegalPerson.Mail;
            dbCustomerLegalPerson.HH1 = customerLegalPerson.HH1;
            dbCustomerLegalPerson.HH2 = customerLegalPerson.HH2;
            dbCustomerLegalPerson.HH3 = customerLegalPerson.HH3;
            dbCustomerLegalPerson.HH4 = customerLegalPerson.HH4;
            dbCustomerLegalPerson.Description = customerLegalPerson.Description;

            dbCustomerLegalPerson.BankId = (int)bankId;
            dbCustomerLegalPerson.CustomerTypeId = (int)customerTypeId;

            _context.UpdateRange(dbCustomerLegalPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var customerLegalPerson = await _context.CustomerLegalPeople.FindAsync(id);
            var customerLegalPersonTables = await _context.CustomerLegalPersonTables
                .Where(x => x.CustomerLegalPersonId == id).ToListAsync();

            if (customerLegalPerson == null) return NotFound();

            if (customerLegalPerson.FileName != null)
            {
                var path = Path.Combine(_env.WebRootPath, "files", customerLegalPerson.FileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }


            _context.CustomerLegalPeople.Remove(customerLegalPerson);
            foreach (var item in customerLegalPersonTables)
            {
                _context.CustomerLegalPersonTables.Remove(item);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateList()
        {
            return Json(_context.CustomerLegalPeople.ToList());
        }
    }
}