namespace Logistic.Models
{
    public class TypeOfTransportation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<TransportDocumentTable> TransportDocumentTables { get; set; }
    }
}
