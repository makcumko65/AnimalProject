using Domain.Common;

namespace Application.DTO
{
    public class VaccinationDto : AnimalBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
