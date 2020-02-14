using Domain.Common;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Image : AnimalBase
    {
        public byte[] Img { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
