

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class InscriptionService :IInscriptionService
    {
        public InscriptionRepository _rinscriptionRepository { get; set; }

        public InscriptionService(SortieRepository rinscriptionRepository)
        {
            _rinscriptionRepository = rinscriptionRepository;
        }
        public void AddSortie(Sortie sortie)
        {
            _rinscriptionRepository.AddInscription(inscription);
        }
    }
}
