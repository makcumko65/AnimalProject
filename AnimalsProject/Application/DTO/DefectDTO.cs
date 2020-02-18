using Domain.Common;

namespace Application.DTO
{
    public class DefectDTO : AnimalBase
    {
        public long Id { get; set; }
        public string Type { get; set; }
    }
}
