using Domain.Common;

namespace Application.DTO
{
    public class FoodDto : AnimalBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
