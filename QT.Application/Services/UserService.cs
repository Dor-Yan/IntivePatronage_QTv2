using AutoMapper;
using AutoMapper.QueryableExtensions;
using QT.Application.DTO;
using QT.Application.Interfaces;
using QT.Domain.Interface;
using QT.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public ListUserForListDto GetAllUsersForList()
        {
            var users = _userRepo.GetAllUsers().ProjectTo<UserForListDto>(_mapper.ConfigurationProvider).ToList();
            var userList = new ListUserForListDto()
            {
                Users = users,
               
            };

            return userList;

        }

        public UserDetailsDto GetUserDetails(int userId)
        {
            var user = _userRepo.GetUserDetails(userId);
            var userDto = _mapper.Map<UserDetailsDto>(user);
            return userDto;
        }

        public int AddUser(NewUserDto user)
        {
            var use = _mapper.Map<User>(user);
            var id = _userRepo.AddUser(use);
            return id;
        }

        public void UpdateUser(NewUserDto model)
        {
            var user = _mapper.Map<User>(model);
            _userRepo.UpdateUser(user);
        }

        public object GetUserForEdit(int id)
        {
            var user = _userRepo.GetUser(id);
            var userDto = _mapper.Map<NewUserDto>(user);
            return userDto;
        }
    }
}
