using Domain.Common;

namespace Application.DTO
{
    public class CategoryDto : AnimalBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
