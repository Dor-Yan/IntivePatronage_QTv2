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
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public decimal? Weight { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewUserDto, User>().ForMember(r => r.Address, opt => opt.MapFrom(dto => new Address()
            {
                Country = dto.Country,
                City = dto.City,
                PostCode = dto.PostCode,
                Street = dto.Street,
                HouseNumber = dto.HouseNumber,
                LocalNumber = dto.LocalNumber
            }));
        }
    }
}
