using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Dtos.EstateDtos;
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
    public class EstateRepository : IEstateRepository
    {
        private readonly RealEstateDbContext _context;
        private readonly IMapper _mapper;

        public EstateRepository(RealEstateDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Estate> CreateEstate(CreateEstateDto createEstateDto)
        {
           var estate= _mapper.Map<Estate>(createEstateDto);
            if (createEstateDto.ImageUrls !=null && createEstateDto.ImageUrls.Any())
            {
                foreach (var url in createEstateDto.ImageUrls)
                {
                    estate.EstateImages.Add(new EstateImage
                    {
                        EstateImageId = Guid.NewGuid(),
                        EstateId = estate.EstateId,
                        ImageUrl = url
                    });
                }
            }
            await _context.Estates.AddAsync(estate);
            await _context.SaveChangesAsync();
            return estate;

        }

        public async Task<List<EstateDto>> GetMyEstates(Guid appUserId)
        {
            var estates = await _context.Estates.Include(x => x.Customer).Include(x=>x.EstateImages).Where(x=>x.AppUserId==appUserId).ToListAsync();
            var mappedEstates = _mapper.Map<List<EstateDto>>(estates);
            return mappedEstates;
        }

        public async Task RemoveEstate(Guid estateId)
        {
            var estate=await _context.Estates.FirstOrDefaultAsync(x=>x.EstateId == estateId);

             _context.Estates.Remove(estate);
            await _context.SaveChangesAsync();
        }
    }
}
