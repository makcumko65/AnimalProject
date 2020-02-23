using System;
using Domain.Common;

namespace Application.DTO
{
    public class IsNewDto : AnimalBase
    {
        public int Id { get; set; }

        public bool IsNew { get; set; }

        public DateTime FoundDate { get; set; }
    }
}
