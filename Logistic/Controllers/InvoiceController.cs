using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Logistic.Utils;
using Logistic.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public InvoiceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var invoices = _context.Invoices.OrderByDescending(x => x.Id).ToList();
            return View(invoices);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var invoice = _context.Invoices.Include(x => x.InternalCompany).Include(x => x.Ekspeditor)
                .ThenInclude(x => x.Bank).Include(x => x.CorrespondentBankCustomer)
                .Include(x => x.CorrespondentBankExpeditor)
                .Include(x => x.Customer).ThenInclude(x => x.Bank).FirstOrDefault(x => x.Id == id);

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

        public IActionResult Pdf(int? id)
        {
            if (id == null)
                return NotFound();

            var invoice = _context.Invoices
                .Include(x => x.InternalCompany)
                .Include(x => x.Ekspeditor)
                .ThenInclude(x => x.Bank).Include(x => x.CorrespondentBankCustomer)
                .Include(x => x.CorrespondentBankExpeditor)
                .Include(x => x.Customer)
                .ThenInclude(x => x.Bank)
                .FirstOrDefault(x => x.Id == id);

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
            var institutions = await _context.Institutions
                .Where(x => x.EnterpriseTypeId == 1)
                .ToListAsync();
            ViewBag.Institutions = institutions;
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;
            var correspondetnBanks = await _context.CorrespondentBanks.ToListAsync();
            ViewBag.CorrespondentBanks = correspondetnBanks;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Invoice invoice, int? internalCompanyId, int? ekspeditorId,
            int? customerId, int? transportId, int? correspondetnBanksCustomer, int? correspondetnBanksExpeditor)
        {
            var institutions = await _context.Institutions.ToListAsync();
            ViewBag.Institutions = institutions;
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;

            var correspondetnBanks = await _context.CorrespondentBanks.ToListAsync();
            ViewBag.CorrespondentBanks = correspondetnBanks;
            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;

            if (!ModelState.IsValid)
                return NotFound();
            if (invoice.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo cannot be empty");
                return View();
            }

            if (invoice.StampPhoto == null)
            {
                ModelState.AddModelError("StampPhoto", "Stamp Photo cannot be empty");
                return View();
            }

            var fileName = await FileUtil.GenerateFileAsync(Constants.ImageFolderPath, invoice.Photo);
            invoice.Logo = fileName;

            var stampFileName = await FileUtil.GenerateFileAsync(Constants.ImageFolderPath, invoice.StampPhoto);
            invoice.Stamp = stampFileName;

            invoice.InternalCompanyId = (int)internalCompanyId;
            //invoice.
            invoice.EkspeditorId = ekspeditorId.Value;
            invoice.CustomerId = customerId.Value;
            invoice.CorrespondentBankCustomerId = correspondetnBanksCustomer.Value;
            invoice.CorrespondentBankExpeditorId = correspondetnBanksExpeditor.Value;
            invoice.TransportDocumentId = (int)transportId;
            invoice.Address = (await _context.Institutions.FirstAsync(x => x.Id == invoice.EkspeditorId))
                .PhysicalAddress;
            invoice.Director = (await _context.Institutions.FirstAsync(x => x.Id == invoice.EkspeditorId)).Leader;

            await _context.AddRangeAsync(invoice);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int? id)
        {
            var institutions = await _context.Institutions
                .Where(x => x.EnterpriseTypeId == 1)
                .ToListAsync();
            ViewBag.Institutions = institutions;
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;
            if (id == null)
                return NotFound();

            var correspondetnBanks = await _context.CorrespondentBanks.ToListAsync();
            ViewBag.CorrespondentBanks = correspondetnBanks;

            var invoice = _context.Invoices.FirstOrDefault(x => x.Id == id);
            if (invoice == null)
                return NotFound();
            return View(invoice);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Invoice invoice, int? internalCompanyId, int? ekspeditorId,
            int? customerId, int? transportId, int? correspondetnBanksCustomer, int? correspondetnBanksExpeditor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != invoice.Id)
                return BadRequest();

            var dbInvoice = await _context.Invoices
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbInvoice == null)
                return NotFound();

            if (invoice.Photo != null)
            {
                var path = Path.Combine(Constants.ImageFolderPath, dbInvoice.Logo);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var fileName = await FileUtil.GenerateFileAsync(Constants.ImageFolderPath, invoice.Photo);


                if (invoice.Photo == null)
                {
                    ModelState.AddModelError("Photo", "Select photo.");
                    return View();
                }

                //if (!invoice.Photo.IsImage())
                //{
                //    ModelState.AddModelError("Photo", "Select photo.");
                //    return View();
                //}

                //if (!invoice.Photo.IsSizeAllowed(2048))
                //{
                //    ModelState.AddModelError("Photo", "Max size is 2 MB.");
                //    return View();
                //}
                dbInvoice.Logo = fileName;
            }

            if (invoice.StampPhoto != null)
            {
                var path = Path.Combine(Constants.ImageFolderPath, dbInvoice.Stamp);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                var fileName = await FileUtil.GenerateFileAsync(Constants.ImageFolderPath, invoice.StampPhoto);


                if (invoice.StampPhoto == null)
                {
                    ModelState.AddModelError("Stamp Photo", "Select photo.");
                    return View();
                }

                //if (!invoice.Photo.IsImage())
                //{
                //    ModelState.AddModelError("Photo", "Select photo.");
                //    return View();
                //}

                //if (!invoice.Photo.IsSizeAllowed(2048))
                //{
                //    ModelState.AddModelError("Photo", "Max size is 2 MB.");
                //    return View();
                //}
                dbInvoice.Stamp = fileName;
            }

            dbInvoice.Title = invoice.Title;
            dbInvoice.Date = invoice.Date;
            dbInvoice.InvoiceNumber = invoice.InvoiceNumber;
            dbInvoice.ContractNumber = invoice.ContractNumber;
            dbInvoice.Note = invoice.Note;
            dbInvoice.Address = (await _context.Institutions.FirstAsync(x => x.Id == invoice.EkspeditorId))
                .PhysicalAddress;
            dbInvoice.Director = (await _context.Institutions.FirstAsync(x => x.Id == invoice.EkspeditorId)).Leader;

            dbInvoice.InternalCompanyId = (int)internalCompanyId;
            dbInvoice.EkspeditorId = ekspeditorId.Value;
            dbInvoice.CorrespondentBankExpeditorId = correspondetnBanksExpeditor.Value;
            dbInvoice.CorrespondentBankCustomerId = correspondetnBanksCustomer.Value;
            dbInvoice.CustomerId = customerId.Value;
            dbInvoice.TransportDocumentId = (int)transportId;

            _context.UpdateRange(dbInvoice);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var invoice = await _context.Invoices.FindAsync(id);
            var invoiceTables = await _context.InvoiceTables.Where(x => x.InvoiceId == id).ToListAsync();

            if (invoice == null) return NotFound();

            var path = Path.Combine(Constants.ImageFolderPath, invoice.Logo);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            var stampPath = Path.Combine(Constants.ImageFolderPath, invoice.Stamp);
            if (System.IO.File.Exists(stampPath))
            {
                System.IO.File.Delete(stampPath);
            }

            _context.Invoices.Remove(invoice);
            foreach (var item in invoiceTables)
            {
                _context.InvoiceTables.Remove(item);
            }

            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }
    }
}