using Logistic.Models;

namespace Logistic.ViewModels
{
    public class TransportDocumentVM
    {
        public TransportDocument TransportDocument { get; set; }
        public List<TransportDocumentTable> TransportDocumentTables { get; set; }
    }
}
