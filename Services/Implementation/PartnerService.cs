using GymSystem.Api.Models;
using GymSystem.Api.Repository.Interfaces;
using GymSystem.Api.Services.Interfaces;

namespace GymSystem.Api.Services.Implementation
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _repository;
        public PartnerService(IPartnerRepository repository)
        {
            _repository = repository;
        }
        public bool Add(Partner newPartner)
        {
            throw new NotImplementedException();
        }

        public List<Partner> GetAll()
        {
            throw new NotImplementedException();
        }

        public Partner GetByNumberDocument(int numberDocument)
        {
            throw new NotImplementedException();
        }

        public bool Update(Partner upDatePartner, int numberDocument)
        {
            throw new NotImplementedException();
        }
    }
}
