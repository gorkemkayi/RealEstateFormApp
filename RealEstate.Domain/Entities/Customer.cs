using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Estate> Estates { get; set; } = new List<Estate>();
        public string Gender { get; set; }
        [StringLength(11,MinimumLength =11,ErrorMessage ="Telefon numarası 11 haneli olmalıdır ")]
        [RegularExpression(@"^\d{11}$",ErrorMessage = "Telefon numarası sadece rakamlardan oluşmalıdır")]
        public string PhoneNumber { get; set; }
        public string? Note { get; set; }
    }
}
