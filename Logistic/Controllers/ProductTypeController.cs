using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class ProductTypeController : Controller
    {
        private readonly AppDbContext _context;

        public ProductTypeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var productTypes = await _context.ProductTypes.ToListAsync();
            return View(productTypes);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var productType = _context.ProductTypes.FirstOrDefault(x => x.Id == id);

            if (productType == null)
                return NotFound();

            return View(productType);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductType productType)
        {
            if (!ModelState.IsValid)
                return NotFound();


            await _context.AddRangeAsync(productType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var productType = _context.ProductTypes.FirstOrDefault(x => x.Id == id);
            return View(productType);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ProductType productType)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null)
                return NotFound();

            if (id != productType.Id)
                return BadRequest();

            var dbProductType = await _context.ProductTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbProductType == null)
                return NotFound();


            
            dbProductType.Name = productType.Name;
            dbProductType.Date = productType.Date;
            dbProductType.Description = productType.Description;


            
            _context.UpdateRange(dbProductType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var productType =await _context.ProductTypes.FindAsync(id);


            if (productType == null) return NotFound();

            _context.ProductTypes.Remove(productType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
