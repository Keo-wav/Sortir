

using Domain.Entities;
using Infrastructure.Repositories;

namespace Application.Services
{
    public class LieuService :ILieuService
    {
        public LieuRepository _rlieuRepository { get; set; }

        public LieuService(LieuRepository rlieuRepository)
        {
            _rlieuRepository = rlieuRepository;
        }
        public void AddLieu(Lieu lieu)
        {
            _rlieuRepository.AddLieu(lieu);
        }
    }
}
