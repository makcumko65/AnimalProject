using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Application.DTO
{
    class IsNewDTO : AnimalBase
    {
        public int id { get; set; }
        public bool IsNew { get; set; }
        public DateTime FoundDate { get; set; }
    }
}
