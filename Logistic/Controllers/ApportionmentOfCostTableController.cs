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
    public class ApportionmentOfCostTableController : Controller
    {
        private readonly AppDbContext _context;
        public ApportionmentOfCostTableController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var apportionmentOfCostTables = _context.ApportionmentOfCostTables.Include(x=>x.TransportDocumentTable).ToList();
            return View(apportionmentOfCostTables);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var apportionmentOfCostTable = _context.ApportionmentOfCostTables.Include(x => x.TransportDocumentTable).Include(x=>x.Valyuta).FirstOrDefault(x => x.Id == id);

            if (apportionmentOfCostTable == null)
                return NotFound();

            return View(apportionmentOfCostTable);
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
        public async Task<IActionResult> Create(ApportionmentOfCostTable apportionmentOfCostTable)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            

            //if (!ModelState.IsValid)
            //  return View();
            
            
            await _context.ApportionmentOfCostTables.AddAsync(apportionmentOfCostTable);
            await _context.SaveChangesAsync();

            return RedirectToAction("Detail", "TransportDocumentTable", new { id = apportionmentOfCostTable.TransportDocumentTableId });

        }

        public async Task<IActionResult> Update(int? id)
        {
            var transportDocumentTables = await _context.TransportDocumentTables.ToListAsync();
            ViewBag.TransportDocumentTables = transportDocumentTables;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            

            if (id == null)
                return NotFound();

            var apportionmentOfCostTable = await _context.ApportionmentOfCostTables.FirstOrDefaultAsync(x => x.Id == id);

            if (apportionmentOfCostTable == null)
                return NotFound();
            return View(apportionmentOfCostTable);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ApportionmentOfCostTable apportionmentOfCostTable, int? valyutaId, int? transportDocumentTableId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();



            var dbApportionmentOfCostTable = await _context.ApportionmentOfCostTables.FirstOrDefaultAsync(x => x.Id == id);
            if (dbApportionmentOfCostTable == null)
                return NotFound();



            dbApportionmentOfCostTable.Expense = apportionmentOfCostTable.Expense;
            dbApportionmentOfCostTable.Amount = apportionmentOfCostTable.Amount;
            dbApportionmentOfCostTable.Date = apportionmentOfCostTable.Date;
            dbApportionmentOfCostTable.Note = apportionmentOfCostTable.Note;

            dbApportionmentOfCostTable.ValyutaId = (int)valyutaId;
            dbApportionmentOfCostTable.TransportDocumentTableId = (int)transportDocumentTableId;

            _context.UpdateRange(dbApportionmentOfCostTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "TransportDocumentTable", new { id = transportDocumentTableId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var apportionmentOfCostTable = await _context.ApportionmentOfCostTables.FindAsync(id);

            if (apportionmentOfCostTable == null) return NotFound();
            var ttId = apportionmentOfCostTable.TransportDocumentTableId;
            _context.ApportionmentOfCostTables.Remove(apportionmentOfCostTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail", "TransportDocumentTable", new { id = ttId });
        }
    }
}
