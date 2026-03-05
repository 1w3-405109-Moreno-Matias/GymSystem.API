using GymSystem.Api.Models;

namespace GymSystem.Api.Repository.Interfaces
{
    public interface IPlanRepository
    {
        List<Plan> GetAllPlan();
        bool CreatePlan(Plan plan);
        bool UpdatePrice();

        Plan GetPlanById(int planId);
    }
}
