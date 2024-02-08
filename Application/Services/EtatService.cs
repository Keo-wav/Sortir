

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class EtatService :IEtatService
    {
        public EtatRepository _retatRepository { get; set; }

        public EtatService(EtatRepository retatRepository)
        {
            _retatRepository = retatRepository;
        }
        public void AddEtat(Etat etat)
        {
            _retatRepository.AddEtat(etat);
        }
    }
}
