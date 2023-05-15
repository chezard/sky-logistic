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
    public class CountryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CountryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var banks = _context.Countries.ToList();
            return View(banks);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var country = await _context.Countries.FirstOrDefaultAsync(x => x.Id == id);

            if (country == null)
                return NotFound();

            ViewBag.Cities = await _context.Cities.Where(x => x.CountryId == id).ToListAsync();

            return View(country);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Country country)
        {

            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var country = await _context.Countries.FirstOrDefaultAsync(x => x.Id == id);

            if (country == null)
                return NotFound();

            return View(country);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Country country)
        {
            if (id == null)
                return NotFound();

            var dbCountry = await _context.Countries.FirstOrDefaultAsync(x => x.Id == id);
            if (country == null)
                return NotFound();

            dbCountry.Name = country.Name;

            _context.Update(dbCountry);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var country = await _context.Countries.FirstAsync(x => x.Id == id);
            if (country == null) return NotFound();

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
