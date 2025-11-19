namespace GymSystem.Api.Models
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; }
        public decimal MonthlyPrice { get; set; }
        public ICollection<Partner> Partners { get; set; }
    }
}
