using Domain.Common;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Needs : AnimalBase
    {
        public Needs()
        {
            AnimalNeeds = new List<AnimalNeeds>();
        }
        public string Name { get; set; }
        public IList<AnimalNeeds> AnimalNeeds { get; set; }
    }
}
