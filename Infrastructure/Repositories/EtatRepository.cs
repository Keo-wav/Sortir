using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class EtatRepository : IEtatRepository
    {
        public readonly EtatContext _context;
        public EtatRepository(EtatContext context)
        { _context = context; }

        public void AddEtat(Etat etat)
        {
            _context.Etat.Add(etat);
            _context.SaveChanges();
        }

    }
}
