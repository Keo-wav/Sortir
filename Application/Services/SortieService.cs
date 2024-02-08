

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class SortieService
    {
        public SortieRepository _rsortieRepository { get; set; }

        public SortieService(SortieRepository rsortieRepository)
        {
            _rsortieRepository = rsortieRepository;
        }
        public void AddSortie(Sortie sortie)
        {
            _rsortieRepository.AddSortie(sortie);
        }
    }
}
