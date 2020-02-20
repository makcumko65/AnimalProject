using Domain.Common;
using Domain.Models;

namespace Application.DTO
{
    public class AttitudeToDto : AnimalBase
    {
        public AttitudeToDto(AttitudeTo attitudeTo, int mark)
        {
            Id = attitudeTo.Id;
            Name = attitudeTo.Name;
            Mark = mark;
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
    }
}
