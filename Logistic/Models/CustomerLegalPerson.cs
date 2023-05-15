using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class CustomerLegalPerson
    {
        public int Id { get; set; }
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
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
        //public int CorrespondentBankId { get; set; }
        //public CorrespondentBank CorrespondentBank { get; set; }
        public string FileName { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public ICollection<CustomerLegalPersonTable> CustomerLegalPersonTables { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
