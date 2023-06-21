using Logistic.DAL;
using Logistic.Models;
using Logistic.Response.RapidApi.GeoDb;
using Logistic.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using Logistic.Dtos;

namespace Logistic.Controllers
{
    [Authorize]
    public class TransportDocumentController : Controller
    {
        private readonly AppDbContext _context;

        public TransportDocumentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var transportDocuments = _context.TransportDocuments
                .Include(x=>x.TransportDocumentTables)
                .OrderByDescending(x => x.Id).ToList();
            return View(transportDocuments);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();

            var transportDocument = _context.TransportDocuments.Include(y => y.Institution)
                .Include(x => x.DirectionOfTransportation)
                .Include(x => x.PaymentType).Include(x => x.Assistant1)
                .FirstOrDefault(x => x.Id == id);

            if (transportDocument == null)
                return NotFound();

            return View(transportDocument);
        }

        public IActionResult DetailAll(int? id)
        {
            if (id == null)
                return NotFound();

            var transportDocument = _context.TransportDocuments.Include(y => y.Institution)
                .Include(x => x.DirectionOfTransportation)
                .Include(x => x.PaymentType).Include(x => x.Assistant1)
                .FirstOrDefault(x => x.Id == id);

            var transportDocumentTable = _context.TransportDocumentTables.Where(x => x.TransportDocumentId == id)
                .Include(x => x.TransportDocument)
                .Include(x => x.ConditionOfCarriage).Include(y => y.StatusOfShipment)
                .Include(y => y.TypeOfTransportation).Include(y => y.DirectionOfTransportation)
                .Include(x => x.Institution).Include(x => x.Valyuta)
                .Include(x => x.Personal).Include(x => x.CostList).Include(x => x.ValueList).Include(x => x.PaymentList)
                .ToList();

            if (transportDocument == null)
                return NotFound();

            var transportDocumentVM = new TransportDocumentVM
            {
                TransportDocument = transportDocument,
                TransportDocumentTables = transportDocumentTable
            };

            return View(transportDocumentVM);
        }

