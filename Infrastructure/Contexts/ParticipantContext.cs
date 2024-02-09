using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class ParticipantContext : DbContext
    {
        public DbSet<Participant> Participant { get; set; }
        public ParticipantContext(DbContextOptions<ParticipantContext> options) : base(options)
        {

        }
    }
}
