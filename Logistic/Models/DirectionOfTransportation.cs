namespace Logistic.Models
{
    public class DirectionOfTransportation
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<TransportDocumentTable> TransportDocumentTables { get; set; }
        public ICollection<TransportDocument> TransportDocuments { get; set; }
    }
}
