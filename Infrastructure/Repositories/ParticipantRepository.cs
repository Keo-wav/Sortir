using Domain.Entities;
using Infrastructure.Contexts;

namespace Infrastructure.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        public readonly ParticipantContext _context;
        public ParticipantRepository(ParticipantContext context)
        { _context = context; }

        public void AddParticipant(Participant participant)
        {
            _context.Participant.Add(participant);
            _context.SaveChanges();
        }

    }
}
