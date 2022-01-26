using API.DTOs;
using AutoMapper;
using Address = Core.Entities.Address;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
