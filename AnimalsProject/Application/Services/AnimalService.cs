using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IRepository<Animal> _repository;
        private readonly IMapper _mapper;

        public AnimalService(IRepository<Animal> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AnimalDto>> GetAllAnimals()
        {
            var animals = await _repository.Entities
                      .Include(animal => animal.AnimalNeeds)
                        .ThenInclude(need => need.Needs)
                      .Include(animal => animal.AnimalVaccinations)
                        .ThenInclude(vac => vac.Vaccination)
                      .Include(animal => animal.AnimalProcessings)
                        .ThenInclude(proc => proc.Processing)
                      .Include(animal => animal.AnimalKeepings)
                        .ThenInclude(keep => keep.Keeping)
                      .Include(animal => animal.AnimalAttitudes)
                        .ThenInclude(att=> att.AttitudeTo)
                      .Include(animal => animal.AnimalDefects)
                        .ThenInclude(defect => defect.Defect).ToListAsync();
            var animalsDto = animals.Select(x => _mapper.Map<AnimalDto>(x));
            return animalsDto;
        }

        public Task UpdateAnimal(AnimalDto animal)
        {
            throw new System.NotImplementedException();
        }
    }
}
