using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class RoleContext : DbContext
    {
        public DbSet<Role> Role { get; set; }
        public RoleContext(DbContextOptions<RoleContext> options) : base(options)
        {

        }
    }
}
