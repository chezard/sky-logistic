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
    public class InvoiceTableController : Controller
    {
        private readonly AppDbContext _context;

        public InvoiceTableController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var invoiceTables=_context.InvoiceTables.Include(x=>x.Invoice).ToList();
            return View(invoiceTables);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var invoiceTable = _context.InvoiceTables.Include(x=>x.Invoice).FirstOrDefault(x => x.Id == id);

            if (invoiceTable == null)
                return NotFound();

            return View(invoiceTable);
        }

        public async Task<IActionResult> Create(int? Iid)
        {
            var invoices = await _context.Invoices.ToListAsync();
            ViewBag.Invoices = invoices;
            ViewBag.Iid = Iid;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InvoiceTable invoiceTable)
        {
            var invoices = await _context.Invoices.ToListAsync();
            ViewBag.Invoices = invoices;

            if (!ModelState.IsValid)
                return View();

            


            await _context.InvoiceTables.AddAsync(invoiceTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "Invoice", new { id = invoiceTable.InvoiceId });

        }


        public async Task<IActionResult> Update(int? id)
        {
            var invoices = await _context.Invoices.ToListAsync();
            ViewBag.Invoices = invoices;

            if (id == null)
                return NotFound();

            var invoiceTable = _context.InvoiceTables.FirstOrDefault(x => x.Id == id);

            if (invoiceTable == null)
                return NotFound();

            return View(invoiceTable);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, InvoiceTable invoiceTable, int? invoiceId)
        {
            if (!ModelState.IsValid)
                return NotFound();

            if (id == null)
                return NotFound();
            

            var dbInvoiceTable = await _context.InvoiceTables.FirstOrDefaultAsync(x => x.Id == id);
            if (dbInvoiceTable == null)
                return NotFound();



            dbInvoiceTable.Name = invoiceTable.Name;
            dbInvoiceTable.Count = invoiceTable.Count;
            dbInvoiceTable.Price = invoiceTable.Price;

            dbInvoiceTable.InvoiceId = (int)invoiceId;

            _context.UpdateRange(dbInvoiceTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "Invoice", new { id = invoiceId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var invoiceTable = await _context.InvoiceTables.FindAsync(id);

            if (invoiceTable == null) return NotFound();
            var iId = invoiceTable.InvoiceId;
            _context.InvoiceTables.Remove(invoiceTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "Invoice", new { id = iId });
        }
    }
}
