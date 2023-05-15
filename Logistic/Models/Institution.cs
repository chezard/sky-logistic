using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class Institution
    {
        public int Id { get; set; }
        public int EnterpriseTypeId { get; set; }
        public EnterpriseType EnterpriseType { get; set; }
        
        public string Name { get; set; }
        public string Leader { get; set; }
        public string Voen { get; set; }
        public string LegalAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
        public string HH1 { get; set; }
        public string HH2 { get; set; }
        public string HH3 { get; set; }
        public string HH4 { get; set; }

        public string Description { get; set; }
        public string FileName { get; set; }
        //public int? CorrespondentBankId { get; set; }
        //public CorrespondentBank CorrespondentBank { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public ICollection<TransportDocument> TransportDocuments { get; set; }
        public ICollection<TransportDocumentTable> TransportDocumentTables { get; set; }
        [NotMapped]
        public ICollection<Invoice> Invoices { get; set; }


    }
}
