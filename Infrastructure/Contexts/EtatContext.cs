using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class EtatContext : DbContext
    {
        public DbSet<Etat> Etat { get; set; }
        public EtatContext(DbContextOptions<EtatContext> options) : base(options)
        {

        }
    }
}
