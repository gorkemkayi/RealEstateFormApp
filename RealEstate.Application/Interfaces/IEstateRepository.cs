using RealEstate.Application.Dtos.EstateDtos;
using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces
{
   public interface IEstateRepository
    {
        Task<List<EstateDto>> GetMyEstates(Guid appUserId);
        Task<Estate> CreateEstate(CreateEstateDto createEstateDto); 
        Task RemoveEstate(Guid estateId);
    }
}
