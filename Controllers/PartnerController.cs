using GymSystem.Api.DTOs;
using GymSystem.Api.DTOs.PartnerDtos;
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
        public IActionResult GetByNumberDocument(int document)
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
                LastName = newPartnerDto.LastName,
                DocumentNumber = newPartnerDto.DocumentNumber,
                RegistrationDate = newPartnerDto.RegistrationDate,
                PlanId = newPartnerDto.PlanId
            };

            var success = _service.CreatePartner(newPartner);

            if (!success)
                return BadRequest("No se pudo crear el socio.");

            return CreatedAtAction(nameof(GetByNumberDocument), new { id = newPartner.DocumentNumber }, newPartner);
        }

        // PUT api/<PartnerController>/5
        [HttpPut]
        public IActionResult Put(int document, [FromBody] PartnerUpDateDto updatePartner)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var partnerToUpdate = new Partner
            {
                Name = updatePartner.Name,
                LastName = updatePartner.LastName,
                PlanId = updatePartner.PlanId
            };

            var success = _service.UpdatePartner(partnerToUpdate, document);

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
