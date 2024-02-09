using Domain.Entities;

namespace Infrastructure.Repositories
{
    public interface IEtatService
    {
        void AddEtat(EtatDTO etat);
    }
}