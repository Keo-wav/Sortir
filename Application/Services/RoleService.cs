

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class RoleService :IRoleService
    {
        public RoleRepository _rroleRepository { get; set; }

        public RoleService(RoleRepository rroleRepository)
        {
            _rroleRepository = rroleRepository;
        }
        public void AddRole(RoleDTO role)
        {
            _rroleRepository.AddRole(role);
        }
    }
}
