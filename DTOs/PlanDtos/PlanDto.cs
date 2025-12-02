namespace GymSystem.Api.DTOs.PlanDtos
{
    public class PlanDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal MonthlyPrice { get; set; }
        public int DurationInDays { get; set; }
        public bool IsActive { get; set; }
    }
}
