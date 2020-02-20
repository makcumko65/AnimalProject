using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectController : ControllerBase
    {
        private readonly IDefectService _defectService;
        public DefectController(IDefectService defectService)
        {
            _defectService = defectService;
        }

        // GET: api/Defect
        [HttpGet]
        public async Task<IEnumerable<DefectDto>> GetDefects()
        {
            return await _defectService.GetAllDefects();
        }

        // GET: api/Defect/ByAnimal/1
        [HttpGet]
        [Route("ByAnimal/{animalId}")]
        public IEnumerable<DefectDto> GetDefectsByAnimal(long animalId)
        {
            return _defectService.GetAllDefectsByAnimal(animalId);
        }

        // GET: api/Defect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DefectDto>> GetDefect(long id)
        {
            var defect = await _defectService.GetDefectById(id);

            if (defect == null)
            {
                return NotFound();
            }

            return defect;
        }

        //// PUT: api/Defect
        //[HttpPut]
        //public async Task PutDefect([FromBody]DefectDto defect)
        //{
        //    await _defectService.UpdateDefect(defect);
        //}

        // POST: api/Defect
        [HttpPost]
        public async Task<ActionResult<DefectDto>> PostDefect([FromBody]DefectDto defect)
        {
            await _defectService.CreateDefect(defect);

            return CreatedAtAction("GetDefect", new { id = defect.Id }, defect);
        }

        // DELETE: api/Defect/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DefectDto>> DeleteDefect(long id)
        {
            var defect = await _defectService.GetDefectById(id);
            if (defect == null)
            {
                return NotFound();
            }

            await _defectService.DeleteDefect(id);

            return defect;
        }
    }
}