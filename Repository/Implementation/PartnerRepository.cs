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
        public bool Add(Partner AddPartner)
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
        public bool Update(Partner UpdatePartner, int numberDocument)
        {
            var exist = GetByNumberDocument(numberDocument);
            if(exist == null)
            {
                return false;
            }
            _dbContext.Partners.Update(UpdatePartner);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
