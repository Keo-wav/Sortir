using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class EtatContext : DbContext
    {
        public DbSet<Inscription> Inscription { get; set; }
    }
}
