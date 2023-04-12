using AutoMapper;
using Vuelos.Dtos;
using Vuelos.Models;

namespace Vuelos
{
    public class MappingProfile : Profile

    {
        public MappingProfile()
        {
            Mapper.CreateMap<Vuelo, VueloDto>();

            Mapper.CreateMap<VueloDto, Vuelo>()
                .ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}