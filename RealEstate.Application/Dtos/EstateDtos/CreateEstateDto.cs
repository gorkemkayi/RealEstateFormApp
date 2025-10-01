using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.EstateDtos
{
   public class CreateEstateDto
    {
        public Guid EstateId { get; set; }
        public string EstateName { get; set; }
        public decimal Price { get; set; }
        public Guid AppUserId { get; set; }
        public Guid CustomerId { get; set; }
        public string Status { get; set; } = "İlanda";

        public List<string> ImageUrls { get; set; } = new List<string>();
    }
}
