using Microsoft.EntityFrameworkCore;

namespace GymSystem.Api.Models
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Precision(10, 2)]
        public decimal MonthlyPrice { get; set; }

        public int DurationInDays { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Partner> Partners { get; set; }
    }
}
