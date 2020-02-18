using Domain.Common;

namespace Application.DTO
{
    public class NeedsDto : AnimalBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
