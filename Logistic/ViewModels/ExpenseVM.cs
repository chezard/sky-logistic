using Logistic.Models;

namespace Logistic.ViewModels
{
    public class ExpenseVM
    {
        public TransportDocumentTable TransportDocumentTable { get; set; }
        public List<ApportionmentOfCostTable> ApportionmentOfCostTables { get; set; }
    }
}
