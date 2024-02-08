

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class RoleService :IRoleService
    {
        public RoleRepository _rroleRepository { get; set; }

        public RoleService(RoleRepository rsortieRepository)
        {
            _rsortieRepository = rsortieRepository;
        }
        public void AddSortie(Sortie sortie)
        {
            _rsortieRepository.AddSortie(sortie);
        }
    }
}