        public async Task<IActionResult> Create()
        {
            var countries = await _context.Countries.ToListAsync();
            ViewData["country"] = countries;
            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var addresses = await _context.Addresses.ToListAsync();
            ViewBag.Addresses = addresses;
            var institutions = await _context.Institutions.Where(x => x.EnterpriseTypeId == 1).ToListAsync();
            ViewBag.Institutions = institutions;
            var paymentTypes = await _context.PaymentTypes.ToListAsync();
            ViewBag.PaymentTypes = paymentTypes;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAssistants()
        {
            var assistants = await _context.Personals.ToListAsync();

            return Json(new
            {
                data = assistants,
                status = 200,
                guid = Guid.NewGuid().ToString()
            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransportDocument transportDocument, int? institutionId
            , int? directionOfTransportationId, int FirstCountry, int FirstCity, int LastCountry, int LastCity
            , int? paymentTypeId, int? managerId, int? assistant1Id)
        {
            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var institutions = await _context.Institutions.Where(x => x.EnterpriseTypeId == 1).ToListAsync();
            ViewBag.Institutions = institutions;
            var paymentTypes = await _context.PaymentTypes.ToListAsync();
            ViewBag.PaymentTypes = paymentTypes;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;

            if (!ModelState.IsValid || FirstCountry == null || LastCountry == null) return View();

            transportDocument.InstitutionId = (int)institutionId;
            transportDocument.DirectionOfTransportationId = (int)directionOfTransportationId;
            var first = (await _context.Countries.FirstAsync(x => x.Id == FirstCountry)).Name + "/" +
                        (await _context.Cities.FirstAsync(x => x.Id == FirstCity)).Name;
            transportDocument.FirstAddress = first;
            var last = (await _context.Countries.FirstAsync(x => x.Id == LastCountry)).Name + "/" +
                       (await _context.Cities.FirstAsync(x => x.Id == LastCity)).Name;
            transportDocument.LastAddress = last;
            transportDocument.PaymentTypeId = (int)paymentTypeId;
            transportDocument.Assistant1Id = (int)assistant1Id;

            await _context.AddRangeAsync(transportDocument);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var addresses = await _context.Addresses.ToListAsync();
            ViewBag.Addresses = addresses;
            var institutions = await _context.Institutions.Where(x => x.EnterpriseTypeId == 1).ToListAsync();
            ViewBag.Institutions = institutions;
            var paymentTypes = await _context.PaymentTypes.ToListAsync();
            ViewBag.PaymentTypes = paymentTypes;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;

            if (id == null)
                return NotFound();

            var transportDocument = await _context.TransportDocuments.FirstOrDefaultAsync(x => x.Id == id);
            if (transportDocument == null)
                return NotFound();

            var countries = await _context.Countries.ToListAsync();
            ViewData["firstCountryList"] = countries;
            ViewData["lastCountryList"] = countries;
            var firstCountry = transportDocument.FirstAddress.ToLower().Split("/")[0];
            var lastCountry = transportDocument.LastAddress.ToLower().Split("/")[0];
            var firstCountryId = (await _context.Countries.FirstOrDefaultAsync(x => x.Name.ToLower() == firstCountry))
                .Id;
            var lastCountryId = (await _context.Countries.FirstOrDefaultAsync(x => x.Name.ToLower() == lastCountry)).Id;

            var firstCityList = await _context.Cities.Where(x => x.CountryId == firstCountryId).ToListAsync();
            var lastCityList = await _context.Cities.Where(x => x.CountryId == lastCountryId).ToListAsync();

            ViewData["firstCityList"] = firstCityList;
            ViewData["lastCityList"] = lastCityList;
            return View(transportDocument);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, TransportDocument transportDocument, int? institutionId
            , int? directionOfTransportationId, int FirstCountry, int FirstCity, int LastCountry, int LastCity
            , int? paymentTypeId, int? managerId, int? assistant1Id)
        {
            //if (!ModelState.IsValid)
            //    return NotFound();

            if (id == null)
                return NotFound();

            var directionOfTransportations = await _context.DirectionOfTransportations.ToListAsync();
            ViewBag.DirectionOfTransportations = directionOfTransportations;
            var addresses = await _context.Addresses.ToListAsync();
            ViewBag.Addresses = addresses;
            var institutions = await _context.Institutions.ToListAsync();
            ViewBag.Institutions = institutions;
            var paymentTypes = await _context.PaymentTypes.ToListAsync();
            ViewBag.PaymentTypes = paymentTypes;
            var personals = await _context.Personals.ToListAsync();
            ViewBag.Personals = personals;

            var dbTransportDocument = await _context.TransportDocuments.FirstOrDefaultAsync(x => x.Id == id);
            if (dbTransportDocument == null)
                return NotFound();

            var transportDocuments = await _context.TransportDocuments.FirstOrDefaultAsync(x => x.Id == id);

            if (!ModelState.IsValid || FirstCountry == null || LastCountry == null) return View();

            dbTransportDocument.Date = transportDocument.Date;

            dbTransportDocument.InstitutionId = (int)institutionId;
            dbTransportDocument.DirectionOfTransportationId = (int)directionOfTransportationId;
            var first = (await _context.Countries.FirstAsync(x => x.Id == FirstCountry)).Name + "/" +
                        (await _context.Cities.FirstAsync(x => x.Id == FirstCity)).Name;
            dbTransportDocument.FirstAddress = first;
            var last = (await _context.Countries.FirstAsync(x => x.Id == LastCountry)).Name + "/" +
                       (await _context.Cities.FirstAsync(x => x.Id == LastCity)).Name;
            dbTransportDocument.LastAddress = last;
            dbTransportDocument.PaymentTypeId = (int)paymentTypeId;
            dbTransportDocument.Assistant1Id = (int)assistant1Id;

            _context.TransportDocuments.UpdateRange(dbTransportDocument);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var transportDocument = await _context.TransportDocuments.FindAsync(id);
            var transportDocumentTables =
                await _context.TransportDocumentTables.Where(x => x.TransportDocumentId == id).ToListAsync();


            if (transportDocument == null) return NotFound();

            _context.TransportDocuments.Remove(transportDocument);
            foreach (var item in transportDocumentTables)
            {
                _context.TransportDocumentTables.Remove(item);
                var expense = await _context.ApportionmentOfCostTables.Where(x => x.TransportDocumentTableId == item.Id)
                    .ToListAsync();
                foreach (var exp in expense)
                {
                    _context.ApportionmentOfCostTables.Remove(exp);
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Lock(int? id)
        {
            var transportDocument = await _context.TransportDocuments.FirstOrDefaultAsync(x => x.Id == id);
            transportDocument.IsLocked = !transportDocument.IsLocked;
            _context.TransportDocuments.Update(transportDocument);
            await _context.SaveChangesAsync();
            return Ok("Ok");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDate([FromBody] DateTimeUpdateRequest request)
        {
            var transportDocument = await _context.TransportDocuments.SingleOrDefaultAsync(x => x.Id == request.Id);
            transportDocument.Date = request.DateTime;
            _context.TransportDocuments.Update(transportDocument);
            await _context.SaveChangesAsync();
            return Ok("OK");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCopy(int id)
        {
            var willCopiedTransportDocument = await _context.TransportDocuments
                .Include(td => td.TransportDocumentTables)
                .ThenInclude(tdt => tdt.CostList)
                .Include(td => td.TransportDocumentTables)
                .ThenInclude(tdt => tdt.ValueList)
                .Include(td => td.TransportDocumentTables)
                .ThenInclude(tdt => tdt.PaymentList)
                .SingleOrDefaultAsync(x => x.Id == id);

            var newTransportDocument = new TransportDocument()
            {
                Assistant1Id = willCopiedTransportDocument.Assistant1Id,
                InstitutionId = willCopiedTransportDocument.InstitutionId,
                Date = willCopiedTransportDocument.Date,
                FirstAddress = willCopiedTransportDocument.FirstAddress,
                LastAddress = willCopiedTransportDocument.LastAddress,
                IsLocked = false,
                Assistant2 = willCopiedTransportDocument.Assistant2,
                Assistant3 = willCopiedTransportDocument.Assistant3,
                Assistant4 = willCopiedTransportDocument.Assistant4,
                PaymentTypeId = willCopiedTransportDocument.PaymentTypeId,
                DirectionOfTransportationId = willCopiedTransportDocument.DirectionOfTransportationId
            };

            await _context.TransportDocuments.AddAsync(newTransportDocument);
            await _context.SaveChangesAsync();

            var nnn = newTransportDocument;

            var newTransportDocumentTables = willCopiedTransportDocument.TransportDocumentTables
                .Select(tdt => new TransportDocumentTable()
                {
                    TransportDocumentId = newTransportDocument.Id,
                    Count = tdt.Count,
                    Name = tdt.Name,
                    Date = tdt.Date,
                    Customer = tdt.Customer,
                    InstitutionId = tdt.InstitutionId,
                    Description = tdt.Description,
                    Salary = tdt.Salary,
                    AddressFrom = tdt.AddressFrom,
                    AddressTo = tdt.AddressTo,
                    ValyutaId = tdt.ValyutaId,
                    PersonalId = tdt.PersonalId,
                    CommonSalary = tdt.CommonSalary,
                    DriverName = tdt.DriverName,
                    DriverPhone = tdt.DriverPhone,
                    TruckPlate = tdt.TruckPlate,
                    ConditionOfCarriageId = tdt.ConditionOfCarriageId,
                    DirectionOfTransportationId = tdt.DirectionOfTransportationId,
                    StatusOfShipmentId = tdt.StatusOfShipmentId,
                    TypeOfTransportationId = tdt.TypeOfTransportationId
                }).ToList();

            for (int i = 0; i < newTransportDocumentTables.Count; i++)
            {
                await _context.TransportDocumentTables.AddAsync(newTransportDocumentTables[i]);
                await _context.SaveChangesAsync();

                var newCostList = willCopiedTransportDocument.TransportDocumentTables[i].CostList
                    .Select(x => new ApportionmentOfCostTable()
                    {
                        TransportDocumentTableId = newTransportDocumentTables[i].Id,
                        ValyutaId = x.ValyutaId,
                        Date = x.Date,
                        Amount = x.Amount,
                        Expense = x.Expense,
                        Note = x.Note
                    }).ToList();

                newCostList.ForEach(x => _context.ApportionmentOfCostTables.Add(x));

                var newPaymentList = willCopiedTransportDocument.TransportDocumentTables[i].PaymentList
                    .Select(x => new ApportionmentOfPaymentTable()
                    {
                        TransportDocumentTableId = newTransportDocumentTables[i].Id,
                        ValyutaId = x.ValyutaId,
                        Date = x.Date,
                        Amount = x.Amount,
                        Expense = x.Expense,
                        Note = x.Note
                    }).ToList();

                newPaymentList.ForEach(x => _context.ApportionmentOfPaymentTables.Add(x));


                var newValueList = willCopiedTransportDocument.TransportDocumentTables[i].ValueList
                    .Select(x => new ApportionmentOfValueTable()
                    {
                        TransportDocumentTableId = newTransportDocumentTables[i].Id,
                        ValyutaId = x.ValyutaId,
                        Date = x.Date,
                        Amount = x.Amount,
                        Expense = x.Expense,
                        Note = x.Note
                    }).ToList();

                newValueList.ForEach(x => _context.ApportionmentOfValueTables.Add(x));

                await _context.SaveChangesAsync();
            }

            return Ok();
        }
    }
}