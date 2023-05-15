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
    public class CityController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CityController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var cities = _context.Cities.Include(x => x.Country).ToList();
            return View(cities);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var city = _context.Cities.FirstOrDefault(x => x.Id == id);

            if (city == null)
                return NotFound();

            return View(city);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Countries = await _context.Countries.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(City city, int countryId)
        {
            city.CountryId = countryId;
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();
            return Redirect("/Country/Detail/" + countryId);

        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var city = await _context.Cities.FirstOrDefaultAsync(x => x.Id == id);

            if (city == null)
                return NotFound();

            var countries = await _context.Countries.ToListAsync();
            ViewBag.Countries = countries;

            return View(city);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, City city, int countryId)
        {
            if (id == null)
                return NotFound();

            var dbCity = await _context.Cities.FirstOrDefaultAsync(x => x.Id == id);
            if (dbCity == null)
                return NotFound();

            dbCity.Name = city.Name;
            dbCity.CountryId = countryId;

            _context.Cities.Update(dbCity);
            await _context.SaveChangesAsync();
            return Redirect("/Country/Detail/" + countryId);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var city = await _context.Cities.FirstAsync(x => x.Id == id);
            if (city == null) return NotFound();

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
            return Redirect("/Country/Detail/" + city.CountryId);
        }
    }
}
