using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.EstateDtos
{
   public class EstateImageDto
    {
        public Guid EstateImageId { get; set; }
        public Guid EstateId { get; set; }
        public string ImageUrl { get; set; }
    }
}
