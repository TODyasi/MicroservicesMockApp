using AutoMapper;
using ClientAPI.Data.DTO_s;
using ClientAPI.Models;

namespace ClientAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientModel, ClientDto>();
            CreateMap<ClientDto, ClientModel>();
        }
    }
}
