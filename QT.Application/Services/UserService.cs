﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using QT.Application.DTO;
using QT.Application.Interfaces;
using QT.Domain.Interface;

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

            //var users = _userRepo.GetAllUsers();
            //ListUserForListDto result = new ListUserForListDto();
            //result.Users = new List<UserForListDto>();
            //foreach (var  user in users)
            //{
            //    var userDto = new UserForListDto()
            //    {
            //        id = user.Id,
            //        FirstName = user.FirstName,
            //        LastName = user.LastName
            //    };

            //    result.Users.Add(userDto);
            //}
            //return result;
        }

        public UserDetailsDto GetUserDetails(int userId)
        {
            var user = _userRepo.GetUserDetails(userId);
            var userDto = _mapper.Map<UserDetailsDto>(user);
            return userDto;
        }
    }
}