using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class UnofficialClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime Date { get; set; }
        public string FileName { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }
    }
}
