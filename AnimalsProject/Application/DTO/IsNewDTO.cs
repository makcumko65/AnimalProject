using System;
using Domain.Common;

namespace Application.DTO
{
    class IsNewDto : AnimalBase
    {
        public int id { get; set; }
        public bool IsNew { get; set; }
        public DateTime FoundDate { get; set; }
    }
}
