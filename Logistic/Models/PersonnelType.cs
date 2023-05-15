namespace Logistic.Models
{
    public class PersonnelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<Personal> Personals { get; set; }

    }
}
