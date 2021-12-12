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
    public class AddressForListDto : IMapFrom<QT.Domain.Model.Address>
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }

        public void Mapping(Profile profile)
        {


            profile.CreateMap<QT.Domain.Model.Address, QT.Application.DTO.AddressForListDto>();
                
        }
    }
}
