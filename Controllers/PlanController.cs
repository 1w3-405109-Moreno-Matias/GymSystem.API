using GymSystem.Api.DTOs.PlanDtos;
using GymSystem.Api.Models;
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

        [HttpPost]
        public IActionResult PostPlan([FromBody] PlanDto newPlanDto)
        {
            if(newPlanDto == null)
            {
                return BadRequest();
            }

            var newPlan = new Plan
            {
                Name = newPlanDto.Name,
                Description = newPlanDto.Description,
                MonthlyPrice = newPlanDto.MonthlyPrice,
                DurationInDays = newPlanDto.DurationInDays,
                IsActive = newPlanDto.IsActive
            };

            var created = _service.CreatePlan(newPlan);

            if (!created)
                return BadRequest("No se pudo crear el nuevo plan.");

            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult PutPricePlan(int id,[FromBody] UpdatePriceDto updatePricePlanDto) 
        {
            var updated = _service.UpdatePrice(id, updatePricePlanDto);

            if (!updated)
                return NotFound();

            return NoContent();
        }
    }
}
