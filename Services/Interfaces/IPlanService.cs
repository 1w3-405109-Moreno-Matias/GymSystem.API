using GymSystem.Api.DTOs.PlanDtos;
using GymSystem.Api.Models;

namespace GymSystem.Api.Services.Interfaces
{
    public interface IPlanService
    {
        List<PlanDto> GetAllPlan();

        bool CreatePlan(Plan plan);

        bool UpdatePrice(int id,UpdatePriceDto updatePrice);
    }
}
