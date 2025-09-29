using AutoMapper;
using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using RealEstate.Application.Dtos.AppUserDtos;
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
    public class AppUserRepository:IAppUserRepository 
    {
        private readonly RealEstateDbContext _context;
        private readonly IMapper _mapper;


        public AppUserRepository(RealEstateDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddUserToSession(SessionUser sessionUser)
        {
            var existingSessions = await _context.SessionUsers.ToListAsync();
            if (existingSessions.Any())
            {
                _context.SessionUsers.RemoveRange(existingSessions);
            }
            await _context.SessionUsers.AddAsync(sessionUser);
            await _context.SaveChangesAsync();
        }

        public async Task<SessionUser> GetExistingUser()
        {
            var user=await _context.SessionUsers.FirstOrDefaultAsync();
            return user;
        }

        public async Task<AppUser> LoginUser(LoginUserDto loginUserDto)
        {
            var user = await _context.AppUsers.FirstOrDefaultAsync(x => x.Username == loginUserDto.Username);
            if (user != null && BCrypt.Net.BCrypt.Verify(loginUserDto.Password, user.HashedPassword))
            {
                await AddUserToSession(new SessionUser
                {
                    AppUserId = user.Id,
                    Username = user.Username,
                    Name = user.Name,
                    Surname = user.Surname
                    
                });
                return user;
            }
            throw new Exception ("Kullanıcı adı veya şifre hatalı");
        }

        public async Task RegisterUser(RegisterUserDto registerUserDto)
        {
            var user=_mapper.Map<AppUser>(registerUserDto);
            await _context.AppUsers.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
