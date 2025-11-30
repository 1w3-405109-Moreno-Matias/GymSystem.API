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
            return _repository.Add(newPartner);
        }

        public List<Partner> GetAll()
        {
            return _repository.GetALL();
        }

        public Partner GetByNumberDocument(int numberDocument)
        {
            return _repository.GetByNumberDocument(numberDocument);
        }

        public bool Update(Partner upDatePartner, int numberDocument)
        {
            return _repository.Update(upDatePartner, numberDocument);
        }
    }
}
