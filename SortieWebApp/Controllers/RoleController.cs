using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace RoleWebApp.Controllers
{
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        public RoleService _roleService { get; set; }   
        public RoleController(RoleService roleService) {
            _roleService = roleService;
        }
        [HttpPost]
        public async Task<ActionResult> AddRole(RoleDTO role)
        {
            try {
                _roleService.AddRole(role);
                return Ok(role);
            }
            catch ( Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
