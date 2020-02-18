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
    }
}
