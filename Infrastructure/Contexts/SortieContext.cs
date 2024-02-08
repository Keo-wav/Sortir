using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class SortieContext : DbContext
    {
        public DbSet<Sortie> Sortie { get; set; }

        public static implicit operator SortieContext(InscriptionContext v)
        {
            throw new NotImplementedException();
        }
    }
}
