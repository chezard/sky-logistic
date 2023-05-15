namespace Logistic.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string TopGroup { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        //public List<TransportDocument> TransportDocuments { get; set; }
        //public List<TransportDocumentTable> TransportDocumentTables { get; set; }
    }
}
