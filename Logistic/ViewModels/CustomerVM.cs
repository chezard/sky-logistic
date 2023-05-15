using Logistic.Models;

namespace Logistic.ViewModels
{
    public class CustomerVM
    {
        public CustomerLegalPerson CustomerLegalPerson { get; set; }
        public List<CustomerLegalPersonTable> CustomerLegalPersonTables { get; set; }
    }
}
