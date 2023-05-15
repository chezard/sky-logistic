using Logistic.Models;

namespace Logistic.ViewModels
{
    public class InvoiceVM
    {
        public Invoice Invoice { get; set; }
        public List<InvoiceTable> InvoiceTables { get; set; }
    }
}
