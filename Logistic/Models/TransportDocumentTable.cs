namespace Logistic.Models
{
    public class TransportDocumentTable
    {
        public int Id { get; set; }
        public int TransportDocumentId { get; set; }
        public TransportDocument TransportDocument { get; set; }
        public int ConditionOfCarriageId { get; set; }
        public ConditionOfCarriage ConditionOfCarriage { get; set; }
        public DateTime Date { get; set; }
        public int StatusOfShipmentId { get; set; }
        public StatusOfShipment StatusOfShipment { get; set; }
        public int TypeOfTransportationId { get; set; }
        public TypeOfTransportation TypeOfTransportation { get; set; }
        public int DirectionOfTransportationId { get; set; }
        public DirectionOfTransportation DirectionOfTransportation { get; set; }
        public string Customer { get; set; }
        public int InstitutionId { get; set; }
        public Institution Institution { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }

        public int ValyutaId { get; set; }
        public Valyuta Valyuta { get; set; }

        public string DriverName { get; set; }

        public string DriverPhone { get; set; }

        public string TruckPlate { get; set; }

        public string Name { get; set; }
        public string Count { get; set; }
        public double Salary { get; set; }
        public double CommonSalary { get; set; }
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
        public string Description { get; set; }

        public List<ApportionmentOfCostTable> CostList { get; set; }
        public List<ApportionmentOfValueTable> ValueList { get; set; }
        public List<ApportionmentOfPaymentTable> PaymentList { get; set; }
    }
}
