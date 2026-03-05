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

        public bool CreatePlan(Plan plan)
        {
            _dbContext.Add(plan);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Plan> GetAllPlan()
        {
            return _dbContext.Plans.ToList();
        }

        public Plan GetPlanById(int planId)
        {
            return _dbContext.Plans.Find(planId);
        }

        public bool UpdatePrice()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
