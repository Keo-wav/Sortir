using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class InscriptionRepository : IInscriptionRepository
    {
        public readonly InscriptionContext _context;
        public InscriptionRepository(InscriptionContext context)
        { _context = context; }

        public void AddInscription(Inscription inscription)
        {
            _context.Inscription.Add(inscription);
            _context.SaveChanges();
        }

    }
}
