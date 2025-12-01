using GymSystem.Api.DTOs;
using GymSystem.Api.Models;
using GymSystem.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerService _service;
        public PartnerController(IPartnerService services)
        {
            _service = services;
        }
        // GET: api/<PartnerController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _service.GetAll();

            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }

        // GET api/<PartnerController>/5
        [HttpGet("{id}")]
        public IActionResult GetByNumberDocumnet(int document)
        {
            var partner = _service.GetByNumberDocument(document);
            if (partner == null)
                return NotFound();
            return Ok(partner);
        }

        // POST api/<PartnerController>
        [HttpPost]
        public IActionResult Post([FromBody] PartnerCreateDto newPartnerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newPartner = new Partner
            {
                Name = newPartnerDto.Name,
                LastName = newPartnerDto.Name,
                DocumentNumber = newPartnerDto.DocumentNumber,
                RegistrationDate = newPartnerDto.RegistrationDate,
                PlanId = newPartnerDto.PlanId
            };

            var success = _service.Add(newPartner);

            if (!success)
                return BadRequest("No se pudo crear el socio.");

            return CreatedAtAction(nameof(GetByNumberDocumnet), new { id = newPartner.DocumentNumber }, newPartner);
        }

        // PUT api/<PartnerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Partner updatePartner)
        {
            if(updatePartner == null)
                return BadRequest();

            var success = _service.Update(updatePartner, id);

            if (!success)
                return NotFound();

            return NoContent();
        }

        // DELETE api/<PartnerController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
