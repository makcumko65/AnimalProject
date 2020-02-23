using Application.DTO;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IIsNewSelectedService
    {
        Task UpdateIsNewCheckbox(IsNewDto animal);

        Task<IsNewDto> GetIsNewById(long id);

        Task DeleteIsNewById(long isNewId);
    }
}
