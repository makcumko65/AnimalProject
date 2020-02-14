using Domain.Common;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Keeping : AnimalBase
    {
        public Keeping()
        {
            AnimalKeepings = new List<AnimalKeeping>();
        }
        public string Name { get; set; }
        public IList<AnimalKeeping> AnimalKeepings { get; set; }
    }
}

