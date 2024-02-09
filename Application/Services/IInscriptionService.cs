using Domain.Entities;

namespace Application.Services
{
    public interface IInscriptionService
    {
        void AddInscription(InscriptionDTO inscription);
    }
}