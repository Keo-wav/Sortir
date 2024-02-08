using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class LieuContext : DbContext
    {
        public DbSet<Lieu> Lieu { get; set; }

        public static implicit operator LieuContext(SortieContext v)
        {
            throw new NotImplementedException();
        }
    }
}
