using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.EstateDtos
{
    public class EstateDto
    {
        public Guid EstateId { get; set; }
        public string EstateName { get; set; }
        public decimal Price { get; set; }
        public Guid AppUserId { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public List<EstateImageDto> EstateImages { get; set; }

    }
}
