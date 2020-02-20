using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTO;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class DefectService : IDefectService
    {
        private readonly IRepository<Defect> _defectRepository;
        private readonly IRepository<AnimalDefects> _animalDefectRepository;
        public DefectService(IRepository<Defect> defectRepository,
            IRepository<AnimalDefects> animalDefectRepository)
        {
            _defectRepository = defectRepository;
            _animalDefectRepository = animalDefectRepository;
        }
        public async Task<DefectDto> CreateDefect(DefectDto defect)
        {
            await _defectRepository.AddAsync(new Defect()
            {
                Type = defect.Type,
                Created = defect.Created,
                CreatedBy = defect.CreatedBy,
                LastModified = defect.LastModified,
                LastModifiedBy = defect.LastModifiedBy
            });
            await _defectRepository.SaveAsync();
            return defect;
        }

        public async Task DeleteDefect(long defectId)
        {
            var tempDefect = await _defectRepository.GetByIdAsync(defectId);
            await _defectRepository.Remove(tempDefect);
            await _defectRepository.SaveAsync();
        }

        public async Task<IEnumerable<DefectDto>> GetAllDefects()
        {
            var tempDefects = await _defectRepository.GetAllAsync();
            return tempDefects.Select(d => new DefectDto()
            {
                Id = d.Id,
                Type = d.Type,
                Created = d.Created,
                CreatedBy = d.CreatedBy,
                LastModified = d.LastModified,
                LastModifiedBy = d.LastModifiedBy
            }).OrderBy(x => x.Type).ToList();
        }

        public IEnumerable<DefectDto> GetAllDefectsByAnimal(long animalId)
        {
            var animalDefects = _animalDefectRepository.GetAllAsync().Result;
            var defects = _defectRepository.GetAllAsync().Result;
            var tempDefects = (from d in defects
                               join a in animalDefects on d.Id equals a.DefectsId
                               where a.AnimalId == animalId
                               select new
                               {
                                   d.Id,
                                   d.Type,
                                   d.Created,
                                   d.CreatedBy,
                                   d.LastModified,
                                   d.LastModifiedBy
                               });
            return tempDefects.Select(d => new DefectDto()
            {
                Id = d.Id,
                Type = d.Type,
                Created = d.Created,
                CreatedBy = d.CreatedBy,
                LastModified = d.LastModified,
                LastModifiedBy = d.LastModifiedBy
            }).OrderBy(x => x.Type).ToList();
        }

        public async Task<DefectDto> GetDefectById(long id)
        {
            var defect = await _defectRepository.GetByIdAsync(id);
            return new DefectDto()
            {
                Id = defect.Id,
                Type = defect.Type,
                Created = defect.Created,
                CreatedBy = defect.CreatedBy,
                LastModified = defect.LastModified,
                LastModifiedBy = defect.LastModifiedBy
            };
        }

        public async Task UpdateDefect(DefectDto defect)
        {
            var tempDefect = await _defectRepository.GetByIdAsync(defect.Id);
            await _defectRepository.Update(tempDefect);
            await _defectRepository.SaveAsync();
        }
    }
}
