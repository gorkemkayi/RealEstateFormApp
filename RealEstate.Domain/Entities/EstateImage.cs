using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class EstateImage
    {

        public Guid EstateImageId { get; set; }
        public Guid EstateId { get; set; }
        public Estate Estate { get; set; }
        public string ImageUrl { get; set; }
    }
}
