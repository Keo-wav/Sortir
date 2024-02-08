

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class ParticipantService :IParticipantService
    {
        public ParticipantRepository _rparticipantRepository { get; set; }

        public ParticipantService(ParticipantRepository rparticipantRepository)
        {
            _rparticipantRepository = rparticipantRepository;
        }
        public void AddParticipant(Participant participant)
        {
            _rparticipantRepository.AddParticipant(participant);
        }
    }
}
