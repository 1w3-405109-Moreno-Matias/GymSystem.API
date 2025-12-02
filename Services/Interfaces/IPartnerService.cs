using GymSystem.Api.Models;

namespace GymSystem.Api.Services.Interfaces
{
    public interface IPartnerService
    {
        List<Partner> GetAll();
        bool CreatePartner(Partner newPartner);
        bool UpdatePartner(Partner upDatePartner, int numberDocument);
        Partner GetByNumberDocument(int numberDocument);
    }
}
