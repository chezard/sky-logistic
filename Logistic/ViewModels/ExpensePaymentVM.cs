using Logistic.Models;

namespace Logistic.ViewModels;

public class ExpensePaymentVM
{
    public TransportDocumentTable TransportDocumentTable { get; set; }
    public List<ApportionmentOfPaymentTable> ApportionmentOfPaymentTables { get; set; }
}