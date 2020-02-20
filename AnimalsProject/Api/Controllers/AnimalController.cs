using Application.DTO;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IEnumerable<AnimalDto>> Get()
        {
            var animals = await _animalService.GetAllAnimals();
            return animals;
        }
    }
}