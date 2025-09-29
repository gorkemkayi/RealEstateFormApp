using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.CustomerDtos
{
    public class AddCustomerDto
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public Guid AppUserId { get; set; }
        public string Gender { get; set; }
    }
}
