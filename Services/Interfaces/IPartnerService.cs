using GymSystem.Api.Models;

namespace GymSystem.Api.Services.Interfaces
{
    public interface IPartnerService
    {
        List<Partner> GetAll();
        bool Add(Partner newPartner);
        bool Update(Partner upDatePartner, int numberDocument);
        Partner GetByNumberDocument(int numberDocument);
    }
}
