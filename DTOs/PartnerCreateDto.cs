namespace GymSystem.Api.DTOs
{
    public class PartnerCreateDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int PlanId { get; set; }
    }
}
