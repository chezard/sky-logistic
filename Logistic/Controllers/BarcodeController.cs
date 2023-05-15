using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class BarcodeController : Controller
    {
        private readonly AppDbContext _context;
        
        public BarcodeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var barcodes=_context.Barcodes.ToList();
            return View(barcodes);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var barcode = _context.Barcodes.FirstOrDefault(x => x.Id == id);

            if (barcode == null)
                return NotFound();

            return View(barcode);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Barcode barcode)
        {
            if (!ModelState.IsValid)
                return NotFound();

            await _context.AddRangeAsync(barcode);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var barcode = _context.Barcodes.FirstOrDefault(x => x.Id == id);
            return View(barcode);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Barcode barcode)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != barcode.Id)
                return BadRequest();

            var dbBarcode = await _context.Barcodes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbBarcode == null)
                return NotFound();



            dbBarcode.Type = barcode.Type;
            dbBarcode.Barkod = barcode.Barkod;
            dbBarcode.Date = barcode.Date;
            dbBarcode.Description = barcode.Description;

            _context.UpdateRange(dbBarcode);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var barcode = await _context.Barcodes.FindAsync(id);


            if (barcode == null) return NotFound();

            _context.Barcodes.Remove(barcode);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
