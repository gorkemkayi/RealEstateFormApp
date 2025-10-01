using AutoMapper;
using RealEstate.Application.Dtos.AppUserDtos;
using RealEstate.Application.Dtos.CustomerDtos;
using RealEstate.Application.Dtos.EstateDtos;
using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<RegisterUserDto,AppUser>().ForMember(dest=>dest.HashedPassword,opt=>opt.MapFrom(src=> BCrypt.Net.BCrypt.HashPassword(src.Password))).ReverseMap();


            #region CustomerDtoMapping
            CreateMap<Customer,CustomerDto>().ReverseMap();
            CreateMap<AddCustomerDto, Customer>();
            CreateMap<UpdateCustomerNoteDto, Customer>();
            #endregion

            #region EstateDtoMapping
            CreateMap<Estate, EstateDto>().ForMember(x => x.CustomerName, opt => opt.MapFrom(src => src.Customer.CustomerName)).ForMember(x=>x.EstateImages,opt=>opt.MapFrom(src=>src.EstateImages));
            CreateMap<CreateEstateDto, Estate>();
            CreateMap<EstateImage, EstateImageDto>();
            #endregion
        }
    }
}
