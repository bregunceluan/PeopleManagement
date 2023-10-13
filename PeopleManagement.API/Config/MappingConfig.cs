using AutoMapper;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Model;

namespace PeopleManagement.API.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CargoDTO, Cargo>();
                config.CreateMap<Cargo, CargoDTO>();
                config.CreateMap<EquipeDTO, Equipe>();
                config.CreateMap<Equipe, EquipeDTO>();
                config.CreateMap<UserDTO, User>();
                config.CreateMap<User, UserDTO>();
            });
            return mappingConfig;
        }
    } 
}
