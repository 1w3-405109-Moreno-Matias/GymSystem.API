using GymSystem.Api.Models;

namespace GymSystem.Api.Repository.Interfaces
{
    public interface IPlanRepository
    {
        List<Plan> GetAllPlan();
    }
}
