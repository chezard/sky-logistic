using Logistic.DAL;
using Logistic.SendMail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
using Logistic.Data;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Logistic.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly AppDbContext _context;

        public ReportController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var transportDocumentTable = _context.TransportDocumentTables.Include(x => x.TransportDocument)
                                           .Include(x => x.ConditionOfCarriage).Include(y => y.StatusOfShipment)
                                           .Include(y => y.TypeOfTransportation).Include(y => y.DirectionOfTransportation)
                                           .Include(x => x.Institution).Include(x => x.Valyuta)
                                           .Include(x => x.Personal).Include(x=>x.CostList)
                                           .OrderByDescending(x=>x.Id)
                                           .ToList();

            return View(transportDocumentTable);
        }

        public IActionResult SendMail()
        {
            var transportDocumentTable = _context.TransportDocumentTables.Include(x => x.TransportDocument)
                                           .Include(x => x.ConditionOfCarriage).Include(y => y.StatusOfShipment)
                                           .Include(y => y.TypeOfTransportation).Include(y => y.DirectionOfTransportation)
                                           .Include(x => x.Institution).Include(x => x.Valyuta)
                                           .Include(x => x.Personal).Include(x => x.CostList)
                                           .ToList();

            return View(transportDocumentTable);
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(string to, string subject, string body)
        {
            try
            {
                Thread email = new(delegate ()
                {
                    Sendmail.SendMessage(to, subject, body);
                });
                email.IsBackground = true;
                email.Start();
                TempData["alert"] = "Email Successfully Sent";
            }
            catch (Exception)
            {
                TempData["alert"] = "Problem Sending mail. Please check the configuration";
            }
           

            return RedirectToAction("Index");
        }
        
    }
}
