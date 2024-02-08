using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class SortieRepository
    {
        public readonly SortieContext _context;
        public SortieRepository(SortieContext context)
        { _context = context; }

        public void AddSortie(Sortie sortie)
        {
            _context.Sortie.Add(sortie);
            _context.SaveChanges();
        }

    }
}
