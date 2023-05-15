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
    public class ContractTypeController : Controller
    {
        private readonly AppDbContext _context;

        public ContractTypeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contractTypes=_context.ContractTypes.ToList();
            return View(contractTypes);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var contractType = _context.ContractTypes.FirstOrDefault(x => x.Id == id);

            if (contractType == null)
                return NotFound();

            return View(contractType);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContractType contractType)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            await _context.AddRangeAsync(contractType);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();

            var contractType = _context.ContractTypes.FirstOrDefault(x => x.Id == id);
            return View(contractType);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, ContractType contractType)
        {

            //if (!ModelState.IsValid)
            //    return View();

            if (id == null)
                return NotFound();

            if (id != contractType.Id)
                return BadRequest();

            var dbContractType = await _context.ContractTypes
                .FirstOrDefaultAsync(x => x.Id == id);

            if (dbContractType == null)
                return NotFound();



            dbContractType.Name = contractType.Name;
            dbContractType.Date = contractType.Date;
            dbContractType.Description = contractType.Description;

            _context.UpdateRange(dbContractType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var contractType = await _context.ContractTypes.FindAsync(id);


            if (contractType == null) return NotFound();

            _context.ContractTypes.Remove(contractType);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
