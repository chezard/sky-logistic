using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;

namespace Logistic.Controllers
{
    [Authorize]
    public class ApportionmentOfPaymentTableController : Controller
    {
        private readonly AppDbContext _context;
        public ApportionmentOfPaymentTableController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var apportionmentOfPaymentTables = _context.ApportionmentOfPaymentTables.Include(x=>x.TransportDocumentTable).ToList();
            return View(apportionmentOfPaymentTables);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var apportionmentOfPaymentTable = _context.ApportionmentOfPaymentTables.Include(x => x.TransportDocumentTable).Include(x=>x.Valyuta).FirstOrDefault(x => x.Id == id);

            if (apportionmentOfPaymentTable == null)
                return NotFound();

            return View(apportionmentOfPaymentTable);
        }
        public async Task<IActionResult> Create(int? transportDocumentTableId)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            ViewBag.Id = transportDocumentTableId;
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApportionmentOfPaymentTable apportionmentOfPaymentTable)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            

            //if (!ModelState.IsValid)
            //  return View();
            
            
            await _context.ApportionmentOfPaymentTables.AddAsync(apportionmentOfPaymentTable);
            await _context.SaveChangesAsync();

            return RedirectToAction("DetailPayment", "TransportDocumentTable", new { id = apportionmentOfPaymentTable.TransportDocumentTableId });

        }

        public async Task<IActionResult> Update(int? id)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            

            if (id == null)
                return NotFound();

            var apportionmentOfPaymentTable = await _context.ApportionmentOfPaymentTables.FirstOrDefaultAsync(x => x.Id == id);

            if (apportionmentOfPaymentTable == null)
                return NotFound();
            return View(apportionmentOfPaymentTable);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ApportionmentOfPaymentTable apportionmentOfPaymentTable, int? valyutaId, int? transportDocumentTableId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();



            var dbApportionmentOfPaymentTable = await _context.ApportionmentOfPaymentTables.FirstOrDefaultAsync(x => x.Id == id);
            if (dbApportionmentOfPaymentTable == null)
                return NotFound();



            dbApportionmentOfPaymentTable.Expense = apportionmentOfPaymentTable.Expense;
            dbApportionmentOfPaymentTable.Amount = apportionmentOfPaymentTable.Amount;
            dbApportionmentOfPaymentTable.Date = apportionmentOfPaymentTable.Date;
            dbApportionmentOfPaymentTable.Note = apportionmentOfPaymentTable.Note;

            dbApportionmentOfPaymentTable.ValyutaId = (int)valyutaId;
            dbApportionmentOfPaymentTable.TransportDocumentTableId = (int)transportDocumentTableId;

            _context.UpdateRange(dbApportionmentOfPaymentTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailPayment", "TransportDocumentTable", new { id = transportDocumentTableId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var apportionmentOfPaymentTable = await _context.ApportionmentOfPaymentTables.FindAsync(id);

            if (apportionmentOfPaymentTable == null) return NotFound();
            var ttId = apportionmentOfPaymentTable.TransportDocumentTableId;
            _context.ApportionmentOfPaymentTables.Remove(apportionmentOfPaymentTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailPayment", "TransportDocumentTable", new { id = ttId });
        }
    }
}
