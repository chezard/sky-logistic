using Logistic.ViewModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Logo { get; set; }
        public string Stamp { get; set; }
        public int InternalCompanyId { get; set; }
        public Institution InternalCompany { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public int EkspeditorId { get; set; }
        public Institution Ekspeditor { get; set; }
        public int CustomerId { get; set; }
        public CustomerLegalPerson Customer { get; set; }
        public string Note { get; set; }
        public string Director { get; set; }
        public string Address { get; set; }
        public string ContractNumber { get; set; }
        public int TransportDocumentId { get; set; }
        public TransportDocument TransportDocument { get; set; }

        public int? CorrespondentBankExpeditorId { get; set; }
        public CorrespondentBank CorrespondentBankExpeditor { get; set; }
        public int? CorrespondentBankCustomerId { get; set; }
        public CorrespondentBank CorrespondentBankCustomer { get; set; }

        public virtual List<InvoiceTable> InvoiceTables { get; set; } = new List<InvoiceTable>();

        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile StampPhoto { get; set; }
    }
}
