using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class LieuRepository : ILieuRepository
    {
        public readonly LieuContext _context;
        public LieuRepository(SortieContext context)
        { _context = context; }

        public void AddLieu(Lieu lieu)
        {
            _context.Lieu.Add(lieu);
            _context.SaveChanges();
        }

    }
}
