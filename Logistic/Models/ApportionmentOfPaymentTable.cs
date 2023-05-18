namespace Logistic.Models
{
    public class ApportionmentOfPaymentTable
    {
        public int Id { get; set; }
        public int TransportDocumentTableId { get; set; }
        public TransportDocumentTable TransportDocumentTable { get; set; }
        public string Expense  { get; set; }
        public double Amount  { get; set; }
        public int? ValyutaId  { get; set; }
        public Valyuta Valyuta  { get; set; }
        public DateTime Date  { get; set; }
        public string Note  { get; set; }
    }
}
