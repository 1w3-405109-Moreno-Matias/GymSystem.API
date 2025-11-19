namespace GymSystem.Api.Models
{
    public class Partner
    {
        public int IdPartner { get; set; }
        public string Name { get; set; }
        public string LastName{ get; set; }
        public int DocumentNumber { get; set; }
        public DateTime RegistrationDate  { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }
}
