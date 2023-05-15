using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Logistic.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class InstitutionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public InstitutionController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var institutions = _context.Institutions.OrderByDescending(X => X.Id).ToList();
            return View(institutions);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var institution = _context.Institutions.Include(x => x.Bank).Include(x => x.EnterpriseType).FirstOrDefault(x => x.Id == id);


            if (institution == null)
                return NotFound();


            return View(institution);
        }

        public IActionResult Pdf(int? id)
        {
            if (id == null)
                return NotFound();

            var invoice = _context.Invoices.Include(x => x.InternalCompany).Include(x => x.Ekspeditor).ThenInclude(x => x.Bank).Include(x => x.Customer).ThenInclude(x => x.Bank).FirstOrDefault(x => x.Id == id);

            var invoiceTables = _context.InvoiceTables.Where(x => x.InvoiceId == id).Include(x => x.Invoice).ToList();


            if (invoice == null)
                return NotFound();

            var invoiceVM = new InvoiceVM
            {
                Invoice = invoice,
                InvoiceTables = invoiceTables,
            };

            return View(invoiceVM);
        }
        public async Task<IActionResult> Create()
        {
            var enterpriseTypes = await _context.EnterpriseTypes.ToListAsync();
            ViewBag.EnterpriseTypes = enterpriseTypes;
            var banks = await _context.Banks.ToListAsync();
            ViewBag.Banks = banks;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Institution institution, int? enterpriseTypeId, int? bankId)
        {
            var enterpriseTypes = await _context.EnterpriseTypes.ToListAsync();
            ViewBag.EnterpriseTypes = enterpriseTypes;
            var banks = await _context.Banks.ToListAsync();
            ViewBag.Banks = banks;

            //if (!ModelState.IsValid)
            //  return View();


            //if (institution.File == null)
            //{
            //    ModelState.AddModelError("File", "Select pdf.");
            //    return View();
            //}
            if (bankId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bank qeyd edin");
                return View();
            }


            if (institution.File != null)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + institution.File.FileName;
                institution.FileName = fileName;
                var filePath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                institution.EnterpriseTypeId = (int)enterpriseTypeId;
                //institution.BankId = (int)bankId;
                //institution.CorrespondentBank = (int)correspondetnBankId;

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    institution.File.CopyTo(stream);
                }
            }

            await _context.Institutions.AddAsync(institution);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Update(int? id)
        {
            var enterpriseTypes = await _context.EnterpriseTypes.ToListAsync();
            ViewBag.EnterpriseTypes = enterpriseTypes;
            var banks = await _context.Banks.ToListAsync();
            ViewBag.Banks = banks;

            if (id == null)
                return NotFound();

            var institution = await _context.Institutions.FirstOrDefaultAsync(x => x.Id == id);

            if (institution == null)
                return NotFound();
            return View(institution);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Institution institution, int? enterpriseTypeId, int? bankId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

            if (bankId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa bank qeyd edin");
                return View();
            }

            var dbInstitution = await _context.Institutions.FirstOrDefaultAsync(x => x.Id == id);
            if (dbInstitution == null)
                return NotFound();

            if (institution.File != null)
            {
                if (dbInstitution.File != null)
                {
                    var path = Path.Combine(_env.WebRootPath, "files", dbInstitution.FileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }

                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + institution.File.FileName;

                var iconSPath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                using (FileStream stream = new FileStream(iconSPath, FileMode.Create))
                {
                    institution.File.CopyTo(stream);

                }

                dbInstitution.FileName = fileName;
            }

            dbInstitution.Name = institution.Name;
            dbInstitution.Leader = institution.Leader;
            dbInstitution.Voen = institution.Voen;
            dbInstitution.LegalAddress = institution.LegalAddress;
            dbInstitution.PhysicalAddress = institution.PhysicalAddress;
            dbInstitution.Phone = institution.Phone;
            dbInstitution.Mail = institution.Mail;
            dbInstitution.Description = institution.Description;
            dbInstitution.HH1 = institution.HH1;
            dbInstitution.HH2 = institution.HH2;
            dbInstitution.HH3 = institution.HH3;
            dbInstitution.HH4 = institution.HH4;


            dbInstitution.EnterpriseTypeId = (int)enterpriseTypeId;
            dbInstitution.BankId = (int)bankId;

            _context.UpdateRange(dbInstitution);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var institution = await _context.Institutions.FindAsync(id);

            if (institution == null) return NotFound();

            if (institution.FileName != null)
            {
                var path = Path.Combine(_env.WebRootPath, "files", institution.FileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }

            _context.Institutions.Remove(institution);

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
