﻿using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ParticipantWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ParticipantController : ControllerBase
    {
        public ParticipantService _participantService { get; set; }   
        public ParticipantController(ParticipantService participantService) {
            _participantService = participantService;
        }
        [HttpPost]
        public async Task<ActionResult> AddParticipant(ParticipantDTO participant)
        {
            try {
                _participantService.AddParticipant(participant);
                return Ok(participant);
            }
            catch ( Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
