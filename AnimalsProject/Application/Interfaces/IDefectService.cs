using Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDefectService
    {
        Task<IEnumerable<DefectDto>> GetAllDefects();
        IEnumerable<DefectDto> GetAllDefectsByAnimal(long animalId);
        Task<DefectDto> GetDefectById(long id);
        Task<DefectDto> CreateDefect(DefectDto defect);
        Task UpdateDefect(DefectDto defect);
        Task DeleteDefect(long defectId);
    }
}
