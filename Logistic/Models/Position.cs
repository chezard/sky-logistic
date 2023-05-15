using System.ComponentModel.DataAnnotations;

namespace Logistic.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Personal> Personals { get; set; }
    }
}
