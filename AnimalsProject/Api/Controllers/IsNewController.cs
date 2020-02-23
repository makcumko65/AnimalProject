﻿using System.Threading.Tasks;
using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsNewController : ControllerBase
    {
        private readonly IIsNewSelectedService _isNewService;
        public IsNewController(IIsNewSelectedService isNewService)
        {
            _isNewService = isNewService;
        }

        // PUT: api/IsNew
        [HttpPut]
        public async Task PutIsNew([FromBody]IsNewDto animal)
        {
            await _isNewService.UpdateIsNewCheckbox(animal);
        }

        // GET: api/IsNew/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IsNewDto>> GetIsNew(long id)
        {
            var animal = await _isNewService.GetIsNewById(id);

            if (animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }

        // DELETE: api/IsNew/3
        [HttpDelete("{id}")]
        public async Task<ActionResult<IsNewDto>> DeleteIsNew(long id)
        {
            var isNew = await _isNewService.GetIsNewById(id);
            if (isNew == null)
            {
                return NotFound();
            }

            await _isNewService.DeleteIsNewById(id);

            return Ok(isNew);
        }
    }
}
