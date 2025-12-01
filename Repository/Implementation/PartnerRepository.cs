using GymSystem.Api.Data;
using GymSystem.Api.Models;
using GymSystem.Api.Repository.Interfaces;

namespace GymSystem.Api.Repository.Implementation
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly GymContext _dbContext;

        public PartnerRepository(GymContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool CreatePartner(Partner AddPartner)
        {
            _dbContext.Partners.Add(AddPartner);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Partner> GetALL()
        {
            return _dbContext.Partners.ToList();
        }
        public Partner GetByNumberDocument(int partnerNumberDocument)
        {
            return _dbContext.Partners.FirstOrDefault(p => p.DocumentNumber == partnerNumberDocument);
        }
        public bool UpdatePartner(Partner UpdatePartner, int numberDocument)
        {
            var exist = GetByNumberDocument(numberDocument);
            if(exist == null)
            {
                return false;
            }

            // if (!_dbContext.Plans.Any(p => p.PlanId == updatePartner.PlanId))
            //     return false;

            exist.Name = UpdatePartner.Name;
            exist.LastName = UpdatePartner.LastName;
            exist.PlanId = UpdatePartner.PlanId;

            return _dbContext.SaveChanges() > 0;
        }
    }
}
