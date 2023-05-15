using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security;

namespace Logistic.Controllers
{
    [Authorize]
    public class BankController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BankController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var banks=_context.Banks.ToList();
            return View(banks);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var bank = _context.Banks.Include(x => x.BankGroup).FirstOrDefault(x => x.Id == id);

            if (bank == null)
                return NotFound();

            return View(bank);
        }

        public async Task<IActionResult> Create()
        {
            var bankGroups = await _context.BankGroups.ToListAsync();
            ViewBag.BankGroups = bankGroups;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bank bank, int? bankGroupId)
        {
            var bankGroups = await _context.BankGroups.ToListAsync();
            ViewBag.BankGroups = bankGroups;

            //if (!ModelState.IsValid)
            //  return View();


            //if (bank.File == null)
            //{
            //    ModelState.AddModelError("File", "Select pdf.");
            //    return View();
            //}
            if (bankGroupId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bank növünü qeyd edin");
                return View();
            }
            if (bank.File != null)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + bank.File.FileName;
                bank.FileName = fileName;
                var filePath = Path.Combine(_env.WebRootPath, "files\\" + fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    bank.File.CopyTo(stream);
                }
            }
            

            bank.BankGroupId =(int) bankGroupId;

            await _context.Banks.AddAsync(bank);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Update(int? id)
        {
            var bankGroups = await _context.BankGroups.ToListAsync();
            ViewBag.BankGroups = bankGroups;

            if (id == null)
                return NotFound();

            var bank = await _context.Banks.FirstOrDefaultAsync(x => x.Id == id);

            if (bank == null)
                return NotFound();
            return View(bank);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Bank bank, int? bankGroupId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

            if (bankGroupId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bank növünü qeyd edin");
                return View();
            }

            var dbBank = await _context.Banks.FirstOrDefaultAsync(x => x.Id == id);
            if (dbBank == null)
                return NotFound();

            

            if (bank.File != null)
            {
                if (dbBank.File != null)
                {
                    var path = Path.Combine(_env.WebRootPath, "files", dbBank.FileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
                
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + bank.File.FileName;
                
                var iconSPath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                using (FileStream stream = new FileStream(iconSPath, FileMode.Create))
                {
                    bank.File.CopyTo(stream);

                }

                dbBank.FileName = fileName;
            }

            dbBank.Name = bank.Name;
            dbBank.Manager = bank.Manager;
            dbBank.Voen = bank.Voen;
            dbBank.Swift = bank.Swift;
            dbBank.Kod = bank.Kod;
            dbBank.MH = bank.MH;
            dbBank.Mail = bank.Mail;
            dbBank.Phone = bank.Phone;
            dbBank.Address = bank.Address;
            dbBank.Description = bank.Description;


            dbBank.BankGroupId = (int)bankGroupId;

            _context.UpdateRange(dbBank);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var bank = await _context.Banks.FindAsync(id);
            if (bank == null) return NotFound();

            var path = Path.Combine(_env.WebRootPath, "files", bank.FileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Banks.Remove(bank);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
        
        [HttpPost]
        public IActionResult UpdateList()
        {
            var list = _context.Banks.ToList();

            return Json(list);
        }
        
    }
}
