using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTO;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IRepository<Animal> _repository;

        public AnimalService(IRepository<Animal> repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<AnimalDto>> GetAllAnimals()
        {
            throw new System.NotImplementedException();
        }

        public Task Update(AnimalDto animal)
        {
            throw new System.NotImplementedException();
        }
    }
}
