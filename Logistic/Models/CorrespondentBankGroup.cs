using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class CorrespondentBankGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<CorrespondentBank> CorrespondentBanks { get; set; }
    }
}
