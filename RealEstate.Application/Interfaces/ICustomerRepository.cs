using RealEstate.Application.Dtos.CustomerDtos;
using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<CustomerDto>> GetMyCustomers(Guid userId);
        Task<CustomerDto> GetCustomerById(Guid customerId);
        Task<Customer> AddCustomer(AddCustomerDto addCustomerDto);
        Task DeleteCustomer(Guid CustomerId);
        Task <Customer> UpdateCustomer(UpdateCustomerNoteDto updateCustomerNoteDto);
    }
}
