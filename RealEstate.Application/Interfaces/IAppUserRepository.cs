using RealEstate.Application.Dtos.AppUserDtos;
using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Application.Interfaces
{
    public interface IAppUserRepository
    {
        Task RegisterUser(RegisterUserDto registerUserDto);
        Task<AppUser> LoginUser(LoginUserDto loginUserDto);
        Task AddUserToSession(SessionUser sessionUser);
        Task<SessionUser> GetExistingUser();
    }
}
