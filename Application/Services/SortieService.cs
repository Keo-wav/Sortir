

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class SortieService :ISortieService
    {
        public ISortieRepository _rsortieRepository { get; set; }

        public SortieService(ISortieRepository rsortieRepository)
        {
            _rsortieRepository = rsortieRepository;
        }
        public void AddSortie(SortieDTO sortie)
        {
            _rsortieRepository.AddSortie(sortie);
        }
    }
}
