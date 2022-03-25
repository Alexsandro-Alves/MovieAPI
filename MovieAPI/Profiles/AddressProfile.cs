using AutoMapper;
using MovieAPI.Entities;
using MovieAPI.Models.Adress;

namespace MovieAPI.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressRequestModel, Address>();
            CreateMap<Address, AddressResponseModel>();
            CreateMap<UpdateAddressRequestModel, Address>();
        }

    }
}
