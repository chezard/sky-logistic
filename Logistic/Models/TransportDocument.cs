namespace Logistic.Models
{
    public class TransportDocument
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
        public int DirectionOfTransportationId { get; set; }
        public virtual DirectionOfTransportation DirectionOfTransportation { get; set; }
        public  string FirstAddress { get; set; }
        public  string LastAddress { get; set; }
        public DateTime Date { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
        public int Assistant1Id { get; set; }
        public Personal Assistant1 { get; set; }
        
        public string Assistant2 { get; set; }
        
        public string Assistant3 { get; set; }
        
        public string Assistant4 { get; set; }

        public List<TransportDocumentTable> TransportDocumentTables { get; set; }
    }
}
