using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class Estate
    {
        public Guid EstateId { get; set; }
        public string EstateName { get; set; }
        public decimal Price { get; set; }
        public List<EstateImage> EstateImages { get; set; } = new List<EstateImage>();
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string Status { get; set; }

    }
}
