using Logistic.DAL;
using Logistic.Data;
using Logistic.Models;
using Logistic.Response.RapidApi.GeoDb;
using Logistic.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class AddressController : Controller
    {
        private readonly AppDbContext _context;

        public AddressController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var addresses = _context.Addresses.ToList();
            return View(addresses);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var address = _context.Addresses.FirstOrDefault(x => x.Id == id);

            if (address == null)
                return NotFound();

            return View(address);
        }
        public IActionResult Create()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries?offset=0&limit=10"),
                Headers =
    {
        { "X-RapidAPI-Key", "3107c75e75mshc532836327d32acp131a20jsn446733d3ee1b" },
        { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
    },
            };
            using (var response = client.Send(request))
            {
                var deserializedObject = JsonConvert.DeserializeObject<CountryModel>(response.Content.ReadAsStringAsync().Result);
                ViewData["country"] = deserializedObject;
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAddressVM addressVM)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();
            if (!ModelState.IsValid)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries?offset=0&limit=10"),
                    Headers =
    {
        { "X-RapidAPI-Key", "3107c75e75mshc532836327d32acp131a20jsn446733d3ee1b" },
        { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
    },
                };
                using (var response = client.Send(request))
                {
                    var deserializedObject = JsonConvert.DeserializeObject<CountryModel>(response.Content.ReadAsStringAsync().Result);
                    ViewData["country"] = deserializedObject;
                }
                return View(addressVM);
            }
            Address address = new Address()
            {
                Date = addressVM.Date,
                Description = addressVM.Description,
                Id = addressVM.Id,
                Name = addressVM.Country.Split("/")[1] + "/" + addressVM.City,
                TopGroup = addressVM.TopGroup
            };

            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries?offset=0&limit=10"),
                Headers =
    {
        { "X-RapidAPI-Key", "3107c75e75mshc532836327d32acp131a20jsn446733d3ee1b" },
        { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
    },
            };
            using (var response = client.Send(request))
            {
                var deserializedObject = JsonConvert.DeserializeObject<CountryModel>(response.Content.ReadAsStringAsync().Result);
                ViewData["country"] = deserializedObject;
            }

            var address = _context.Addresses.FirstOrDefault(x => x.Id == id);

            CreateAddressVM vm = new CreateAddressVM()
            {
                Id = address.Id,
                TopGroup = address.TopGroup,
                Date = address.Date,
                Description = address.Description,
                City = address.Name.Split("/")[1],
                Country = address.Name.Split("/")[0]
            };
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, CreateAddressVM address)
        {

            if (!ModelState.IsValid)
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/countries?offset=0&limit=10"),
                    Headers =
    {
        { "X-RapidAPI-Key", "3107c75e75mshc532836327d32acp131a20jsn446733d3ee1b" },
        { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
    },
                };
                using (var response = client.Send(request))
                {
                    var deserializedObject = JsonConvert.DeserializeObject<CountryModel>(response.Content.ReadAsStringAsync().Result);
                    ViewData["country"] = deserializedObject;
                }
                return View(address);
            }

            if (id == null)
                return NotFound();

            if (id != address.Id)
                return BadRequest();

            var dbAddress = await _context.Addresses
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbAddress == null)
                return NotFound();



            dbAddress.Name = address.Country.Split("/")[1] + "/" + address.City;
            dbAddress.TopGroup = address.TopGroup;
            dbAddress.Date = address.Date;
            dbAddress.Description = address.Description;
            _context.UpdateRange(dbAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var address = await _context.Addresses.FindAsync(id);


            if (address == null) return NotFound();

            _context.Addresses.Remove(address);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> FindCity(int countryId)
        {
            var cities = await _context.Cities.Where(x => x.CountryId == countryId).ToListAsync();
            return Json(cities);
        }

        [HttpPost]
        public async Task<JsonResult> FilterCity(string Key, string Country)
        {
            JsonResult res = new(new() { });
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wft-geo-db.p.rapidapi.com/v1/geo/cities?limit=10&namePrefix=" + Key + "&countryIds=" + Country),
                Headers =
                {
                    { "X-RapidAPI-Key", "3107c75e75mshc532836327d32acp131a20jsn446733d3ee1b" },
                    { "X-RapidAPI-Host", "wft-geo-db.p.rapidapi.com" },
                },
            };
            using (var response = client.Send(request))
            {
                var deserializedObject = JsonConvert.DeserializeObject<CityModel>(response.Content.ReadAsStringAsync().Result);
                res.Value = deserializedObject;
                return Json(res);
            }
            return Json(res);
        }

    }
}
