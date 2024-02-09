using Domain.Entities;

namespace Application.Services
{
    public interface IParticipantService
    {
        void AddParticipant(ParticipantDTO participant);
    }
}