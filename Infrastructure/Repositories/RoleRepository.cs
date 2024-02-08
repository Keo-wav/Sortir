using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        public readonly RoleContext _context;
        public RoleRepository(RoleContext context)
        { _context = context; }

        public void AddRole(Role role)
        {
            _context.Role.Add(role);
            _context.SaveChanges();
        }
    }
}
