﻿using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controllers
{
    [Route("api/[controller]")]
    public class InscriptionController : ControllerBase
    {
        public InscriptionService _inscriptionService { get; set; }   
        public InscriptionController(InscriptionService inscriptionService) {
            _inscriptionService = inscriptionService;
        }
        [HttpPost]
        public async Task<ActionResult> AddInscription(InscriptionDTO inscription)
        {
            try {
                _inscriptionService.AddInscription(inscription);
                return Ok(inscription);
            }
            catch ( Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
