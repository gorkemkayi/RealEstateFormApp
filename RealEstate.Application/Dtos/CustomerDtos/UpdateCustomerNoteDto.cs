using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Dtos.CustomerDtos
{
    public class UpdateCustomerNoteDto
    {
        public Guid CustomerId { get; set; }
        public string? Note { get; set; }
    }
}
