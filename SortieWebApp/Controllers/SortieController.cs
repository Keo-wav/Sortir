using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Application.dt

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SortieController : ControllerBase
    {
        public SortieService _sortieService { get; set; }   
        public SortieController(SortieService sortieService) {
            _sortieService = sortieService;
        }
        [HttpPost]
        public async Task<ActionResult> AddSortie(SortieDTO sortie)
        {
            try {
                _sortieService.AddSortie(sortie);
                return Ok(sortie);
            }
            catch ( Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
