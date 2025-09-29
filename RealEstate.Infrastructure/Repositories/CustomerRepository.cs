using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Dtos.CustomerDtos;
using RealEstate.Application.Interfaces;
using RealEstate.Domain.Entities;
using RealEstate.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RealEstateDbContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(RealEstateDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Customer> AddCustomer(AddCustomerDto addCustomerDto)
        {
            var customer = _mapper.Map<Customer>(addCustomerDto);
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task DeleteCustomer(Guid CustomerId)
        {
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.CustomerId == CustomerId);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CustomerDto>> GetMyCustomers(Guid userId)
        {
            var customers = await _context.Customers.Where(c => c.AppUserId == userId).ToListAsync();
            var mappedCustomers = _mapper.Map<List<CustomerDto>>(customers);
            return mappedCustomers;
        }
    }
}
