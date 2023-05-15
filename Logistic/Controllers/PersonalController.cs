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
    public class PersonalController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public PersonalController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var personals=_context.Personals.ToList();
            return View(personals);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var personal = _context.Personals.Include(x=>x.PersonnelType).FirstOrDefault(x => x.Id == id);

            if (personal == null)
                return NotFound();

            return View(personal);
        }

        public async Task<IActionResult> Create()
        {
            //var positions = await _context.Positions.ToListAsync();
            //ViewBag.Positions = positions;
            var personnelTypes = await _context.PersonnelTypes.ToListAsync();
            ViewBag.PersonnelTypes = personnelTypes;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Personal personal, int? positionId,int? personalTypeId)
        {
            //var positions = await _context.Positions.ToListAsync();
            //ViewBag.Positions = positions;
            var personnelTypes = await _context.PersonnelTypes.ToListAsync();
            ViewBag.PersonnelTypes = personnelTypes;

            //if (!ModelState.IsValid)
            //  return View();
            

            //if (personal.File == null)
            //{

            //    ModelState.AddModelError("File", "Select pdf.");
            //    return View();


            //}
            //if (positionId == null)
            //{
            //    ModelState.AddModelError("", "Zəhmət olmasa vəzifəni qeyd edin");
            //    return View();
            //}
            if (personalTypeId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Personal növünü qeyd edin");
                return View();
            }
            if (personal.File != null)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + personal.File.FileName;
                personal.FileName = fileName;
                var filePath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    personal.File.CopyTo(stream);


                }
            }
            personal.PersonnelTypeId = (int)personalTypeId;
            //personal.PositionId = (int)positionId;
            await _context.Personals.AddAsync(personal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        public async Task<IActionResult> Update(int? id)
        {
            //var positions = await _context.Positions.ToListAsync();
            //ViewBag.Positions = positions;
            var personnelTypes = await _context.PersonnelTypes.ToListAsync();
            ViewBag.PersonnelTypes = personnelTypes;

            if (id == null)
                return NotFound();

            var personal = await _context.Personals.FirstOrDefaultAsync(x => x.Id == id);

            if (personal == null)
                return NotFound();
            return View(personal);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Personal personal, int? personalTypeId)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

            //if (positionId == null)
            //{
            //    ModelState.AddModelError("", "Zəhmət olmasa vəzifəni qeyd edin");
            //    return View();
            //}

            if (personalTypeId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Personal növünü qeyd edin");
                return View();
            }

            var dbPersonal = await _context.Personals.FirstOrDefaultAsync(x => x.Id == id);
            if (dbPersonal == null)
                return NotFound();

            if (personal.File != null)
            {
                if (dbPersonal.File != null)
                {
                    var path = Path.Combine(_env.WebRootPath, "files", dbPersonal.FileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
                
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var randomValue = new string(Enumerable.Repeat(chars, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                var fileName = randomValue + personal.File.FileName;
                personal.FileName = fileName;
                var iconSPath = Path.Combine(_env.WebRootPath, "files\\" + fileName);

                using (FileStream stream = new FileStream(iconSPath, FileMode.Create))
                {
                    personal.File.CopyTo(stream);

                }

                dbPersonal.FileName = fileName;
            }

            dbPersonal.Name = personal.Name;
            dbPersonal.Surname = personal.Surname;
            dbPersonal.FathersName = personal.FathersName;
            dbPersonal.Phone = personal.Phone;
            dbPersonal.Mail = personal.Mail;
            dbPersonal.Address = personal.Address;
            dbPersonal.PersonalInformation = personal.PersonalInformation;
            dbPersonal.Description = personal.Description;


            dbPersonal.PersonnelTypeId = (int)personalTypeId;
            //dbPersonal.PositionId = (int)positionId;

            _context.UpdateRange(dbPersonal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var personal = await _context.Personals.FindAsync(id);

            if (personal == null) return NotFound();

            var path = Path.Combine(_env.WebRootPath, "files", personal.FileName);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Personals.Remove(personal);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
