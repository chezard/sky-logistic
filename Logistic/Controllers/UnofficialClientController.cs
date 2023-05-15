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
    public class UnofficialClientController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public UnofficialClientController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var unofficialClients=_context.UnofficialClients.ToList();
            return View(unofficialClients);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var unofficialClient = _context.UnofficialClients.FirstOrDefault(x => x.Id == id);

            if (unofficialClient == null)
                return NotFound();

            return View(unofficialClient);
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UnofficialClient unofficialClient)
        {

            //if (!ModelState.IsValid)
            //    return View();

            //if (unofficialClient.File == null)
            //{
            //    ModelState.AddModelError("File", "Select pdf.");
            //    return View();
            //}
            if (unofficialClient.File != null)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + unofficialClient.File.FileName;
                unofficialClient.FileName = fileName;
                var filePath = Path.Combine(_env.WebRootPath, "files\\" + fileName);


                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    unofficialClient.File.CopyTo(stream);
                }
            }
            
            await _context.UnofficialClients.AddAsync(unofficialClient);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Update(int? id)
        {
            
            if (id == null)
                return NotFound();

            var unofficialClient = await _context.UnofficialClients.FirstOrDefaultAsync(x => x.Id == id);

            if (unofficialClient == null)
                return NotFound();
            return View(unofficialClient);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, UnofficialClient unofficialClient)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

           
            var dbUnofficialClient = await _context.UnofficialClients.FirstOrDefaultAsync(x => x.Id == id);
            if (dbUnofficialClient == null)
                return NotFound();

            if (unofficialClient.File != null)
            {
                if (dbUnofficialClient.File != null)
                {
                    var path = Path.Combine(_env.WebRootPath, "files", dbUnofficialClient.FileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
                
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + unofficialClient.File.FileName;
                unofficialClient.FileName = fileName;
                var iconSPath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                using (FileStream stream = new FileStream(iconSPath, FileMode.Create))
                {
                    unofficialClient.File.CopyTo(stream);

                }

                dbUnofficialClient.FileName = fileName;
            }

            dbUnofficialClient.Name = unofficialClient.Name;
            dbUnofficialClient.Address = unofficialClient.Address;
            dbUnofficialClient.Phone = unofficialClient.Phone;
            dbUnofficialClient.Mail = unofficialClient.Mail;
            dbUnofficialClient.Date = unofficialClient.Date;

            _context.UpdateRange(dbUnofficialClient);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var unofficialClient = await _context.UnofficialClients.FindAsync(id);

            if (unofficialClient == null) return NotFound();

            var path = Path.Combine(_env.WebRootPath, "files", unofficialClient.FileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.UnofficialClients.Remove(unofficialClient);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
