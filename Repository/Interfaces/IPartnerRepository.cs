using GymSystem.Api.Models;

namespace GymSystem.Api.Repository.Interfaces
{
    public interface IPartnerRepository
    {
        List<Partner> GetALL();
        Partner GetByNumberDocument(int partnerNumberDocument);
        bool Add(Partner AddPartner);
        bool Update(Partner UpdatePartner, int numberDocument);

        //delete baja lógica (suspendido o dado de baja)
    }
}
