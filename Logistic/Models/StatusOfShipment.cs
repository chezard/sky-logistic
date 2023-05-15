namespace Logistic.Models
{
    public class StatusOfShipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<TransportDocumentTable> TransportDocumentTables { get; set; }
    }
}
