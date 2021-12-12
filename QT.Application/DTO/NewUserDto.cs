using AutoMapper;
using QT.Application.Mapping;
using QT.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Application.DTO
{
    public class NewUserDto : IMapFrom<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public decimal? Weight { get; set; }
        public int AddressId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewUserDto, User>().ReverseMap();
        }
    }
}
