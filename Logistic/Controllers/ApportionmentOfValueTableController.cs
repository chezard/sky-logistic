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
    public class ApportionmentOfValueTableController : Controller
    {
        private readonly AppDbContext _context;
        public ApportionmentOfValueTableController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var apportionmentOfValueTables = _context.ApportionmentOfValueTables.Include(x=>x.TransportDocumentTable).ToList();
            return View(apportionmentOfValueTables);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var apportionmentOfValueTable = _context.ApportionmentOfValueTables.Include(x => x.TransportDocumentTable).Include(x=>x.Valyuta).FirstOrDefault(x => x.Id == id);

            if (apportionmentOfValueTable == null)
                return NotFound();

            return View(apportionmentOfValueTable);
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
        public async Task<IActionResult> Create(ApportionmentOfValueTable apportionmentOfValueTable)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            

            //if (!ModelState.IsValid)
            //  return View();
            
            
            await _context.ApportionmentOfValueTables.AddAsync(apportionmentOfValueTable);
            await _context.SaveChangesAsync();

            return RedirectToAction("DetailValue", "TransportDocumentTable", new { id = apportionmentOfValueTable.TransportDocumentTableId });

        }

        public async Task<IActionResult> Update(int? id)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            

            if (id == null)
                return NotFound();

            var apportionmentOfValueTable = await _context.ApportionmentOfValueTables.FirstOrDefaultAsync(x => x.Id == id);

            if (apportionmentOfValueTable == null)
                return NotFound();
            return View(apportionmentOfValueTable);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ApportionmentOfValueTable apportionmentOfValueTable, int? valyutaId, int? transportDocumentTableId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();



            var dbApportionmentOfValueTable = await _context.ApportionmentOfValueTables.FirstOrDefaultAsync(x => x.Id == id);
            if (dbApportionmentOfValueTable == null)
                return NotFound();



            dbApportionmentOfValueTable.Expense = apportionmentOfValueTable.Expense;
            dbApportionmentOfValueTable.Amount = apportionmentOfValueTable.Amount;
            dbApportionmentOfValueTable.Date = apportionmentOfValueTable.Date;
            dbApportionmentOfValueTable.Note = apportionmentOfValueTable.Note;

            dbApportionmentOfValueTable.ValyutaId = (int)valyutaId;
            dbApportionmentOfValueTable.TransportDocumentTableId = (int)transportDocumentTableId;

            _context.UpdateRange(dbApportionmentOfValueTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailValue", "TransportDocumentTable", new { id = transportDocumentTableId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var apportionmentOfValueTable = await _context.ApportionmentOfValueTables.FindAsync(id);

            if (apportionmentOfValueTable == null) return NotFound();
            var ttId = apportionmentOfValueTable.TransportDocumentTableId;
            _context.ApportionmentOfValueTables.Remove(apportionmentOfValueTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailValue", "TransportDocumentTable", new { id = ttId });
        }
    }
}
