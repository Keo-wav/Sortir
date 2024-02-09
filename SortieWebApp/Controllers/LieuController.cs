using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LieuWebApp.Controllers
{
    [Route("api/[controller]")]
    public class LieuController : ControllerBase
    {
        public LieuService _lieuService { get; set; }   
        public LieuController(LieuService lieuService) {
            _lieuService = lieuService;
        }
        [HttpPost]
        public async Task<ActionResult> AddLieu(LieuDTO lieu)
        {
            try {
                _lieuService.AddLieu(lieu);
                return Ok(lieu);
            }
            catch ( Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
