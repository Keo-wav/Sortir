using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class SortieController : ControllerBase
    {
        public ISortieService _sortieService { get; set; }   
        public SortieController(ISortieService sortieService) {
            _sortieService = sortieService;
        }
        [HttpPost]
        public async Task<ActionResult> AddSortie(Sortie sortie)
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
