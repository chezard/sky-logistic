using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class CustomerLegalPersonTable
    {
        public int Id { get; set; }
        
        public int CustomerLegalPersonId { get; set; }
        public CustomerLegalPerson CustomerLegalPerson { get; set; }
        public int ContractTypeId { get; set; }
        public ContractType ContractType { get; set; }
        public int ValyutaId { get; set; }
        public Valyuta Valyuta { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
