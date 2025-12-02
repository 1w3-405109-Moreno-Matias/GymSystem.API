using GymSystem.Api.DTOs.PlanDtos;
using GymSystem.Api.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _service;

        public PlanController(IPlanService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllPlan()
        {
            var list = _service.GetAllPlan() ?? new List<PlanDto>();

            return Ok(list);
        }
    }
}
