using GymSystem.Api.DTOs.PlanDtos;

namespace GymSystem.Api.Services.Interfaces
{
    public interface IPlanService
    {
        List<PlanDto> GetAllPlan();
    }
}
