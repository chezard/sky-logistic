using System.ComponentModel.DataAnnotations.Schema;

namespace Logistic.Models
{
    public class Personal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FathersName { get; set; }
        public DateTime Birthday { get; set; }
        public int PersonnelTypeId { get; set; }
        public PersonnelType PersonnelType { get; set; }
        //public int PositionId { get; set; }
        //public virtual Position Position { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string PersonalInformation { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        //public ICollection<TransportDocument> TransportDocuments { get; set; }
        //public ICollection<TransportDocumentTable> TransportDocumentTables { get; set; }
        //public ICollection<DocToAssistant> DocToAssistants { get; set; }
    }
}
