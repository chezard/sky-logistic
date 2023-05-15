using Logistic.DAL;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class CorrespondentBankController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CorrespondentBankController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var correspondentBanks = _context.CorrespondentBanks.ToList();
            return View( correspondentBanks);

        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var correspondentBank = _context.CorrespondentBanks.Include(x => x.CorrespondentBankGroup).FirstOrDefault(x => x.Id == id);

            if (correspondentBank == null)
                return NotFound();

            return View(correspondentBank);
        }

        public async Task<IActionResult> Create()
        {
            var correspondentBankGroups = await _context.CorrespondentBankGroups.ToListAsync();
            ViewBag.CorrespondentBankGroups = correspondentBankGroups;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CorrespondentBank correspondentBank, int? correspondentBankGroupId)
        {
            var correspondentBankGroups = await _context.CorrespondentBankGroups.ToListAsync();
            ViewBag.CorrespondentBankGroups = correspondentBankGroups;

            //if (!ModelState.IsValid)
            //  return View();


            //if (bank.File == null)
            //{
            //    ModelState.AddModelError("File", "Select pdf.");
            //    return View();
            //}
            if (correspondentBankGroupId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bank növünü qeyd edin");
                return View();
            }
            if (correspondentBank.File != null)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + correspondentBank.File.FileName;
                correspondentBank.FileName = fileName;
                var filePath = Path.Combine(_env.WebRootPath, "files\\" + fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    correspondentBank.File.CopyTo(stream);
                }
            }


            correspondentBank.CorrespondentBankGroupId = (int)correspondentBankGroupId;

            await _context.CorrespondentBanks.AddAsync(correspondentBank);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Update(int? id)
        {
            var correspondentBankGroups = await _context.CorrespondentBankGroups.ToListAsync();
            ViewBag.CorrespondentBankGroups = correspondentBankGroups;

            if (id == null)
                return NotFound();

            var correspondetBank = await _context.CorrespondentBanks.FirstOrDefaultAsync(x => x.Id == id);

            if (correspondetBank == null)
                return NotFound();
            return View(correspondetBank);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CorrespondentBank correspondentBank, int? correspondentBankGroupId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

            if (correspondentBankGroupId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bank növünü qeyd edin");
                return View();
            }

            var dbCorrespondentBank = await _context.CorrespondentBanks.FirstOrDefaultAsync(x => x.Id == id);
            if (dbCorrespondentBank == null)
                return NotFound();



            if (correspondentBank.File != null)
            {
                if (dbCorrespondentBank.File != null)
                {
                    var path = Path.Combine(_env.WebRootPath, "files", dbCorrespondentBank.FileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }

                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + correspondentBank.File.FileName;

                var iconSPath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                using (FileStream stream = new FileStream(iconSPath, FileMode.Create))
                {
                    correspondentBank.File.CopyTo(stream);

                }

                dbCorrespondentBank.FileName = fileName;
            }

            dbCorrespondentBank.Name = correspondentBank.Name;
            dbCorrespondentBank.Swift = correspondentBank.Swift;
            dbCorrespondentBank.MH = correspondentBank.MH;
            dbCorrespondentBank.Description = correspondentBank.Description;


            dbCorrespondentBank.CorrespondentBankGroupId = (int)correspondentBankGroupId;

            _context.UpdateRange(dbCorrespondentBank);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var CorrespondentBank = await _context.CorrespondentBanks.FindAsync(id);
            if (CorrespondentBank == null) return NotFound();
            if (CorrespondentBank.FileName != null)
            {
                var path = Path.Combine(_env.WebRootPath, "files", CorrespondentBank.FileName);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
           
            _context.CorrespondentBanks.Remove(CorrespondentBank);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
