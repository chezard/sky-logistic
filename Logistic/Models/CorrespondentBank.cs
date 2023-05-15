using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    [Table("CorrespondentBanks")]
    public class CorrespondentBank
    {
        public int Id { get; set; }
        public int CorrespondentBankGroupId { get; set; }
        public CorrespondentBankGroup CorrespondentBankGroup { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Swift { get; set; }
        public string Kod { get; set; }
        public string MH { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public ICollection<Institution> Institutions { get; set; }
        public ICollection<CustomerLegalPerson> CustomerLegalPeople { get; set; }
    }
}
