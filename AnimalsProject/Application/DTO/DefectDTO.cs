using Domain.Common;

namespace Application.DTO
{
    public class DefectDto : AnimalBase
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }
}
