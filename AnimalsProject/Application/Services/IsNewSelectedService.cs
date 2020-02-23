using Application.DTO;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using System.Threading.Tasks;

namespace Application.Services
{
    public class IsNewSelectedService : IIsNewSelectedService
    {

        private readonly IRepository<Animal> _animalRepository;

        public IsNewSelectedService(IRepository<Animal> animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task UpdateIsNewCheckbox(IsNewDto animal)
        {
            if (!animal.IsNew)
            {
                var animalId = await _animalRepository.GetByIdAsync(animal.Id);
                animalId.FoundDate = animal.FoundDate;
                await _animalRepository.Update(animalId);
                await _animalRepository.SaveAsync();
            }
        }

        public async Task<IsNewDto> GetIsNewById(long id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);
            return new IsNewDto()
            {
                FoundDate = animal.FoundDate
            };
        }

        public async Task DeleteIsNewById(long id)
        {
            var animalId = await _animalRepository.GetByIdAsync(id);
            await _animalRepository.Remove(animalId);
            await _animalRepository.SaveAsync();
        }
    }
}
