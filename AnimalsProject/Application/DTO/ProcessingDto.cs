using Domain.Common;

namespace Application.DTO
{
    public class ProcessingDto : AnimalBase
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }
}
