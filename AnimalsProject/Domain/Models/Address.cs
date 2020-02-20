using Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Address : AnimalBase
    {
        public Address()
        {
            Animals = new List<Animal>();
        }
        
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<Animal> Animals { get; set; }
    }
}
