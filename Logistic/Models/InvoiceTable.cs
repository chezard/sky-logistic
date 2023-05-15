namespace Logistic.Models
{
    public class InvoiceTable
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public string Name { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
    }
}
