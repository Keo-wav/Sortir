

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class InscriptionService :IInscriptionService
    {
        public InscriptionRepository _rinscriptionRepository { get; set; }

        public InscriptionService(InscriptionRepository rinscriptionRepository)
        {
            _rinscriptionRepository = rinscriptionRepository;
        }
        public void AddInscription(InscriptionDTO inscription)
        {
            _rinscriptionRepository.AddInscription(inscription);
        }

    }
}
