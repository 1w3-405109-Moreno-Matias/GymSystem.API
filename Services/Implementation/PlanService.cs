using GymSystem.Api.DTOs.PlanDtos;
using GymSystem.Api.Repository.Interfaces;
using GymSystem.Api.Services.Interfaces;

namespace GymSystem.Api.Services.Implementation
{
    public class PlanService : IPlanService
    {
        private readonly IPlanRepository _repository;
        public PlanService(IPlanRepository repository)
        {
            _repository = repository;
        }
        public List<PlanDto> GetAllPlan()
        {
            var listPlan = _repository.GetAllPlan();
            var listPlanDto = new List<PlanDto>();

            foreach (var plan in listPlan)
            {
                var planDto = new PlanDto
                {
                    Name = plan.Name,
                    Description = plan.Description,
                    MonthlyPrice = plan.MonthlyPrice,
                    DurationInDays = plan.DurationInDays,
                    IsActive = plan.IsActive
                };

                listPlanDto.Add(planDto);
            }

            return listPlanDto;
        }
    }
}
