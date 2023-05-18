using Logistic.DAL;
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
    public class TransportDocumentTableController : Controller
    {
        private readonly AppDbContext _context;

        public TransportDocumentTableController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var transportDocumentTables=_context.TransportDocumentTables.Include(x=>x.TransportDocument).ToList();
            return View(transportDocumentTables);
        }

        public IActionResult DetailCost(int? id)
        {
            if (id == null)
                return NotFound();

            var transportDocumentTable = _context.TransportDocumentTables.Include(x => x.TransportDocument)
                                           .Include(x => x.ConditionOfCarriage).Include(y => y.StatusOfShipment)
                                           .Include(y => y.TypeOfTransportation).Include(y => y.DirectionOfTransportation)
                                           .Include(x=>x.Institution).Include(x=>x.Valyuta)
                                           .Include(x=>x.Personal)
                                           .FirstOrDefault(x => x.Id == id);

            var apportionmentOfCostTable = _context.ApportionmentOfCostTables.Where(x=>x.TransportDocumentTableId==id).Include(x => x.Valyuta).ToList();

            var expenseVM = new ExpenseVM
            {
                TransportDocumentTable = transportDocumentTable,
                ApportionmentOfCostTables = apportionmentOfCostTable
            };

            if (transportDocumentTable == null)
                return NotFound();

            return View(expenseVM);
        }
        
        public IActionResult DetailValue(int? id)
        {
            if (id == null)
                return NotFound();

            var transportDocumentTable = _context.TransportDocumentTables.Include(x => x.TransportDocument)
                .Include(x => x.ConditionOfCarriage).Include(y => y.StatusOfShipment)
                .Include(y => y.TypeOfTransportation).Include(y => y.DirectionOfTransportation)
                .Include(x=>x.Institution).Include(x=>x.Valyuta)
                .Include(x=>x.Personal)
                .FirstOrDefault(x => x.Id == id);

            var apportionmentOfCostTable = _context.ApportionmentOfValueTables.Where(x=>x.TransportDocumentTableId==id).Include(x => x.Valyuta).ToList();

            var expenseValueVm = new ExpenseValueVM()
            {
                TransportDocumentTable = transportDocumentTable,
                ApportionmentOfValueTable = apportionmentOfCostTable
            };

            if (transportDocumentTable == null)
                return NotFound();

            return View(expenseValueVm);
        }
        
        public IActionResult DetailPayment(int? id)
        {
            if (id == null)
                return NotFound();

            var transportDocumentTable = _context.TransportDocumentTables.Include(x => x.TransportDocument)
                .Include(x => x.ConditionOfCarriage).Include(y => y.StatusOfShipment)
                .Include(y => y.TypeOfTransportation).Include(y => y.DirectionOfTransportation)
                .Include(x=>x.Institution).Include(x=>x.Valyuta)
                .Include(x=>x.Personal)
                .FirstOrDefault(x => x.Id == id);

            var apportionmentOfPaymentTables = _context.ApportionmentOfPaymentTables.Where(x=>x.TransportDocumentTableId==id).Include(x => x.Valyuta).ToList();

            var expenseValueVm = new ExpensePaymentVM()
            {
                TransportDocumentTable = transportDocumentTable,
                ApportionmentOfPaymentTables = apportionmentOfPaymentTables
            };

            if (transportDocumentTable == null)
                return NotFound();

            return View(expenseValueVm);
        }

        public async Task<IActionResult> Create(int? tId)
        {
            var countries = await _context.Countries.ToListAsync();
            ViewData["country"] = countries;

            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;
            var conditionOfCarriages = await _context.ConditionOfCarriages.ToListAsync();
            ViewBag.ConditionOfCarriages = conditionOfCarriages;
            var statusOfShipments = await _context.StatusOfShipments.ToListAsync();
            ViewBag.StatusOfShipments = statusOfShipments;
            var typeOfTransportations = await _context.TypeOfTransportations.ToListAsync();
            ViewBag.TypeOfTransportations = typeOfTransportations;
            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            
            var unofficialClients = await _context.UnofficialClients.ToListAsync();
            ViewBag.UnofficialClients = unofficialClients;
            //var institutions = await _context.Institutions.Where(x => x.EnterpriseType.Name == "Partnyor").ToListAsync();
            var institutions = await _context.Institutions.Where(x => x.EnterpriseType.Name == "Partnyor" || x.EnterpriseType.Name == "Agent").ToListAsync();
            ViewBag.Institutions = institutions;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;
            ViewBag.TId = tId;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransportDocumentTable transportDocumentTable, int? FirstCountry, int? FirstCity, int? LastCountry, int? LastCity, string customer)
        {
            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;
            var conditionOfCarriages = await _context.ConditionOfCarriages.ToListAsync();
            ViewBag.ConditionOfCarriages = conditionOfCarriages;
            var statusOfShipments = await _context.StatusOfShipments.ToListAsync();
            ViewBag.StatusOfShipments = statusOfShipments;
            var typeOfTransportations = await _context.TypeOfTransportations.ToListAsync();
            ViewBag.TypeOfTransportations = typeOfTransportations;
            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;
            
            var unofficialClients = await _context.UnofficialClients.ToListAsync();
            ViewBag.UnofficialClients = unofficialClients;
            //var institutions = await _context.Institutions.Where(x=>x.EnterpriseType.Name=="Partnyor").ToListAsync();
            var institutions = await _context.Institutions.Where(x => x.EnterpriseType.Name == "Partnyor" || x.EnterpriseType.Name == "Agent").ToListAsync();
            ViewBag.Institutions = institutions;
            var addresses = await _context.Addresses.ToListAsync();
            ViewBag.Addresses = addresses;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;

            if (!ModelState.IsValid || FirstCountry == null || LastCountry == null) return View();


            transportDocumentTable.Customer = customer;
            var first = (await _context.Countries.FirstAsync(x => x.Id == FirstCountry)).Name + "/" +
                (await _context.Cities.FirstAsync(x => x.Id == FirstCity)).Name;
            transportDocumentTable.AddressFrom = first;
            var last = (await _context.Countries.FirstAsync(x => x.Id == LastCountry)).Name + "/" +
                (await _context.Cities.FirstAsync(x => x.Id == LastCity)).Name;
            transportDocumentTable.AddressTo = last;

            await _context.TransportDocumentTables.AddAsync(transportDocumentTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailAll", "TransportDocument", new { id = transportDocumentTable.TransportDocumentId });

        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();

            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;
            var conditionOfCarriages = await _context.ConditionOfCarriages.ToListAsync();
            ViewBag.ConditionOfCarriages = conditionOfCarriages;
            var statusOfShipments = await _context.StatusOfShipments.ToListAsync();
            ViewBag.StatusOfShipments = statusOfShipments;
            var typeOfTransportations = await _context.TypeOfTransportations.ToListAsync();
            ViewBag.TypeOfTransportations = typeOfTransportations;
            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var customerLegalPeople = await _context.CustomerLegalPeople.ToListAsync();
            ViewBag.CustomerLegalPeople = customerLegalPeople;

            var unofficialClients = await _context.UnofficialClients.ToListAsync();
            ViewBag.UnofficialClients = unofficialClients;
            //var institutions = await _context.Institutions.Where(x => x.EnterpriseType.Name == "Partnyor").ToListAsync();

            var institutions = await _context.Institutions.Where(x => x.EnterpriseType.Name == "Partnyor" || x.EnterpriseType.Name == "Agent").ToListAsync();
            ViewBag.Institutions = institutions;
            var addresses = await _context.Addresses.ToListAsync();
            ViewBag.Addresses = addresses;
            var valyutas = await _context.Valyutas.ToListAsync();
            ViewBag.Valyutas = valyutas;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;


            var transportDocumentTable = await _context.TransportDocumentTables.FirstOrDefaultAsync(x => x.Id == id);
            if (transportDocumentTable == null)
                return NotFound();

            var countries = await _context.Countries.ToListAsync();
            ViewData["firstCountryList"] = countries;
            ViewData["lastCountryList"] = countries;
            var firstCountry = transportDocumentTable.AddressFrom.ToLower().Split("/")[0];
            var lastCountry = transportDocumentTable.AddressTo.ToLower().Split("/")[0];
            var firstCountryId = (await _context.Countries.FirstOrDefaultAsync(x => x.Name.ToLower() == firstCountry)).Id;
            var lastCountryId = (await _context.Countries.FirstOrDefaultAsync(x => x.Name.ToLower() == lastCountry)).Id;
            var firstCityList = await _context.Cities.Where(x => x.CountryId == firstCountryId).ToListAsync();
            var lastCityList = await _context.Cities.Where(x => x.CountryId == lastCountryId).ToListAsync();
            ViewData["firstCityList"] = firstCityList;
            ViewData["lastCityList"] = lastCityList;

            return View(transportDocumentTable);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TransportDocumentTable transportDocumentTable, int? transportDocumentId
                                                , int? conditionOfCarriageId, int? statusOfShipmentId, int? typeOfTransportationId
                                                , int? directionOfTransportationId, int? institutionId
                                                , int? valyutaId, int? personalId, string customer, int? FirstCountry, int? FirstCity, int? LastCountry, int? LastCity)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();
            
            var transportDocuments = await _context.TransportDocuments.ToListAsync();
            ViewBag.TransportDocuments = transportDocuments;
            if (id == null)
                return NotFound();
            if (transportDocumentId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Transport Document qeyd edin");
                return View();
            }
            if (conditionOfCarriageId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Condition Of Carriage qeyd edin");
                return View();
            }
            if (!ModelState.IsValid || FirstCountry == null || LastCountry == null) {
                ModelState.AddModelError("", "Zəhmət Country qeyd edin");
                return View();
            };

            if (statusOfShipmentId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Status Of Shipment qeyd edin");
                return View();
            }
            if (typeOfTransportationId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Type Of Transportation qeyd edin");
                return View();
            }
            if (directionOfTransportationId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Direction Of Transportations qeyd edin");
                return View();
            }
            //if (institutionId == null)
            //{
            //    ModelState.AddModelError("", "Zəhmət olmasa Institution qeyd edin");
            //    return View();
            //}
            if (valyutaId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Valyuta qeyd edin");
                return View();
            }
            if (personalId == null)
            {
                ModelState.AddModelError("", "Zəhmət olmasa Personal qeyd edin");
                return View();
            }

            var dbTransportDocumentTable = await _context.TransportDocumentTables.FirstOrDefaultAsync(x => x.Id == id);
            if (dbTransportDocumentTable == null)
                return NotFound();

            dbTransportDocumentTable.Date = transportDocumentTable.Date;
            dbTransportDocumentTable.DriverName = transportDocumentTable.DriverName;
            dbTransportDocumentTable.DriverPhone = transportDocumentTable.DriverPhone;
            dbTransportDocumentTable.TruckPlate = transportDocumentTable.TruckPlate;
            dbTransportDocumentTable.Name = transportDocumentTable.Name;
            dbTransportDocumentTable.Count = transportDocumentTable.Count;
            dbTransportDocumentTable.Salary = transportDocumentTable.Salary;
            dbTransportDocumentTable.CommonSalary = transportDocumentTable.CommonSalary;
            dbTransportDocumentTable.Description = transportDocumentTable.Description;

            dbTransportDocumentTable.TransportDocumentId = (int)transportDocumentId;
            dbTransportDocumentTable.ConditionOfCarriageId = (int)conditionOfCarriageId;
            dbTransportDocumentTable.StatusOfShipmentId = (int)statusOfShipmentId;
            dbTransportDocumentTable.TypeOfTransportationId = (int)typeOfTransportationId;
            dbTransportDocumentTable.DirectionOfTransportationId = (int)directionOfTransportationId;
            dbTransportDocumentTable.InstitutionId = (int)institutionId;
            dbTransportDocumentTable.ValyutaId = (int)valyutaId;
            dbTransportDocumentTable.PersonalId = (int)personalId;
            dbTransportDocumentTable.Customer = customer;
            var first = (await _context.Countries.FirstAsync(x => x.Id == FirstCountry)).Name + "/" +
                  (await _context.Cities.FirstAsync(x => x.Id == FirstCity)).Name;
            dbTransportDocumentTable.AddressFrom = first;
            var last = (await _context.Countries.FirstAsync(x => x.Id == LastCountry)).Name + "/" +
                (await _context.Cities.FirstAsync(x => x.Id == LastCity)).Name;
            dbTransportDocumentTable.AddressTo = last;

            _context.UpdateRange(dbTransportDocumentTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailAll", "TransportDocument", new { id = transportDocumentId });

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var transportDocumentTable = await _context.TransportDocumentTables.FindAsync(id);

            if (transportDocumentTable == null) return NotFound();
            var tId = transportDocumentTable.TransportDocumentId;
            var expense = await _context.ApportionmentOfCostTables.Where(x => x.TransportDocumentTableId == id).ToListAsync();
            foreach (var exp in expense)
            {
                _context.ApportionmentOfCostTables.Remove(exp);

            }
            _context.TransportDocumentTables.Remove(transportDocumentTable);
            await _context.SaveChangesAsync();
            return RedirectToAction("DetailAll", "TransportDocument", new { id = tId });
        }
    }
}