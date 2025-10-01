using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.CustomerDtos
{
   public class CustomerDto
    {
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string? Note { get; set; }
    }
}
