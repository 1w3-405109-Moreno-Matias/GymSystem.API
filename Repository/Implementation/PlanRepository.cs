using GymSystem.Api.Data;
using GymSystem.Api.Models;
using GymSystem.Api.Repository.Interfaces;

namespace GymSystem.Api.Repository.Implementation
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymContext _dbContext;
        public PlanRepository(GymContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Plan> GetAllPlan()
        {
            return _dbContext.Plans.ToList();
        }
    }
}
