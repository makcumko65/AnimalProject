using Domain.Common;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Category : AnimalBase
    {
        public Category()
        {
            Animals = new List<Animal>();
        }
        public string Name { get; set; }
        public IList<Animal> Animals { get; set; }
    }
}
