using GymSystem.Api.Models;

namespace GymSystem.Api.Repository.Interfaces
{
    public interface IPartnerRepository
    {
        List<Partner> GetALL();
        Partner GetByNumberDocument(int partnerNumberDocument);
        bool CreatePartner(Partner AddPartner);
        bool UpdatePartner(Partner UpdatePartner, int numberDocument);

        //delete baja lógica (suspendido o dado de baja)
    }
}
